namespace CS332_Lab7
{
    partial class RotationFigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            createButton = new Button();
            clearButton = new Button();
            xAxisRadioButton = new RadioButton();
            yAxisRadioButton = new RadioButton();
            zAxisRadioButton = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = SystemColors.ActiveBorder;
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(635, 426);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            panel.MouseClick += panel_MouseClick;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createButton.Location = new Point(653, 181);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 1;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Location = new Point(653, 12);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // xAxisRadioButton
            // 
            xAxisRadioButton.AutoSize = true;
            xAxisRadioButton.Location = new Point(653, 41);
            xAxisRadioButton.Name = "xAxisRadioButton";
            xAxisRadioButton.Size = new Size(56, 19);
            xAxisRadioButton.TabIndex = 3;
            xAxisRadioButton.Text = "Ось X";
            xAxisRadioButton.UseVisualStyleBackColor = true;
            xAxisRadioButton.CheckedChanged += xAxisRadioButton_CheckedChanged;
            // 
            // yAxisRadioButton
            // 
            yAxisRadioButton.AutoSize = true;
            yAxisRadioButton.Checked = true;
            yAxisRadioButton.Location = new Point(653, 66);
            yAxisRadioButton.Name = "yAxisRadioButton";
            yAxisRadioButton.Size = new Size(56, 19);
            yAxisRadioButton.TabIndex = 4;
            yAxisRadioButton.TabStop = true;
            yAxisRadioButton.Text = "Ось Y";
            yAxisRadioButton.UseVisualStyleBackColor = true;
            yAxisRadioButton.CheckedChanged += yAxisRadioButton_CheckedChanged;
            // 
            // zAxisRadioButton
            // 
            zAxisRadioButton.AutoSize = true;
            zAxisRadioButton.Location = new Point(653, 91);
            zAxisRadioButton.Name = "zAxisRadioButton";
            zAxisRadioButton.Size = new Size(56, 19);
            zAxisRadioButton.TabIndex = 5;
            zAxisRadioButton.Text = "Ось Z";
            zAxisRadioButton.UseVisualStyleBackColor = true;
            zAxisRadioButton.CheckedChanged += zAxisRadioButton_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(653, 138);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 120);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 7;
            label1.Text = "Кол-во разбиений";
            // 
            // RotationFigureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(zAxisRadioButton);
            Controls.Add(yAxisRadioButton);
            Controls.Add(xAxisRadioButton);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Controls.Add(panel);
            Name = "RotationFigureForm";
            Text = "Создание образующей";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button createButton;
        private Button clearButton;
        private RadioButton xAxisRadioButton;
        private RadioButton yAxisRadioButton;
        private RadioButton zAxisRadioButton;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}