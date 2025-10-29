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
    internal class Polyhedron : ICloneable
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


        public Point3D GetCenter()
        {
            var allCenters = Faces.Select(x => x.GetCenter()).ToList();
            float centerX = allCenters.Average(v => v.X);
            float centerY = allCenters.Average(v => v.Y);
            float centerZ = allCenters.Average(v => v.Z);
            return new Point3D(centerX, centerY, centerZ);
        }

        public object Clone() => new Polyhedron(this);

        // Тетраэдр
        public static Polyhedron CreateTetrahedron(float size = 1.0f)
        {
            var vertices = new List<Point3D>
            {
                new Point3D(size, size, size),
                new Point3D(-size, -size, size),
                new Point3D(-size, size, -size),
                new Point3D(size, -size, -size)
            };

            var faces = new List<Face>
            {
                CreateFace(vertices[0], vertices[1], vertices[2]),
                CreateFace(vertices[0], vertices[2], vertices[3]),
                CreateFace(vertices[0], vertices[3], vertices[1]),
                CreateFace(vertices[1], vertices[3], vertices[2])
            };

            return new Polyhedron(faces);
        }

        // Гексаэдр (куб)
        public static Polyhedron CreateHexahedron(float size = 1.0f)
        {
            var halfSize = size / 2;
            var vertices = new List<Point3D>
            {
                new Point3D(-halfSize, -halfSize, -halfSize), // 0
                new Point3D(halfSize, -halfSize, -halfSize),  // 1
                new Point3D(halfSize, halfSize, -halfSize),   // 2
                new Point3D(-halfSize, halfSize, -halfSize),  // 3
                new Point3D(-halfSize, -halfSize, halfSize),  // 4
                new Point3D(halfSize, -halfSize, halfSize),   // 5
                new Point3D(halfSize, halfSize, halfSize),    // 6
                new Point3D(-halfSize, halfSize, halfSize)    // 7
            };

            var faces = new List<Face>
            {
                CreateFace(vertices[0], vertices[1], vertices[2], vertices[3]), // задняя
                CreateFace(vertices[4], vertices[5], vertices[6], vertices[7]), // передняя
                CreateFace(vertices[0], vertices[1], vertices[5], vertices[4]), // нижняя
                CreateFace(vertices[2], vertices[3], vertices[7], vertices[6]), // верхняя
                CreateFace(vertices[0], vertices[3], vertices[7], vertices[4]), // левая
                CreateFace(vertices[1], vertices[2], vertices[6], vertices[5])  // правая
            };

            return new Polyhedron(faces);
        }

        // Октаэдр
        public static Polyhedron CreateOctahedron(float size = 1.0f)
        {
            var vertices = new List<Point3D>
            {
                new Point3D(size, 0, 0),   // 0
                new Point3D(-size, 0, 0),  // 1
                new Point3D(0, size, 0),   // 2
                new Point3D(0, -size, 0),  // 3
                new Point3D(0, 0, size),   // 4
                new Point3D(0, 0, -size)   // 5
            };

            var faces = new List<Face>
            {
                CreateFace(vertices[4], vertices[0], vertices[2]), // верхние треугольники
                CreateFace(vertices[4], vertices[2], vertices[1]),
                CreateFace(vertices[4], vertices[1], vertices[3]),
                CreateFace(vertices[4], vertices[3], vertices[0]),
                CreateFace(vertices[5], vertices[2], vertices[0]), // нижние треугольники
                CreateFace(vertices[5], vertices[1], vertices[2]),
                CreateFace(vertices[5], vertices[3], vertices[1]),
                CreateFace(vertices[5], vertices[0], vertices[3])
            };

            return new Polyhedron(faces);
        }

        // Икосаэдр
        public static Polyhedron CreateIcosahedron(float size = 1.0f)
        {
            float phi = (1.0f + (float)Math.Sqrt(5)) / 2.0f; // золотое сечение
            float scale = size / (float)Math.Sqrt(1 + phi * phi);

            var vertices = new List<Point3D>();

            // 12 вершин икосаэдра
            var coords = new[]
            {
                (0.0f, 1.0f, phi), (0.0f, -1.0f, phi), (0.0f, 1.0f, -phi), (0.0f, -1.0f, -phi),
                (1.0f, phi, 0.0f), (-1.0f, phi, 0.0f), (1.0f, -phi, 0.0f), (-1.0f, -phi, 0.0f),
                (phi, 0.0f, 1.0f), (phi, 0.0f, -1.0f), (-phi, 0.0f, 1.0f), (-phi, 0.0f, -1.0f)
            };

            foreach (var (x, y, z) in coords)
            {
                vertices.Add(new Point3D(x * scale, y * scale, z * scale));
            }

            var faces = new List<Face>
            {
                // 20 треугольных граней
                CreateFace(vertices[0], vertices[1], vertices[8]),
                CreateFace(vertices[0], vertices[8], vertices[4]),
                CreateFace(vertices[0], vertices[4], vertices[5]),
                CreateFace(vertices[0], vertices[5], vertices[10]),
                CreateFace(vertices[0], vertices[10], vertices[1]),

                CreateFace(vertices[1], vertices[6], vertices[8]),
                CreateFace(vertices[8], vertices[6], vertices[9]),
                CreateFace(vertices[8], vertices[9], vertices[4]),
                CreateFace(vertices[4], vertices[9], vertices[2]),
                CreateFace(vertices[4], vertices[2], vertices[5]),

                CreateFace(vertices[5], vertices[2], vertices[11]),
                CreateFace(vertices[5], vertices[11], vertices[10]),
                CreateFace(vertices[10], vertices[11], vertices[7]),
                CreateFace(vertices[10], vertices[7], vertices[1]),
                CreateFace(vertices[1], vertices[7], vertices[6]),

                CreateFace(vertices[3], vertices[6], vertices[7]),
                CreateFace(vertices[3], vertices[7], vertices[11]),
                CreateFace(vertices[3], vertices[11], vertices[2]),
                CreateFace(vertices[3], vertices[2], vertices[9]),
                CreateFace(vertices[3], vertices[9], vertices[6])
            };

            return new Polyhedron(faces);
        }

        // Додекаэдр
        public static Polyhedron CreateDodecahedron(float size = 1.0f)
        {
            // Золотое сечение
            float phi = (1.0f + (float)Math.Sqrt(5.0)) / 2.0f;
            float invPhi = 1.0f / phi;

            var vertices = new List<Point3D>
            {
                //(±1, ±1, ±1)
                new Point3D( 1,  1,  1),  // 0
                new Point3D( 1,  1, -1),  // 1
                new Point3D( 1, -1,  1),  // 2
                new Point3D( 1, -1, -1),  // 3
                new Point3D(-1,  1,  1),  // 4
                new Point3D(-1,  1, -1),  // 5
                new Point3D(-1, -1,  1),  // 6
                new Point3D(-1, -1, -1),  // 7

                // (0, ±φ, ±1/φ)
                new Point3D(0,  phi,  invPhi),  // 8
                new Point3D(0,  phi, -invPhi),  // 9
                new Point3D(0, -phi,  invPhi),  // 10
                new Point3D(0, -phi, -invPhi),  // 11

                //(±1/φ, 0, ±φ)
                new Point3D( invPhi, 0, phi),  // 12
                new Point3D(-invPhi, 0, phi),  // 13
                new Point3D( invPhi, 0, -phi),  // 14
                new Point3D(-invPhi, 0, -phi),  // 15

                // 🩷 (±φ, ±1/φ, 0)
                new Point3D( phi,  invPhi, 0),  // 16
                new Point3D(-phi,  invPhi, 0),  // 17
                new Point3D( phi, -invPhi, 0),  // 18
                new Point3D(-phi, -invPhi, 0)   // 19
            };

            vertices = vertices
                .Select(v =>
                {
                    float len = (float)Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
                    return new Point3D(v.X / len * size, v.Y / len * size, v.Z / len * size);
                })
                .ToList();

            // Грани (12 пятиугольников)
            var faces = new List<Face>
            {
                CreateFace(vertices[0], vertices[16], vertices[18], vertices[2], vertices[12]),
                CreateFace(vertices[0], vertices[16], vertices[1], vertices[9], vertices[8]),
                CreateFace(vertices[0], vertices[12], vertices[13], vertices[4], vertices[8]),

                CreateFace(vertices[10], vertices[2], vertices[12], vertices[13], vertices[6]),
                CreateFace(vertices[10], vertices[6], vertices[19], vertices[7], vertices[11]),
                CreateFace(vertices[10], vertices[2], vertices[18], vertices[3], vertices[11]),

                CreateFace(vertices[5], vertices[9], vertices[8], vertices[4], vertices[17]),
                CreateFace(vertices[5], vertices[9], vertices[1], vertices[14], vertices[15]),
                CreateFace(vertices[5], vertices[17], vertices[19], vertices[7], vertices[15]),

                CreateFace(vertices[3], vertices[14], vertices[1], vertices[16], vertices[18]),
                CreateFace(vertices[3], vertices[11], vertices[10], vertices[2], vertices[18]),
                CreateFace(vertices[4], vertices[13], vertices[6], vertices[19], vertices[17])
            };

            return new Polyhedron(faces);
        }





        // Вспомогательные методы для создания граней
        private static Face CreateFace(params Point3D[] Point3Ds)
        {
            var edges = new List<Edge>();
            for (int i = 0; i < Point3Ds.Length; i++)
            {
                edges.Add(new Edge(Point3Ds[i], Point3Ds[(i + 1) % Point3Ds.Length]));
            }
            return new Face(edges);
        }
    }
}