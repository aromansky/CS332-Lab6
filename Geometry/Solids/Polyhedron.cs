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

        public object Clone() => new Polyhedron(this);

        // Тетраэдр
        public static Polyhedron CreateTetrahedron(float size = 1.0f)
        {
            var vertices = new List<Point>
            {
                new Point(size, size, size),
                new Point(-size, -size, size),
                new Point(-size, size, -size),
                new Point(size, -size, -size)
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
            var vertices = new List<Point>
            {
                new Point(-halfSize, -halfSize, -halfSize), // 0
                new Point(halfSize, -halfSize, -halfSize),  // 1
                new Point(halfSize, halfSize, -halfSize),   // 2
                new Point(-halfSize, halfSize, -halfSize),  // 3
                new Point(-halfSize, -halfSize, halfSize),  // 4
                new Point(halfSize, -halfSize, halfSize),   // 5
                new Point(halfSize, halfSize, halfSize),    // 6
                new Point(-halfSize, halfSize, halfSize)    // 7
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
            var vertices = new List<Point>
            {
                new Point(size, 0, 0),   // 0
                new Point(-size, 0, 0),  // 1
                new Point(0, size, 0),   // 2
                new Point(0, -size, 0),  // 3
                new Point(0, 0, size),   // 4
                new Point(0, 0, -size)   // 5
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

            var vertices = new List<Point>();

            // 12 вершин икосаэдра
            var coords = new[]
            {
                (0.0f, 1.0f, phi), (0.0f, -1.0f, phi), (0.0f, 1.0f, -phi), (0.0f, -1.0f, -phi),
                (1.0f, phi, 0.0f), (-1.0f, phi, 0.0f), (1.0f, -phi, 0.0f), (-1.0f, -phi, 0.0f),
                (phi, 0.0f, 1.0f), (phi, 0.0f, -1.0f), (-phi, 0.0f, 1.0f), (-phi, 0.0f, -1.0f)
            };

            foreach (var (x, y, z) in coords)
            {
                vertices.Add(new Point(x * scale, y * scale, z * scale));
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
            float phi = (1.0f + (float)Math.Sqrt(5)) / 2.0f; // золотое сечение
            float scale = size / (float)Math.Sqrt(3);

            // 20 вершин додекаэдра
            var vertices = new List<Point>();

            var coords = new[]
            {
                (1.0f, 1.0f, 1.0f), (1.0f, 1.0f, -1.0f), (1.0f, -1.0f, 1.0f), (1.0f, -1.0f, -1.0f),
                (-1.0f, 1.0f, 1.0f), (-1.0f, 1.0f, -1.0f), (-1.0f, -1.0f, 1.0f), (-1.0f, -1.0f, -1.0f),
                (0.0f, 1.0f/phi, phi), (0.0f, 1.0f/phi, -phi), (0.0f, -1.0f/phi, phi), (0.0f, -1.0f/phi, -phi),
                (1.0f/phi, phi, 0.0f), (1.0f/phi, -phi, 0.0f), (-1.0f/phi, phi, 0.0f), (-1.0f/phi, -phi, 0.0f),
                (phi, 0.0f, 1.0f/phi), (phi, 0.0f, -1.0f/phi), (-phi, 0.0f, 1.0f/phi), (-phi, 0.0f, -1.0f/phi)
            };

            foreach (var (x, y, z) in coords)
            {
                vertices.Add(new Point(x * scale, y * scale, z * scale));
            }

            var faces = new List<Face>
            {
                // 12 пятиугольных граней
                CreateFace(vertices[0], vertices[8], vertices[4], vertices[14], vertices[12]),
                CreateFace(vertices[0], vertices[12], vertices[1], vertices[17], vertices[16]),
                CreateFace(vertices[0], vertices[16], vertices[2], vertices[10], vertices[8]),

                CreateFace(vertices[3], vertices[11], vertices[6], vertices[10], vertices[2]),
                CreateFace(vertices[3], vertices[2], vertices[16], vertices[17], vertices[13]),
                CreateFace(vertices[3], vertices[13], vertices[7], vertices[15], vertices[11]),

                CreateFace(vertices[5], vertices[9], vertices[11], vertices[15], vertices[19]),
                CreateFace(vertices[5], vertices[19], vertices[18], vertices[6], vertices[11]),
                CreateFace(vertices[5], vertices[1], vertices[12], vertices[14], vertices[9]),

                CreateFace(vertices[7], vertices[13], vertices[17], vertices[1], vertices[5]),
                CreateFace(vertices[7], vertices[5], vertices[19], vertices[18], vertices[15]),
                CreateFace(vertices[7], vertices[15], vertices[6], vertices[18], vertices[19])
            };

            return new Polyhedron(faces);
        }

        // Вспомогательные методы для создания граней
        private static Face CreateFace(params Point[] points)
        {
            var edges = new List<Edge>();
            for (int i = 0; i < points.Length; i++)
            {
                edges.Add(new Edge(points[i], points[(i + 1) % points.Length]));
            }
            return new Face(edges);
        }
    }
}