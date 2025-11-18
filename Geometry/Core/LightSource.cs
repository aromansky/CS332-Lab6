using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class LightSource: Point3D, ICloneable
    {
        public Vector3 Color { get; set; } = new Vector3(0, 0, 0);
        public LightSource(float x, float y, float z, Color color) : base(x, y, z)
        {
            this.Color = new Vector3(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f);
        }

        public LightSource(LightSource other) : base(other)
        {
            this.Color = other.Color;
        }

        public override object Clone() => new LightSource(this);
    }
}
