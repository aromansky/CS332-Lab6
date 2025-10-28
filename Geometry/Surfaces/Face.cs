using CS332_Lab6.Geometry.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CS332_Lab6.Geometry
{
    internal class Face: ICloneable
    {
        private List<Edge> edges;
        public List<Edge> Edges { get { return edges.Select(e => (Edge)e.Clone()).ToList(); } }
        public List<Point> Vertices =>
            edges.SelectMany(e => new[] { e.Start, e.End }) 
                 .GroupBy(p => (p.X, p.Y, p.Z))
                 .Select(g => (Point)g.First().Clone())
                 .ToList();

        public Face(List<Edge> edges)
        {
            this.edges = edges.Select(e => (Edge)e.Clone()).ToList();
        }

        public Face(Face other)
        {
            this.edges = other.Edges.Select(e => (Edge)e.Clone()).ToList();
        }

        public object Clone() => new Face(this);
    }
}
