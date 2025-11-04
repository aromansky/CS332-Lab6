using System.Windows.Forms;

namespace UI
{
    partial class MousePanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ActiveBorder;
            panel.Location = new Point(3, 3);
            panel.Name = "panel";
            panel.Size = new Size(491, 332);
            panel.TabIndex = 0;
            panel.MouseDown += PanelMouseDown;
            panel.MouseMove += PanelMouseMove;
            panel.MouseUp += PanelMouseUp;
            // 
            // MousePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Name = "MousePanel";
            Size = new Size(497, 338);
            SizeChanged += MousePanelSizeChanged;
            Resize += MousePanel_Resize;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
    }
}
