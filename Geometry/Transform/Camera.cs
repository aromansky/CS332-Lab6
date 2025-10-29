using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CS332_Lab6.Geometry.Transform
{
    internal enum ProjectionMode
    {
        Perspective,
        Trimetric,
        Dimetric,
        Isometric
    }

    internal class Camera
    {
        public Point3D Position { get; set; }
        public Point3D Target { get; set; } = new Point3D(0, 0, 0);

        public float FovDegrees { get; set; } = 60f;
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public ProjectionMode Mode { get; set; } = ProjectionMode.Perspective;

        public float AxonometricAngleX { get; set; }
        public float AxonometricAngleY { get; set; }
        public float OrthoScale { get; set; } = 100f;

        public Camera(Point3D position, float fovDegrees, int screenWidth, int screenHeight)
        {
            Position = position;
            FovDegrees = fovDegrees;
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;

            SetModeDefaults(Mode);
        }

        private void SetModeDefaults(ProjectionMode mode)
        {
            switch (mode)
            {
                case ProjectionMode.Isometric:
                    AxonometricAngleX = 35.264f;
                    AxonometricAngleY = 45f;
                    OrthoScale = Math.Min(ScreenWidth, ScreenHeight) / 4f;
                    break;
                case ProjectionMode.Dimetric:
                    AxonometricAngleX = 20.705f;
                    AxonometricAngleY = 45f;
                    OrthoScale = Math.Min(ScreenWidth, ScreenHeight) / 4f;
                    break;
                case ProjectionMode.Trimetric:
                    AxonometricAngleX = 25f;
                    AxonometricAngleY = 15f;
                    OrthoScale = Math.Min(ScreenWidth, ScreenHeight) / 4f;
                    break;
                case ProjectionMode.Perspective:
                default:
                    break;
            }
        }

        public void SetMode(ProjectionMode mode)
        {
            Mode = mode;
            SetModeDefaults(mode);
        }

        public PointF Project(Point3D p)
        {
            switch (Mode)
            {
                case ProjectionMode.Perspective:
                    return ProjectPerspective(p);
                case ProjectionMode.Isometric:
                case ProjectionMode.Dimetric:
                case ProjectionMode.Trimetric:
                    return ProjectAxonometric(p, AxonometricAngleX, AxonometricAngleY);
                default:
                    return ProjectPerspective(p);
            }
        }

        private PointF ProjectPerspective(Point3D p)
        {
            var (px, py, pz) = p.GetCoords();
            var (cx, cy, cz) = Position.GetCoords();

            float x = px - cx;
            float y = py - cy;
            float z = pz - cz;

            if (z <= 0.0001f)
                return new PointF(float.NaN, float.NaN);

            float f = (float)((ScreenHeight / 2.0) / Math.Tan((FovDegrees * Math.PI / 180.0) / 2.0));

            float sx = (f * x) / z;
            float sy = (f * y) / z;

            float screenX = ScreenWidth / 2f + sx;
            float screenY = ScreenHeight / 2f - sy;

            return new PointF(screenX, screenY);
        }

        private PointF ProjectAxonometric(Point3D p, float angleXdeg, float angleYdeg)
        {
            var (px, py, pz) = p.GetCoords();
            var (cx, cy, cz) = Position.GetCoords();

            

            float ax = angleXdeg * (float)Math.PI / 180f;
            float ay = angleYdeg * (float)Math.PI / 180f;

            var rel = new Point3D(px, py, pz); // точка в мировой системе

            rel = new Point3D(px, py, pz);

            Matrix rotX = Transform.CreateRotationAroundXMatrix(AxonometricAngleX * (float)Math.PI / 180);
            Matrix rotY = Transform.CreateRotationAroundYMatrix(AxonometricAngleY * (float)Math.PI / 180);

            Matrix factor = Matrix.Identity(4);
            factor[2, 3] = 0;

            Matrix composite = rotY * rotX * factor;
            Point3D transformed = Transform.Apply(composite, rel);

            float screenX = ScreenWidth / 2f + transformed.X * OrthoScale;
            float screenY = ScreenHeight / 2f - transformed.Y * OrthoScale;

            return new PointF(screenX, screenY);
        }

        public List<List<PointF>> Project(Polyhedron poly)
        {
            var allProjected = new List<PointF>();
            var result = new List<List<PointF>>();

            foreach (var face in poly.Faces)
            {
                var projected = new List<PointF>();
                foreach (var v in face.Vertices)
                {
                    var proj = Project(v);
                    projected.Add(proj);
                    allProjected.Add(proj);
                }
                result.Add(projected);
            }

            if (Mode != ProjectionMode.Perspective)
            {
                float minX = allProjected.Where(p => !float.IsNaN(p.X)).Min(p => p.X);
                float maxX = allProjected.Where(p => !float.IsNaN(p.X)).Max(p => p.X);
                float minY = allProjected.Where(p => !float.IsNaN(p.Y)).Min(p => p.Y);
                float maxY = allProjected.Where(p => !float.IsNaN(p.Y)).Max(p => p.Y);

                for (int i = 0; i < result.Count; i++)
                {
                    for (int j = 0; j < result[i].Count; j++)
                    {
                        var p = result[i][j];
                        result[i][j] = new PointF(p.X, p.Y);
                    }
                }
            }

            return result;
        }

    }
}
