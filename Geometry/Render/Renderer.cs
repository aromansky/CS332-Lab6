using Geometry.Render;
using System;
using System.Drawing;

namespace Geometry
{
    public enum RenderMode
    {
        None,
        Gouraud,
        Phong
    }
    public class Renderer
    {
        private readonly Camera camera;
        private readonly int width;
        private readonly int height;
        private readonly float[,] zBuffer;
        private MyImage myImage;

        private RenderMode renderMode = RenderMode.Gouraud;

        public LightSource Light { get; set; }

        public Renderer(Camera camera, int width, int height)
        {
            this.camera = camera;
            this.width = width;
            this.height = height;
            myImage = MyImage.CreateWhiteImage(width, height);
            zBuffer = new float[width, height];
        }

        public Renderer(Camera camera, int width, int height, LightSource lightSource)
        {
            this.camera = camera;
            this.width = width;
            this.height = height;
            myImage = MyImage.CreateWhiteImage(width, height);
            zBuffer = new float[width, height];

            this.Light = lightSource;
        }

        public void Clear(Color background)
        {
            myImage.Lock();
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    myImage.SetPixel(x, y, background);
                    zBuffer[x, y] = float.MaxValue;
                }
            myImage.Unlock();
        }

        public void Render(Polyhedron polyhedron, Color color)
        {
            myImage.Lock();
            foreach (var face in polyhedron.Faces)
            {
                if (!face.IsFrontFace(camera))
                    continue;
                DrawFaceZ(face, color);
            }
            myImage.Unlock();
        }


        public void Render(Polyhedron polyhedron)
        {
            myImage.Lock();
            foreach (var face in polyhedron.Faces)
            {
                if (!face.IsFrontFace(camera))
                    continue;
                switch (renderMode)
                {
                    case RenderMode.Gouraud:
                        Vector3 faceObjectColor = face.ObjectColor;

                        List<Vertex> shadedVertices = face.Vertices.Select(v => {
                            v.Color = ShadingUtils.CalculateLambertColor(this.Light, v, faceObjectColor);
                            return v;
                        }).ToList();
                        DrawFaceGouraudZ(shadedVertices);
                        break;
                    case RenderMode.Phong:
                        // Phong shading implementation would go here
                        break;
                    case RenderMode.None:
                        DrawFaceZ(face, face.ObjectColor);
                        break;
                }
            }
            myImage.Unlock();
        }

        public void DrawFacePhongZ(List<Vertex> faceVertices)
        {
            if (faceVertices.Count < 3) return;

            Vertex v0 = faceVertices[0];
            for (int i = 1; i < faceVertices.Count - 1; i++)
            {
                Vertex v1 = faceVertices[i];
                Vertex v2 = faceVertices[i + 1];
                DrawTrianglePhongZ(v0, v1, v2);
            }
        }

        private void DrawTrianglePhongZ(Vertex v0, Vertex v1, Vertex v2)
        {
            // TODO
        }


        public void DrawFaceGouraudZ(List<Vertex> shadedVertices)
        {
            if (shadedVertices.Count < 3) return;

            Vertex v0 = shadedVertices[0];
            for (int i = 1; i < shadedVertices.Count - 1; i++)
            {
                Vertex v1 = shadedVertices[i];
                Vertex v2 = shadedVertices[i + 1];
                DrawTriangleGouraudZ(v0, v1, v2);
            }
        }

        private void DrawTriangleGouraudZ(Vertex v0, Vertex v1, Vertex v2)
        {
            var p0 = camera.ProjectPoint2D(v0);
            var p1 = camera.ProjectPoint2D(v1);
            var p2 = camera.ProjectPoint2D(v2);

            if (!p0.HasValue || !p1.HasValue || !p2.HasValue)
                return;

            PointF a = p0.Value;
            PointF b = p1.Value;
            PointF c = p2.Value;

            int minX = (int)Math.Max(0, Math.Min(a.X, Math.Min(b.X, c.X)));
            int maxX = (int)Math.Min(width - 1, Math.Max(a.X, Math.Max(b.X, c.X)));
            int minY = (int)Math.Max(0, Math.Min(a.Y, Math.Min(b.Y, c.Y)));
            int maxY = (int)Math.Min(height - 1, Math.Max(a.Y, Math.Max(b.Y, c.Y)));

            var p0_3 = camera.ProjectPoint(v0);
            var p1_3 = camera.ProjectPoint(v1);
            var p2_3 = camera.ProjectPoint(v2);

            float area = EdgeFunction(a, b, c);
            if (Math.Abs(area) < 1e-6f) return;

            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    var p = new PointF(x + 0.5f, y + 0.5f);

                    float w0 = EdgeFunction(b, c, p);
                    float w1 = EdgeFunction(c, a, p);
                    float w2 = EdgeFunction(a, b, p);

                    if (w0 * area >= 0 && w1 * area >= 0 && w2 * area >= 0)
                    {
                        w0 /= area;
                        w1 /= area;
                        w2 /= area;

                        float z = w0 * p0_3.Z + w1 * p1_3.Z + w2 * p2_3.Z;

                        if (z < zBuffer[x, y])
                        {
                            zBuffer[x, y] = z;

                            float r = w0 * v0.Color.X + w1 * v1.Color.X + w2 * v2.Color.X;
                            float g = w0 * v0.Color.Y + w1 * v1.Color.Y + w2 * v2.Color.Y;
                            float bCol = w0 * v0.Color.Z + w1 * v1.Color.Z + w2 * v2.Color.Z;

                            Color color = Color.FromArgb(
                                Math.Min(255, (int)(r * 255)),
                                Math.Min(255, (int)(g * 255)),
                                Math.Min(255, (int)(bCol * 255))
                            );

                            myImage.SetPixel(x, y, color);
                        }
                    }
                }
            }
        }

        private void DrawFaceZ(Face face, Vector3 color)
        {
            int n = face.Vertices.Count;
            Color col = Color.FromArgb(
                (int)(color.X * 255),
                (int)(color.Y * 255),
                (int)(color.Z * 255)
            );

            if (n == 2)
            {
                DrawLineZ(face.Vertices[0], face.Vertices[1], col);
            }
            else if (n > 2)
            {
                for (int i = 1; i < n - 1; i++)
                {
                    DrawTriangleZ(face.Vertices[0], face.Vertices[i], face.Vertices[i + 1], col);
                }
            }
        }

        private void DrawFaceZ(Face face, Color color)
        {
            int n = face.Vertices.Count;
            if (n == 2)
            {
                DrawLineZ(face.Vertices[0], face.Vertices[1], color);
            }
            else if (n > 2)
            {
                for (int i = 1; i < n - 1; i++)
                {
                    DrawTriangleZ(face.Vertices[0], face.Vertices[i], face.Vertices[i + 1], color);
                }
            }
        }
        private void DrawLineZ(Point3D v0, Point3D v1, Color color)
        {
            var p0 = camera.ProjectPoint2D(v0);
            var p1 = camera.ProjectPoint2D(v1);

            if (!p0.HasValue || !p1.HasValue) return;

            PointF a = p0.Value;
            PointF b = p1.Value;

            int x0 = (int)a.X, y0 = (int)a.Y;
            int x1 = (int)b.X, y1 = (int)b.Y;

            // простая линия Брезенхема с z-буфером
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                if (x0 >= 0 && x0 < width && y0 >= 0 && y0 < height)
                {
                    float t = dx != 0 ? (float)(x0 - a.X) / (b.X - a.X) : (float)(y0 - a.Y) / (b.Y - a.Y);
                    float z = v0.Z * (1 - t) + v1.Z * t;
                    if (z < zBuffer[x0, y0])
                    {
                        zBuffer[x0, y0] = z;
                        myImage.SetPixel(x0, y0, color);
                    }
                }

                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }
        }

        private void DrawTriangleZ(Point3D v0, Point3D v1, Point3D v2, Color color)
        {
            var p0 = camera.ProjectPoint2D(v0);
            var p1 = camera.ProjectPoint2D(v1);
            var p2 = camera.ProjectPoint2D(v2);

            if (!p0.HasValue || !p1.HasValue || !p2.HasValue)
                return;

            PointF a = p0.Value;
            PointF b = p1.Value;
            PointF c = p2.Value;

            int minX = (int)Math.Max(0, Math.Min(a.X, Math.Min(b.X, c.X)));
            int maxX = (int)Math.Min(width - 1, Math.Max(a.X, Math.Max(b.X, c.X)));
            int minY = (int)Math.Max(0, Math.Min(a.Y, Math.Min(b.Y, c.Y)));
            int maxY = (int)Math.Min(height - 1, Math.Max(a.Y, Math.Max(b.Y, c.Y)));

            var p0_3 = camera.ProjectPoint(v0);
            var p1_3 = camera.ProjectPoint(v1);
            var p2_3 = camera.ProjectPoint(v2);

            float area = EdgeFunction(a, b, c);
            if (Math.Abs(area) < 1e-6f) return;

            // Рендерим треугольник
            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    var p = new PointF(x + 0.5f, y + 0.5f);

                    float w0 = EdgeFunction(b, c, p);
                    float w1 = EdgeFunction(c, a, p);
                    float w2 = EdgeFunction(a, b, p);

                    if (w0 * area >= 0 && w1 * area >= 0 && w2 * area >= 0)
                    {
                        w0 /= area;
                        w1 /= area;
                        w2 /= area;

                        float z = w0 * p0_3.Z + w1 * p1_3.Z + w2 * p2_3.Z;

                        if (z < zBuffer[x, y])
                        {
                            zBuffer[x, y] = z;
                            myImage.SetPixel(x, y, color);
                        }
                    }
                }
            }
        }

            
        private static float EdgeFunction(PointF a, PointF b, PointF c)
        {
            return (c.X - a.X) * (b.Y - a.Y) - (c.Y - a.Y) * (b.X - a.X);
        }

        public Bitmap GetImage() => myImage.Img;
    }
}
