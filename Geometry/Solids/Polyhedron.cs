using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CS332_Lab6.Geometry
{
    internal class Polyhedron: ICloneable
    {
        private List<Face> faces;
        public List<Face> Faces { get { return faces.Select(f => (Face)f.Clone()).ToList(); } }
        public Polyhedron(List<Face> faces)
        {
            this.faces = faces.Select(f => (Face)f.Clone()).ToList();
        } 

        public Polyhedron(Polyhedron other)
        {
            this.faces = other.Faces.Select(f => (Face)f.Clone()).ToList();
        }

        public object Clone() => new Polyhedron(this);
    }
}
