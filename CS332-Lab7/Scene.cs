using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Geometry;

namespace CS332_Lab7
{
    public partial class Scene : Form
    {

        private Point _prevMousePos;
        private bool _isDragging = false;
        private Camera cam;
        private Polyhedron poly;

        private Point3D linePoint = new Point3D(0, 0, 0);
        private Vector3 lineVector;

        private bool scalingMode = false;
        private bool scalingXMode = false;
        private bool scalingYMode = false;
        private bool scalingZMode = false;


        private bool rotatingXMode = false;
        private bool rotatingYMode = false;
        private bool rotatingZMode = false;

        private bool translatingXMode = false;
        private bool translatingYMode = false;
        private bool translatingZMode = false;

        private bool rotatingCustomAxisMode = false;


        public Scene()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panel1, new object[] { true });

            panel1.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(panel1, true, null);


            cam = new Camera(
                new Point3D(0f, 0f, -5f),
                60f,
                panel1.Width,
                panel1.Height);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _prevMousePos = e.Location;
                _isDragging = true;
                panel1.Cursor = Cursors.SizeAll;
            }
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - _prevMousePos.X;

                if (poly != null)
                {
                    PolyhedronProcessing(deltaX);
                }


                HandleMouseDrag(deltaX);

                _prevMousePos = e.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
                panel1.Cursor = Cursors.Default;
            }
        }

        private void HandleMouseDrag(int deltaX)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cam.ScreenWidth = panel1.Width;
            cam.ScreenHeight = panel1.Height;
            cam.SetMode(cam.Mode);

            var g = e.Graphics;
            g.Clear(SystemColors.ActiveBorder);

            // === РИСОВАНИЕ ОСЕЙ КООРДИНАТ ===
            float axisLength = 5.0f;
            var origin = new Point3D(0, 0, 0);
            var xAxisEnd = new Point3D(axisLength, 0, 0);
            var yAxisEnd = new Point3D(0, axisLength, 0);
            var zAxisEnd = new Point3D(0, 0, axisLength);

            var axes = new List<List<PointF>>
            {
                cam.Project(new Polyhedron(new List<Face> { CreateAxis(origin, xAxisEnd) }))[0],
                cam.Project(new Polyhedron(new List<Face> { CreateAxis(origin, yAxisEnd) }))[0],
                cam.Project(new Polyhedron(new List<Face> { CreateAxis(origin, zAxisEnd) }))[0]
            };

            using (var penX = new Pen(Color.Red, 2f))
            using (var penY = new Pen(Color.Green, 2f))
            using (var penZ = new Pen(Color.Blue, 2f))
            {
                g.DrawLine(penX, axes[0][0], axes[0][1]);
                g.DrawLine(penY, axes[1][0], axes[1][1]);
                g.DrawLine(penZ, axes[2][0], axes[2][1]);
            }

            // === ОСЬ ВРАЩЕНИЯ (если выбрана пользовательская) ===
            if (rotatingCustomAxisMode && !lineVector.IsZero())
            {
                Vector3 dir = lineVector.Normalize();
                float len = 5.0f;

                Point3D start = new Point3D(
                    linePoint.X - dir.X * len,
                    linePoint.Y - dir.Y * len,
                    linePoint.Z - dir.Z * len);

                Point3D end = new Point3D(
                    linePoint.X + dir.X * len,
                    linePoint.Y + dir.Y * len,
                    linePoint.Z + dir.Z * len);

                var projectedAxis = cam.Project(new Polyhedron(new List<Face> { CreateAxis(start, end) }))[0];

                using (var penAxis = new Pen(Color.Gold, 2f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                {
                    g.DrawLine(penAxis, projectedAxis[0], projectedAxis[1]);
                }
            }

            if (poly == null) return;

            var projectedFaces = cam.Project(poly);

            using (var pen = new Pen(Color.Black, 1f))
            {
                foreach (var face in projectedFaces)
                {
                    for (int i = 0; i < face.Count; i++)
                    {
                        var a = face[i];
                        var b = face[(i + 1) % face.Count];
                        if (!float.IsNaN(a.X) && !float.IsNaN(b.X))
                        {
                            g.DrawLine(pen, a, b);
                            g.FillEllipse(Brushes.Red, a.X - 3, a.Y - 3, 6, 6);
                            g.FillEllipse(Brushes.Red, b.X - 3, b.Y - 3, 6, 6);
                        }
                    }
                }
            }
        }


        private static Face CreateAxis(Point3D start, Point3D end)
        {
            return new Face(new List<Edge> { new Edge(start, end) });
        }

        private void PerspectiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam.SetMode(ProjectionMode.Perspective);
            panel1.Invalidate();
        }

        private void TrimetricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam.SetMode(ProjectionMode.Trimetric);
            panel1.Invalidate();
        }

        private void DimetricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam.SetMode(ProjectionMode.Dimetric);
            panel1.Invalidate();
        }

        private void IsometricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam.SetMode(ProjectionMode.Isometric);
            panel1.Invalidate();
        }

        private void TetrahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poly = Polyhedron.CreateTetrahedron();
            panel1.Invalidate();
        }

        private void HexahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poly = Polyhedron.CreateHexahedron();
            panel1.Invalidate();
        }

        private void OctahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poly = Polyhedron.CreateOctahedron();
            panel1.Invalidate();
        }

        private void IcosahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poly = Polyhedron.CreateIcosahedron();
            panel1.Invalidate();
        }

        private void DodecahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poly = Polyhedron.CreateDodecahedron();
            panel1.Invalidate();
        }

        private void PolyhedronProcessing(int deltaX)
        {
            float scaleFactor = 1.0f + deltaX * 0.01f;
            if (!(scaleFactor > 0.1f && scaleFactor < 10.0f)) return;

            if (scalingMode)
                poly = Transform.Apply(Transform.CreateScaleMatrix(scaleFactor, scaleFactor, scaleFactor), poly);
            else if (scalingXMode)
                poly = Transform.Apply(Transform.CreateScaleMatrix(scaleFactor, 1, 1), poly);
            else if (scalingYMode)
                poly = Transform.Apply(Transform.CreateScaleMatrix(1, scaleFactor, 1), poly);
            else if (scalingZMode)
                poly = Transform.Apply(Transform.CreateScaleMatrix(1, 1, scaleFactor), poly);
            else if (rotatingXMode)
                poly = Transform.Apply(
                    Transform.CreateRotationAroundLineMatrix(
                        poly.GetCenter(),
                        new Vector3(1, 0, 0),
                        deltaX * 0.01f),
                    poly);
            else if (rotatingYMode)
                poly = Transform.Apply(
                    Transform.CreateRotationAroundLineMatrix(
                        poly.GetCenter(),
                        new Vector3(0, 1, 0),
                        deltaX * 0.01f),
                    poly);
            else if (rotatingZMode)
                poly = Transform.Apply(
                    Transform.CreateRotationAroundLineMatrix(
                        poly.GetCenter(),
                        new Vector3(0, 0, 1),
                        deltaX * 0.01f),
                    poly);
            else if (translatingXMode)
                poly = Transform.Apply(Transform.CreateTranslationMatrix(deltaX * 0.01f, 0, 0), poly);
            else if (translatingYMode)
                poly = Transform.Apply(Transform.CreateTranslationMatrix(0, deltaX * 0.01f, 0), poly);
            else if (translatingZMode)
                poly = Transform.Apply(Transform.CreateTranslationMatrix(0, 0, deltaX * 0.01f), poly);
            else if (rotatingCustomAxisMode)
                poly = Transform.Apply(
                    Transform.CreateRotationAroundLineMatrix(
                        linePoint,
                        lineVector,
                        deltaX * 0.01f),
                    poly);

        }

        private void ScaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scalingMode = ScaleRadioButton.Checked;
        }

        private void RotateAboutXRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rotatingXMode = RotateAboutXRadioButton.Checked;
        }

        private void RotateAboutYRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rotatingYMode = RotateAboutYRadioButton.Checked;
        }

        private void RotateAboutZRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rotatingZMode = RotateAboutZRadioButton.Checked;
        }

        private void TranslateAboutXRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            translatingXMode = TranslateAboutXRadioButton.Checked;
        }

        private void TranslateAboutYRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            translatingYMode = TranslateAboutYRadioButton.Checked;
        }

        private void TranslateAboutZRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            translatingZMode = TranslateAboutZRadioButton.Checked;
        }

        private void ScaleAboutXRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scalingXMode = ScaleAboutXRadioButton.Checked;
        }

        private void ScaleAboutYRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scalingYMode = ScaleAboutYRadioButton.Checked;
        }

        private void ScaleAboutZRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scalingZMode = ScaleAboutZRadioButton.Checked;
        }

        private void lineStartNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateLineFromPoints();
            panel1.Invalidate();
        }

        private void lineVecNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            lineVector = new Vector3(
                (float)lineVecXNumericUpDown.Value,
                (float)lineVecYNumericUpDown.Value,
                (float)lineVecZNumericUpDown.Value);

            panel1.Invalidate();
        }

        private void customRotatingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rotatingCustomAxisMode = customRotatingRadioButton.Checked;
            panel1.Invalidate();
        }

        private void UpdateLineFromPoints()
        {
            Point3D pointA = new Point3D(
                (float)lineStartXNumericUpDown.Value,
                (float)lineStartYNumericUpDown.Value,
                (float)lineStartZNumericUpDown.Value);

            Point3D pointB = new Point3D(
                (float)lineEndXNumericUpDown.Value,
                (float)lineEndYNumericUpDown.Value,
                (float)lineEndZNumericUpDown.Value);

            Vector3 direction = new Vector3(
                pointB.X - pointA.X,
                pointB.Y - pointA.Y,
                pointB.Z - pointA.Z);

            linePoint = pointA;
            lineVector = direction;
        }

        private void lineEndNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateLineFromPoints();
            panel1.Invalidate();
        }

        private void refclectXYbutton_Click(object sender, EventArgs e)
        {
            if (poly != null)
            {
                poly = Transform.Apply(Transform.CreateScaleMatrix(1, 1, -1), poly);
                panel1.Invalidate();
            }
        }

        private void refclectXZbutton_Click(object sender, EventArgs e)
        {
            if (poly != null)
            {
                poly = Transform.Apply(Transform.CreateScaleMatrix(1, -1, 1), poly);
                panel1.Invalidate();
            }
        }

        private void refclectYZbutton_Click(object sender, EventArgs e)
        {
            if (poly != null)
            {
                poly = Transform.Apply(Transform.CreateScaleMatrix(-1, 1, 1), poly);
                panel1.Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (poly is null) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Wavefront OBJ (*.obj)|*.obj|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "obj";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    poly.Save(saveFileDialog.FileName);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Wavefront OBJ (*.obj)|*.obj|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    poly = Polyhedron.Load(openFileDialog.FileName);
                    panel1.Invalidate();
                }
            }
        }

        private void rotationFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotationFigureForm form = new RotationFigureForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                poly = new Polyhedron(form.poly);
                form.Close();
                panel1.Invalidate();
            }

        }

        private void plotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotSettingsForm form = new PlotSettingsForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                poly = new Polyhedron(form.poly);
                form.Close();
                panel1.Invalidate();
            }
        }
    }
}
