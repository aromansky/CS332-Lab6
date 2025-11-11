using Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS332_Lab8
{
    public partial class SetPhigure : Form
    {
        private List<Polyhedron> lst;
        private Scene scene;
        public SetPhigure(List<Polyhedron> lst, Scene scene)
        {
            InitializeComponent();
            this.lst = lst;
            this.scene = scene;


            foreach (Polyhedron poly in lst)
            {
                listBox.Items.Add(poly.Name);
            }

            if (scene.polyInd > -1)
                listBox.SelectedIndex = scene.polyInd;
        }

        private void SetPhigure_Activated(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (Polyhedron poly in lst)
            {
                listBox.Items.Add(poly.Name);
            }

            if (scene.polyInd > -1)
                listBox.SelectedIndex = scene.polyInd;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scene.polyInd = listBox.SelectedIndex;
            scene.Refresh();
        }
    }
}
