using CS332_Lab6.Geometry.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CS332_Lab6.Geometry
{
    internal class Face: ICloneable
    {
        private List<Edge> edges;
        public List<Edge> Edges { get { return edges.Select(e => (Edge)e.Clone()).ToList(); } }

        /// <summary>
        /// Набор несвязанных вершин грани.
        /// </summary>
        public List<Point3D> Vertices =>
            edges.SelectMany(e => new[] { e.Start, e.End }) 
                 .GroupBy(p => (p.X, p.Y, p.Z))
                 .Select(g => (Point3D)g.First().Clone())
                 .ToList();

        public Face(List<Edge> edges)
        {
            this.edges = edges.Select(e => (Edge)e.Clone()).ToList();
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
