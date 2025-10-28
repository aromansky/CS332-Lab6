using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS332_Lab6
{
    public partial class Scene : Form
    {
        public Scene()
        {
            InitializeComponent();
        }

        private Point _startMousePos;
        private bool _isDragging = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _startMousePos = e.Location;
                _isDragging = true;
                panel1.Cursor = Cursors.SizeAll;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - _startMousePos.X;
                int deltaY = e.Y - _startMousePos.Y;
                
                HandleMouseDrag(deltaX, deltaY);
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

        private void HandleMouseDrag(int deltaX, int deltaY)
        {
            panel1.Invalidate();
        }
    }
}
