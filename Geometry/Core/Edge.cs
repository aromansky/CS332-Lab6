using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS332_Lab6.Geometry.classes
{
    internal class Edge: ICloneable
    {
        public Point3D Start { get; private set; }
        public Point3D End { get; private set; }

        public Edge(Point3D start, Point3D end)
        {
            this.Start = start;
            this.End = end;
        }

        public Edge(Edge other)
        {
            this.Start = (Point3D)other.Start.Clone();
            this.End = (Point3D)other.End.Clone();
        }

        public object Clone() => new Edge(this);
        
    }
}
