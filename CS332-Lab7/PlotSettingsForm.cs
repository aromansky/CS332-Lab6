using Geometry;
using NCalc;

namespace CS332_Lab7
{
    public partial class PlotSettingsForm : Form
    {
        private float x0, x1, y0, y1;
        private float xSteps, ySteps;

        public Polyhedron poly;

        public PlotSettingsForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            x0 = (float)numericUpDown1.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            y0 = -(float)numericUpDown3.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            x1 = (float)numericUpDown2.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            y1 = -(float)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            xSteps = (float)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            ySteps = (float)numericUpDown6.Value;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            Expression expr = new Expression(userInput);

            float dx = (x1 - x0) / xSteps;
            float dy = (y1 - y0) / ySteps;

            List<List<Point3D>> mesh = new List<List<Point3D>>();

            for (int i = 0; i < xSteps; i++)
            {
                List<Point3D> row = new List<Point3D>();
                for (int j = 0; j < ySteps; j++)
                {
                    float x = x0 + i * dx;
                    float y = y0 + j * dy;
                    expr.Parameters["x"] = x;
                    expr.Parameters["y"] = y;
                    object result = expr.Evaluate();
                    float z = (float)Convert.ToDouble(expr.Evaluate());
                    row.Add(new Point3D(x, y, z));
                }
                mesh.Add(row);
            }

            List<Face> faces = new List<Face>();
            for (int i = 0; i < xSteps - 1; i++)
            {
                for (int j = 0; j < ySteps - 1; j++)
                {
                    Point3D p1 = mesh[i][j];
                    Point3D p2 = mesh[i + 1][j];
                    Point3D p3 = mesh[i + 1][j + 1];
                    Point3D p4 = mesh[i][j + 1];
                    faces.Add(new Face(new List<Point3D> { p1, p2, p3, p4 }));
                }
            }
            this.poly = new Polyhedron(faces);

            this.DialogResult = DialogResult.OK;
        }
    }
}
