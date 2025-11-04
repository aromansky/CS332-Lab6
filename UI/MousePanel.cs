using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MousePanel : UserControl
    {

        private Point _prevMousePos;
        private bool _isDragging = false;

        public int deltaX;
        public int deltaY;
        public MousePanel()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panel, new object[] { true });

            panel.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(panel, true, null);
        }

        public void UpdatePanel()
        {
            panel.Invalidate();
        }

        private void PanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _prevMousePos = e.Location;
                _isDragging = true;
                panel.Cursor = Cursors.SizeAll;
            }
        }

        private new void PanelMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
                panel.Cursor = Cursors.Default;
            }
        }

        internal new void PanelMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                deltaX = e.X - _prevMousePos.X;
                deltaY = e.Y - _prevMousePos.Y;


                UpdatePanel();

                _prevMousePos = e.Location;
            }
        }

        private void MousePanelSizeChanged(object sender, EventArgs e)
        {
            panel.Size = this.Size;
        }

        private void MousePanel_Resize(object sender, EventArgs e)
        {
            panel.Invalidate();
        }

        public void UpdatePaintFunction(PaintEventHandler paintFunction)
        {
            panel.Paint -= paintFunction;
            panel.Paint += paintFunction;
        }
    }
}
