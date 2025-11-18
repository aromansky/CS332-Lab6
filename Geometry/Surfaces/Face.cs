using System.Drawing;

namespace Geometry
{
    public class Face: ICloneable
    {

        private List<Vertex> vertices;

        /// <summary>
        /// Набор несвязанных вершин грани.
        /// </summary>
        public List<Vertex> Vertices => vertices.Select(v => (Vertex)v.Clone()).ToList();
        public Vector3 ObjectColor { get; private set; } = new Vector3(Color.White);
        public Vector3 NormalVector { get; private set; }
        

        public Face(List<Point3D> points, Vector3? normalVector = null, Color? col = null)
        {
            InitFace(points, normalVector, col);
        }

        public Face(params Point3D[] points)
        {
            InitFace(points.ToList(), null, null);
        }

        public Face(List<Point3D> points, Vector3 NormalVector)
        {
            InitFace(points, NormalVector, null);
        }


        private void InitFace(List<Point3D> points, Vector3? normalVector, Color? col)
        {
            this.vertices = new List<Vertex>();
            points = points.Distinct().ToList();

            foreach (var p in points)
                this.vertices.Add(new Vertex(p));

            if (normalVector.HasValue)
                this.NormalVector = normalVector.Value;
            else if (this.vertices.Count >= 3)
            {
                Vector3 v1 = new Vector3(vertices[0], vertices[1]);
                Vector3 v2 = new Vector3(vertices[0], vertices[2]);
                this.NormalVector = Vector3.Cross(v1, v2).Normalized();
            }
            else
                this.NormalVector = new Vector3(0, 0, 0);

            foreach (Vertex v in vertices)
                v.Normal = this.NormalVector;

            this.ObjectColor = new Vector3(col ?? Color.White);

            foreach (Vertex v in vertices)
                v.Color = this.ObjectColor;
        }


        public Face(Face other)
        {
            this.NormalVector = other.NormalVector;
            this.ObjectColor = other.ObjectColor;
            this.vertices = other.Vertices.Select(e => (Vertex)e.Clone()).ToList();
        }

        public void SetColor(Vector3 col)
        {
            this.ObjectColor = col;

            foreach (Vertex v in vertices)
                v.Color = this.ObjectColor;
        }

        public Point3D GetCenter()
        {
            float centerX = vertices.Average(v => v.X);
            float centerY = vertices.Average(v => v.Y);
            float centerZ = vertices.Average(v => v.Z);
            return new Point3D(centerX, centerY, centerZ);
        }

        public bool IsFrontFace(Camera camera)
        {
            if (vertices.Count < 3) return true;
            Vector3 viewVector;

            if (camera.Mode == ProjectionMode.Perspective)
            {
                viewVector = new Vector3(GetCenter(), camera.Position).Normalized();
            }
            else
            {
                viewVector = camera.ViewDirection.Normalized();
            }

            float dot = Vector3.Dot(NormalVector, viewVector);
            return dot > 0;
        }

        public object Clone() => new Face(this);
    }
}
