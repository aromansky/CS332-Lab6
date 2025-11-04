using Geometry;
using System.Drawing.Drawing2D;

namespace UI
{
    public partial class TransformableRenderer : UserControl
    {
        private MousePanel mousePanel;
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

        public TransformableRenderer()
        {
            InitializeComponent();
        }

        public void SetMousePanel(MousePanel panel)
        {
            mousePanel = panel;

            mousePanel.UpdatePaintFunction(PanelPaint);
        }

        public void PanelPaint(object sender, PaintEventArgs e)
        {
            if (poly == null) return;

            Graphics g = e.Graphics;
            g.Clear(SystemColors.ActiveBorder);

        }

        public void UpdatePolyhedron(Polyhedron newPoly)
        {
            poly = newPoly;
            mousePanel.UpdatePanel();
        }

        private void UncheckOtherRadioButtons(RadioButton currentRadio)
        {
            RadioButton[] allRadioButtons = {
                scaleAroundCenter_radioButton, scaleAroundX_radioButton, scaleAroundY_radioButton, scaleAroundZ_radioButton,
                translateAboutX_radioButton, translateAboutY_radioButton, translateAroundZ_radioButton,
                rotateAroundX_radioButton, rotateAroundY_radioButton, rotateAroundZ_radioButton,
                rotateAroundLine_radioButton

            };

            foreach (RadioButton rb in allRadioButtons)
            {
                if (rb != currentRadio && rb.Checked)
                {
                    rb.Checked = false;
                }
            }
        }

        private void scaleAroundCenter_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void scaleAroundX_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void scaleAroundY_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void scaleAroundZ_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void translateAboutX_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void translateAboutY_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void translateAroundZ_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void rotateAroundX_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void rotateAroundY_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void rotateAroundZ_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;

            UncheckOtherRadioButtons(current);
        }

        private void rotateAroundLine_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;
            if (!current.Checked) return;
               
            UncheckOtherRadioButtons(current);
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

        private void lineVecNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            lineVector = new Vector3(
                (float)lineVecXNumericUpDown.Value,
                (float)lineVecYNumericUpDown.Value,
                (float)lineVecZNumericUpDown.Value);
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
    }
}
