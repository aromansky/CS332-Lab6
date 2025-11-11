namespace Geometry
{
    public class Face: ICloneable
    {
        private List<Edge> edges;
        private List<Point3D> vertices;
        /// <summary>
        /// Набор несвязанных вершин грани.
        /// </summary>
        public List<Point3D> Vertices => vertices.Select(v => (Point3D)v.Clone()).ToList();
        public List<Edge> Edges { get { return edges.Select(e => (Edge)e.Clone()).ToList(); } }
        public Vector3 NormalVector { get; private set; }

        

        public Face(List<Edge> edges)
        {
            this.edges = edges.Where(x => !x.Vector3.IsZero()).Select(e => (Edge)e.Clone()).ToList();

            this.vertices = this.edges
                .SelectMany(e => new[] { e.Start, e.End })
                .GroupBy(p => (p.X, p.Y, p.Z))
                .Select(g => (Point3D)g.First().Clone())
                .ToList();


            if (this.vertices.Count >= 3)
            {
                Vector3 v1 = new Vector3(vertices[0], vertices[1]);
                Vector3 v2 = new Vector3(vertices[0], vertices[2]);
                this.NormalVector = Vector3.Cross(v1, v2).Normalized();
            }
            else
                this.NormalVector = new Vector3(0, 0, 0);
        }
        public Face(List<Point3D> points)
        {
            this.edges = new List<Edge>();
            this.vertices = new List<Point3D>();

            points = points.Distinct().ToList();

            for (int i = 0; i < points.Count; i++)
            {
                this.edges.Add(new Edge(points[i], points[(i + 1) % points.Count]));
                this.vertices.Add(points[i]);
                
            }

            if (this.vertices.Count >= 3)
            {
                Vector3 v1 = new Vector3(vertices[0], vertices[1]);
                Vector3 v2 = new Vector3(vertices[0], vertices[2]);
                this.NormalVector = Vector3.Cross(v1, v2).Normalized();
            }
            else
                this.NormalVector = new Vector3(0, 0, 0);
        }

        public Face(params Point3D[] points)
        {
            this.edges = new List<Edge>();
            this.vertices = new List<Point3D>();

            points = points.Distinct().ToArray();

            for (int i = 0; i < points.Length; i++)
            {
                this.edges.Add(new Edge(points[i], points[(i + 1) % points.Length]));
                this.vertices.Add(points[i]);

            }


            if (this.vertices.Count >= 3)
            {
                Vector3 v1 = new Vector3(vertices[0], vertices[1]);
                Vector3 v2 = new Vector3(vertices[0], vertices[2]);
                this.NormalVector = Vector3.Cross(v1, v2).Normalized();
            }
            else
                this.NormalVector = new Vector3(0, 0, 0);
        }

        public Face(List<Point3D> points, Vector3 NormalVector)
        {
            this.edges = new List<Edge>();
            this.vertices = new List<Point3D>();

            points = points.Distinct().ToList();

            for (int i = 0; i < points.Count; i++)
            {
                this.edges.Add(new Edge(points[i], points[(i + 1) % points.Count]));
                this.vertices.Add(points[i]);

            }

            this.NormalVector = NormalVector;
        }

        public Face(Face other)
        {
            this.edges = other.Edges.Select(e => (Edge)e.Clone()).ToList();
            this.NormalVector = other.NormalVector;
            this.vertices = other.Vertices.Select(e => (Point3D)e.Clone()).ToList();
        }

        public Point3D GetCenter()
        {
            var allVertices = this.Vertices;
            float centerX = allVertices.Average(v => v.X);
            float centerY = allVertices.Average(v => v.Y);
            float centerZ = allVertices.Average(v => v.Z);
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
