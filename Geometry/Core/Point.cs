using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS332_Lab6.Geometry
{
    internal class Point: ICloneable
    {

        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }

        public Point(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point(Point other)
        {
            (this.X, this.Y, this.Z) = other.GetCoords();
        }

        public (float x, float y, float z) GetCoords()
        {
            return (X, Y, Z);
        }

        public object Clone() => new Point(this);
    }
}
