using Geometry;
using System.Drawing;

namespace CS332_Lab7
{
    public partial class RotationFigureForm : Form
    {
        public int numParts = 0;
        public enum Axis { X, Y, Z }
        public Axis rotationAxis = Axis.Y;
        private List<PointF> profilePoints;
        public Polyhedron poly;
        public RotationFigureForm()
        {
            InitializeComponent();
            profilePoints = new List<PointF>();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (profilePoints == null || profilePoints.Count < 2 || numParts < 3)
            {
                MessageBox.Show("Неверные исходные данные для генерации полиэдра.");
                return;
            }

            List<List<Point3D>> rings = new List<List<Point3D>>();
            float angleStep = 360f / numParts;

            for (int i = 0; i < numParts; i++)
            {
                float radians = i * angleStep * (float)(Math.PI / 180);
                Matrix rotationMatrix = Transform.CreateRotationAroundYMatrix(radians);

                List<Point3D> currentRing = new List<Point3D>();
                foreach (PointF point in profilePoints)
                {
                    Point3D originalPoint = new Point3D(point.X - 0.5f, point.Y, 0);
                    Point3D rotatedPoint = Transform.Apply(rotationMatrix, originalPoint);
                    currentRing.Add(rotatedPoint);
                }
                rings.Add(currentRing);
            }

            List<Face> faces = new List<Face>();
            for (int i = 0; i < numParts; i++)
            {
                int nextIndex = (i + 1) % numParts;
                for (int j = 0; j < profilePoints.Count - 1; j++)
                {
                    Point3D p1 = rings[i][j];
                    Point3D p2 = rings[nextIndex][j];
                    Point3D p3 = rings[nextIndex][j + 1];
                    Point3D p4 = rings[i][j + 1];

                    faces.Add(new Face(new List<Edge>
            {
                new Edge(p1, p2),
                new Edge(p2, p3),
                new Edge(p3, p4),
                new Edge(p4, p1)
            }));
                }
            }

            this.poly = new Polyhedron(faces);

            Point3D center = poly.GetCenter();
            Matrix translateMatrix = Transform.CreateTranslationMatrix(-center.X, -center.Y, -center.Z);
            this.poly = Transform.Apply(translateMatrix, poly);

            Matrix rotationMatrixFinal;
            switch (rotationAxis)
            {
                case Axis.X:
                    rotationMatrixFinal = Transform.CreateRotationAroundXMatrix((float)Math.PI / 2);
                    break;
                case Axis.Y:
                    rotationMatrixFinal = Matrix.Identity(); 
                    break;
                default: // Z
                    rotationMatrixFinal = Transform.CreateRotationAroundZMatrix((float)Math.PI / 2);
                    break;
            }
            this.poly = Transform.Apply(rotationMatrixFinal, this.poly);

            this.DialogResult = DialogResult.OK;
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            xAxisRadioButton.Checked = true;
            numericUpDown1.Value = 0;
            profilePoints.Clear();

            panel.Invalidate();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(SystemColors.ActiveBorder);

            using (Pen p = new Pen(Color.Red, 4))
            {
                int axisX = panel.Width / 2;
                g.DrawLine(p, axisX, 0, axisX, panel.Height);
            }

            using (Pen p = new Pen(Color.Blue, 2))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                foreach (PointF point in profilePoints)
                {
                    g.FillEllipse(Brushes.Red, point.X * panel.Width - 3, point.Y * panel.Height - 3, 6, 6);
                }

                if (profilePoints.Count > 1)
                {
                    g.DrawLines(p, profilePoints.Select(x => new PointF(x.X * panel.Width, x.Y * panel.Height)).ToArray());
                }
            }
        }

        private void xAxisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (xAxisRadioButton.Checked) rotationAxis = Axis.X;
        }

        private void yAxisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yAxisRadioButton.Checked) rotationAxis = Axis.Y;
        }

        private void zAxisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (zAxisRadioButton.Checked) rotationAxis = Axis.Z;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numParts = (int)numericUpDown1.Value;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.X - panel.Width / 2) < 3)
                profilePoints.Add(new PointF(0.5f, e.Y * 1f / panel.Height));
            else
                profilePoints.Add(new PointF(e.X * 1f / panel.Width, e.Y * 1f / panel.Height));
            panel.Invalidate();
        }
    }
}
