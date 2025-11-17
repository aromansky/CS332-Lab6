using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Vertex: Point3D, ICloneable
    {
        public Vector3 Normal { get; set; } = new Vector3(0, 0, 0);
        public Vector3 Color { get; set; } = new Vector3(255, 255, 255);

        public Vertex(float x, float y, float z, Vector3 Color, Vector3 Normal) : base(x, y, z)
        {
            this.Color = Color;
            this.Normal = Normal;
        }

        public Vertex(Point3D point): base(point) { }

        public Vertex(float x, float y, float z, Vector3 Normal) : base(x, y, z)
        {
            this.Normal = Normal;
        }

        public Vertex(Vertex other) : base(other)
        {
            this.Color = other.Color;
            this.Normal = other.Normal;
        }
        public override object Clone() => new Vertex(this);
    }
}
