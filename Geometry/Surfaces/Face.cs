namespace Geometry
{
    public class Face: ICloneable
    {

        private List<Vertex> vertices;

        /// <summary>
        /// Набор несвязанных вершин грани.
        /// </summary>
        public List<Vertex> Vertices => vertices.Select(v => (Vertex)v.Clone()).ToList();
        public Vector3 NormalVector { get; private set; }

       
        public Face(List<Point3D> points)
        {
            this.vertices = new List<Vertex>();

            points = points.Distinct().ToList();

            for (int i = 0; i < points.Count; i++) 
                this.vertices.Add(new Vertex(points[i]));

            if (this.vertices.Count >= 3)
            {
                Vector3 v1 = new Vector3(vertices[0], vertices[1]);
                Vector3 v2 = new Vector3(vertices[0], vertices[2]);
                this.NormalVector = Vector3.Cross(v1, v2).Normalized();
            }
            else
                this.NormalVector = new Vector3(0, 0, 0);

            foreach (Vertex v in vertices)
                v.Normal = this.NormalVector;
        }

        public Face(params Point3D[] points)
        {
            this.vertices = new List<Vertex>();

            points = points.Distinct().ToArray();

            for (int i = 0; i < points.Length; i++)
                this.vertices.Add(new Vertex(points[i]));


            if (this.vertices.Count >= 3)
            {
                Vector3 v1 = new Vector3(vertices[0], vertices[1]);
                Vector3 v2 = new Vector3(vertices[0], vertices[2]);
                this.NormalVector = Vector3.Cross(v1, v2).Normalized();
            }
            else
                this.NormalVector = new Vector3(0, 0, 0);

            foreach (Vertex v in vertices)
                v.Normal = this.NormalVector;
        }

        public Face(List<Point3D> points, Vector3 NormalVector)
        {
            this.vertices = new List<Vertex>();

            points = points.Distinct().ToList();

            for (int i = 0; i < points.Count; i++) 
                this.vertices.Add(new Vertex(points[i]));

            this.NormalVector = NormalVector;

            foreach (Vertex v in vertices)
                v.Normal = this.NormalVector;
        }

        public Face(Face other)
        {
            this.NormalVector = other.NormalVector;
            this.vertices = other.Vertices.Select(e => (Vertex)e.Clone()).ToList();
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
