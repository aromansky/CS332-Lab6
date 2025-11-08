namespace Geometry
{
    public class Face: ICloneable
    {
        private List<Edge> edges;
        public List<Edge> Edges { get { return edges.Select(e => (Edge)e.Clone()).ToList(); } }

        /// <summary>
        /// Набор несвязанных вершин грани.
        /// </summary>
        internal List<Point3D> Vertices =>
            edges.SelectMany(e => new[] { e.Start, e.End }) 
                 .GroupBy(p => (p.X, p.Y, p.Z))
                 .Select(g => (Point3D)g.First().Clone())
                 .ToList();

        public Face(List<Edge> edges)
        {
            this.edges = edges.Select(e => (Edge)e.Clone()).ToList();
        }

        public Face(List<Point3D> points)
        {
            this.edges = new List<Edge>();

            for (int i = 0; i < points.Count - 1; i++)
                this.edges.Add(new Edge(points[i], points[i + 1]));

            this.edges.Add(new Edge(points[points.Count - 1], points[0]));
        }

        public Face(Face other)
        {
            this.edges = other.Edges.Select(e => (Edge)e.Clone()).ToList();
        }

        public Point3D GetCenter()
        {
            var allVertices = this.Vertices;
            float centerX = allVertices.Average(v => v.X);
            float centerY = allVertices.Average(v => v.Y);
            float centerZ = allVertices.Average(v => v.Z);
            return new Point3D(centerX, centerY, centerZ);
        }

        public object Clone() => new Face(this);
    }
}
