namespace CS332_Lab6
{
    partial class Scene
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RotateAboutXRadioButton = new System.Windows.Forms.RadioButton();
            this.RotateAboutYRadioButton = new System.Windows.Forms.RadioButton();
            this.RotateAboutZRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customRotatingRadioButton = new System.Windows.Forms.RadioButton();
            this.lineStartXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lineStartYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lineStartZNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lineVecZNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lineVecYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lineVecXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фигурыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TetrahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HexahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OctahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IcosahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodecahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PerspectiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrimetricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DimetricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsometricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScaleRadioButton = new System.Windows.Forms.RadioButton();
            this.TranslateAboutZRadioButton = new System.Windows.Forms.RadioButton();
            this.TranslateAboutYRadioButton = new System.Windows.Forms.RadioButton();
            this.TranslateAboutXRadioButton = new System.Windows.Forms.RadioButton();
            this.ScaleAboutXRadioButton = new System.Windows.Forms.RadioButton();
            this.ScaleAboutYRadioButton = new System.Windows.Forms.RadioButton();
            this.ScaleAboutZRadioButton = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lineEndYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lineEndXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.lineEndZNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.refclectXYbutton = new System.Windows.Forms.Button();
            this.refclectXZbutton = new System.Windows.Forms.Button();
            this.refclectYZbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineStartXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineStartYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineStartZNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineVecZNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineVecYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineVecXNumericUpDown)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineEndYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineEndXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineEndZNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 874);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // RotateAboutXRadioButton
            // 
            this.RotateAboutXRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateAboutXRadioButton.AutoSize = true;
            this.RotateAboutXRadioButton.Location = new System.Drawing.Point(1571, 177);
            this.RotateAboutXRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RotateAboutXRadioButton.Name = "RotateAboutXRadioButton";
            this.RotateAboutXRadioButton.Size = new System.Drawing.Size(141, 20);
            this.RotateAboutXRadioButton.TabIndex = 7;
            this.RotateAboutXRadioButton.Text = "Поворот по оси X";
            this.RotateAboutXRadioButton.UseVisualStyleBackColor = true;
            this.RotateAboutXRadioButton.CheckedChanged += new System.EventHandler(this.RotateAboutXRadioButton_CheckedChanged);
            // 
            // RotateAboutYRadioButton
            // 
            this.RotateAboutYRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateAboutYRadioButton.AutoSize = true;
            this.RotateAboutYRadioButton.Location = new System.Drawing.Point(1570, 203);
            this.RotateAboutYRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RotateAboutYRadioButton.Name = "RotateAboutYRadioButton";
            this.RotateAboutYRadioButton.Size = new System.Drawing.Size(142, 20);
            this.RotateAboutYRadioButton.TabIndex = 8;
            this.RotateAboutYRadioButton.Text = "Поворот по оси Y";
            this.RotateAboutYRadioButton.UseVisualStyleBackColor = true;
            this.RotateAboutYRadioButton.CheckedChanged += new System.EventHandler(this.RotateAboutYRadioButton_CheckedChanged);
            // 
            // RotateAboutZRadioButton
            // 
            this.RotateAboutZRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateAboutZRadioButton.AutoSize = true;
            this.RotateAboutZRadioButton.Location = new System.Drawing.Point(1571, 230);
            this.RotateAboutZRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RotateAboutZRadioButton.Name = "RotateAboutZRadioButton";
            this.RotateAboutZRadioButton.Size = new System.Drawing.Size(141, 20);
            this.RotateAboutZRadioButton.TabIndex = 9;
            this.RotateAboutZRadioButton.Text = "Поворот по оси Z";
            this.RotateAboutZRadioButton.UseVisualStyleBackColor = true;
            this.RotateAboutZRadioButton.CheckedChanged += new System.EventHandler(this.RotateAboutZRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1572, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Поворот относительно прямой";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1575, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Координаты точки A";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1575, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Координаты вектора";
            // 
            // customRotatingRadioButton
            // 
            this.customRotatingRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customRotatingRadioButton.AutoSize = true;
            this.customRotatingRadioButton.Location = new System.Drawing.Point(1574, 453);
            this.customRotatingRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customRotatingRadioButton.Name = "customRotatingRadioButton";
            this.customRotatingRadioButton.Size = new System.Drawing.Size(223, 20);
            this.customRotatingRadioButton.TabIndex = 13;
            this.customRotatingRadioButton.Text = "Поворот относительно линии";
            this.customRotatingRadioButton.UseVisualStyleBackColor = true;
            this.customRotatingRadioButton.CheckedChanged += new System.EventHandler(this.customRotatingRadioButton_CheckedChanged);
            // 
            // lineStartXNumericUpDown
            // 
            this.lineStartXNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineStartXNumericUpDown.DecimalPlaces = 2;
            this.lineStartXNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineStartXNumericUpDown.Location = new System.Drawing.Point(1599, 320);
            this.lineStartXNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineStartXNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineStartXNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineStartXNumericUpDown.Name = "lineStartXNumericUpDown";
            this.lineStartXNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineStartXNumericUpDown.TabIndex = 14;
            this.lineStartXNumericUpDown.ValueChanged += new System.EventHandler(this.lineStartNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1575, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1666, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Y:";
            // 
            // lineStartYNumericUpDown
            // 
            this.lineStartYNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineStartYNumericUpDown.DecimalPlaces = 2;
            this.lineStartYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineStartYNumericUpDown.Location = new System.Drawing.Point(1690, 320);
            this.lineStartYNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineStartYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineStartYNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineStartYNumericUpDown.Name = "lineStartYNumericUpDown";
            this.lineStartYNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineStartYNumericUpDown.TabIndex = 16;
            this.lineStartYNumericUpDown.ValueChanged += new System.EventHandler(this.lineStartNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1750, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Z:";
            // 
            // lineStartZNumericUpDown
            // 
            this.lineStartZNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineStartZNumericUpDown.DecimalPlaces = 2;
            this.lineStartZNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineStartZNumericUpDown.Location = new System.Drawing.Point(1774, 320);
            this.lineStartZNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineStartZNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineStartZNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineStartZNumericUpDown.Name = "lineStartZNumericUpDown";
            this.lineStartZNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineStartZNumericUpDown.TabIndex = 18;
            this.lineStartZNumericUpDown.ValueChanged += new System.EventHandler(this.lineStartNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1750, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Z:";
            // 
            // lineVecZNumericUpDown
            // 
            this.lineVecZNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineVecZNumericUpDown.DecimalPlaces = 2;
            this.lineVecZNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineVecZNumericUpDown.Location = new System.Drawing.Point(1774, 367);
            this.lineVecZNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineVecZNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineVecZNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineVecZNumericUpDown.Name = "lineVecZNumericUpDown";
            this.lineVecZNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineVecZNumericUpDown.TabIndex = 24;
            this.lineVecZNumericUpDown.ValueChanged += new System.EventHandler(this.lineVecNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1666, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Y:";
            // 
            // lineVecYNumericUpDown
            // 
            this.lineVecYNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineVecYNumericUpDown.DecimalPlaces = 2;
            this.lineVecYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineVecYNumericUpDown.Location = new System.Drawing.Point(1690, 367);
            this.lineVecYNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineVecYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineVecYNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineVecYNumericUpDown.Name = "lineVecYNumericUpDown";
            this.lineVecYNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineVecYNumericUpDown.TabIndex = 22;
            this.lineVecYNumericUpDown.ValueChanged += new System.EventHandler(this.lineVecNumericUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1575, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "X:";
            // 
            // lineVecXNumericUpDown
            // 
            this.lineVecXNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineVecXNumericUpDown.DecimalPlaces = 2;
            this.lineVecXNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineVecXNumericUpDown.Location = new System.Drawing.Point(1599, 367);
            this.lineVecXNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineVecXNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineVecXNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineVecXNumericUpDown.Name = "lineVecXNumericUpDown";
            this.lineVecXNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineVecXNumericUpDown.TabIndex = 20;
            this.lineVecXNumericUpDown.ValueChanged += new System.EventHandler(this.lineVecNumericUpDown_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фигурыToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 28);
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фигурыToolStripMenuItem1,
            this.проекцияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1859, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фигурыToolStripMenuItem1
            // 
            this.фигурыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TetrahedronToolStripMenuItem,
            this.HexahedronToolStripMenuItem,
            this.OctahedronToolStripMenuItem,
            this.IcosahedronToolStripMenuItem,
            this.DodecahedronToolStripMenuItem});
            this.фигурыToolStripMenuItem1.Name = "фигурыToolStripMenuItem1";
            this.фигурыToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.фигурыToolStripMenuItem1.Text = "Фигуры";
            // 
            // TetrahedronToolStripMenuItem
            // 
            this.TetrahedronToolStripMenuItem.Name = "TetrahedronToolStripMenuItem";
            this.TetrahedronToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.TetrahedronToolStripMenuItem.Text = "Тетраэдр";
            this.TetrahedronToolStripMenuItem.Click += new System.EventHandler(this.TetrahedronToolStripMenuItem_Click);
            // 
            // HexahedronToolStripMenuItem
            // 
            this.HexahedronToolStripMenuItem.Name = "HexahedronToolStripMenuItem";
            this.HexahedronToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.HexahedronToolStripMenuItem.Text = "Гексаэдр ";
            this.HexahedronToolStripMenuItem.Click += new System.EventHandler(this.HexahedronToolStripMenuItem_Click);
            // 
            // OctahedronToolStripMenuItem
            // 
            this.OctahedronToolStripMenuItem.Name = "OctahedronToolStripMenuItem";
            this.OctahedronToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.OctahedronToolStripMenuItem.Text = "Октаэдр";
            this.OctahedronToolStripMenuItem.Click += new System.EventHandler(this.OctahedronToolStripMenuItem_Click);
            // 
            // IcosahedronToolStripMenuItem
            // 
            this.IcosahedronToolStripMenuItem.Name = "IcosahedronToolStripMenuItem";
            this.IcosahedronToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.IcosahedronToolStripMenuItem.Text = "Икосаэдр";
            this.IcosahedronToolStripMenuItem.Click += new System.EventHandler(this.IcosahedronToolStripMenuItem_Click);
            // 
            // DodecahedronToolStripMenuItem
            // 
            this.DodecahedronToolStripMenuItem.Name = "DodecahedronToolStripMenuItem";
            this.DodecahedronToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.DodecahedronToolStripMenuItem.Text = "Додекаэдр";
            this.DodecahedronToolStripMenuItem.Click += new System.EventHandler(this.DodecahedronToolStripMenuItem_Click);
            // 
            // проекцияToolStripMenuItem
            // 
            this.проекцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PerspectiveToolStripMenuItem,
            this.TrimetricToolStripMenuItem,
            this.DimetricToolStripMenuItem,
            this.IsometricToolStripMenuItem});
            this.проекцияToolStripMenuItem.Name = "проекцияToolStripMenuItem";
            this.проекцияToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.проекцияToolStripMenuItem.Text = "Проекция";
            // 
            // PerspectiveToolStripMenuItem
            // 
            this.PerspectiveToolStripMenuItem.Name = "PerspectiveToolStripMenuItem";
            this.PerspectiveToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.PerspectiveToolStripMenuItem.Text = "Перспективная ";
            this.PerspectiveToolStripMenuItem.Click += new System.EventHandler(this.PerspectiveToolStripMenuItem_Click);
            // 
            // TrimetricToolStripMenuItem
            // 
            this.TrimetricToolStripMenuItem.Name = "TrimetricToolStripMenuItem";
            this.TrimetricToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.TrimetricToolStripMenuItem.Text = "Триметрическая";
            this.TrimetricToolStripMenuItem.Click += new System.EventHandler(this.TrimetricToolStripMenuItem_Click);
            // 
            // DimetricToolStripMenuItem
            // 
            this.DimetricToolStripMenuItem.Name = "DimetricToolStripMenuItem";
            this.DimetricToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.DimetricToolStripMenuItem.Text = "Диметрическая";
            this.DimetricToolStripMenuItem.Click += new System.EventHandler(this.DimetricToolStripMenuItem_Click);
            // 
            // IsometricToolStripMenuItem
            // 
            this.IsometricToolStripMenuItem.Name = "IsometricToolStripMenuItem";
            this.IsometricToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.IsometricToolStripMenuItem.Text = "Изометрическая";
            this.IsometricToolStripMenuItem.Click += new System.EventHandler(this.IsometricToolStripMenuItem_Click);
            // 
            // ScaleRadioButton
            // 
            this.ScaleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleRadioButton.AutoSize = true;
            this.ScaleRadioButton.Location = new System.Drawing.Point(1571, 34);
            this.ScaleRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScaleRadioButton.Name = "ScaleRadioButton";
            this.ScaleRadioButton.Size = new System.Drawing.Size(229, 20);
            this.ScaleRadioButton.TabIndex = 28;
            this.ScaleRadioButton.Text = "Масштабирование отн. центра";
            this.ScaleRadioButton.UseVisualStyleBackColor = true;
            this.ScaleRadioButton.CheckedChanged += new System.EventHandler(this.ScaleRadioButton_CheckedChanged);
            // 
            // TranslateAboutZRadioButton
            // 
            this.TranslateAboutZRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslateAboutZRadioButton.AutoSize = true;
            this.TranslateAboutZRadioButton.Location = new System.Drawing.Point(1581, 559);
            this.TranslateAboutZRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TranslateAboutZRadioButton.Name = "TranslateAboutZRadioButton";
            this.TranslateAboutZRadioButton.Size = new System.Drawing.Size(151, 20);
            this.TranslateAboutZRadioButton.TabIndex = 31;
            this.TranslateAboutZRadioButton.Text = "Смещение по оси Z";
            this.TranslateAboutZRadioButton.UseVisualStyleBackColor = true;
            this.TranslateAboutZRadioButton.CheckedChanged += new System.EventHandler(this.TranslateAboutZRadioButton_CheckedChanged);
            // 
            // TranslateAboutYRadioButton
            // 
            this.TranslateAboutYRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslateAboutYRadioButton.AutoSize = true;
            this.TranslateAboutYRadioButton.Location = new System.Drawing.Point(1580, 532);
            this.TranslateAboutYRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TranslateAboutYRadioButton.Name = "TranslateAboutYRadioButton";
            this.TranslateAboutYRadioButton.Size = new System.Drawing.Size(152, 20);
            this.TranslateAboutYRadioButton.TabIndex = 30;
            this.TranslateAboutYRadioButton.Text = "Смещение по оси Y";
            this.TranslateAboutYRadioButton.UseVisualStyleBackColor = true;
            this.TranslateAboutYRadioButton.CheckedChanged += new System.EventHandler(this.TranslateAboutYRadioButton_CheckedChanged);
            // 
            // TranslateAboutXRadioButton
            // 
            this.TranslateAboutXRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslateAboutXRadioButton.AutoSize = true;
            this.TranslateAboutXRadioButton.Location = new System.Drawing.Point(1581, 506);
            this.TranslateAboutXRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TranslateAboutXRadioButton.Name = "TranslateAboutXRadioButton";
            this.TranslateAboutXRadioButton.Size = new System.Drawing.Size(151, 20);
            this.TranslateAboutXRadioButton.TabIndex = 29;
            this.TranslateAboutXRadioButton.Text = "Смещение по оси X";
            this.TranslateAboutXRadioButton.UseVisualStyleBackColor = true;
            this.TranslateAboutXRadioButton.CheckedChanged += new System.EventHandler(this.TranslateAboutXRadioButton_CheckedChanged);
            // 
            // ScaleAboutXRadioButton
            // 
            this.ScaleAboutXRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleAboutXRadioButton.AutoSize = true;
            this.ScaleAboutXRadioButton.Location = new System.Drawing.Point(1575, 78);
            this.ScaleAboutXRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScaleAboutXRadioButton.Name = "ScaleAboutXRadioButton";
            this.ScaleAboutXRadioButton.Size = new System.Drawing.Size(216, 20);
            this.ScaleAboutXRadioButton.TabIndex = 32;
            this.ScaleAboutXRadioButton.Text = "Масштабирование отн. оси X";
            this.ScaleAboutXRadioButton.UseVisualStyleBackColor = true;
            this.ScaleAboutXRadioButton.CheckedChanged += new System.EventHandler(this.ScaleAboutXRadioButton_CheckedChanged);
            // 
            // ScaleAboutYRadioButton
            // 
            this.ScaleAboutYRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleAboutYRadioButton.AutoSize = true;
            this.ScaleAboutYRadioButton.Location = new System.Drawing.Point(1574, 103);
            this.ScaleAboutYRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScaleAboutYRadioButton.Name = "ScaleAboutYRadioButton";
            this.ScaleAboutYRadioButton.Size = new System.Drawing.Size(217, 20);
            this.ScaleAboutYRadioButton.TabIndex = 33;
            this.ScaleAboutYRadioButton.Text = "Масштабирование отн. оси Y";
            this.ScaleAboutYRadioButton.UseVisualStyleBackColor = true;
            this.ScaleAboutYRadioButton.CheckedChanged += new System.EventHandler(this.ScaleAboutYRadioButton_CheckedChanged);
            // 
            // ScaleAboutZRadioButton
            // 
            this.ScaleAboutZRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleAboutZRadioButton.AutoSize = true;
            this.ScaleAboutZRadioButton.Location = new System.Drawing.Point(1575, 129);
            this.ScaleAboutZRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScaleAboutZRadioButton.Name = "ScaleAboutZRadioButton";
            this.ScaleAboutZRadioButton.Size = new System.Drawing.Size(216, 20);
            this.ScaleAboutZRadioButton.TabIndex = 34;
            this.ScaleAboutZRadioButton.Text = "Масштабирование отн. оси Z";
            this.ScaleAboutZRadioButton.UseVisualStyleBackColor = true;
            this.ScaleAboutZRadioButton.CheckedChanged += new System.EventHandler(this.ScaleAboutZRadioButton_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1754, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Z:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1670, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Y:";
            // 
            // lineEndYNumericUpDown
            // 
            this.lineEndYNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineEndYNumericUpDown.DecimalPlaces = 2;
            this.lineEndYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineEndYNumericUpDown.Location = new System.Drawing.Point(1694, 412);
            this.lineEndYNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineEndYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineEndYNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineEndYNumericUpDown.Name = "lineEndYNumericUpDown";
            this.lineEndYNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineEndYNumericUpDown.TabIndex = 38;
            this.lineEndYNumericUpDown.ValueChanged += new System.EventHandler(this.lineEndNumericUpDown_ValueChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1579, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "X:";
            // 
            // lineEndXNumericUpDown
            // 
            this.lineEndXNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineEndXNumericUpDown.DecimalPlaces = 2;
            this.lineEndXNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineEndXNumericUpDown.Location = new System.Drawing.Point(1603, 412);
            this.lineEndXNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineEndXNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineEndXNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineEndXNumericUpDown.Name = "lineEndXNumericUpDown";
            this.lineEndXNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineEndXNumericUpDown.TabIndex = 36;
            this.lineEndXNumericUpDown.ValueChanged += new System.EventHandler(this.lineEndNumericUpDown_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1579, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Координаты точки B";
            // 
            // lineEndZNumericUpDown
            // 
            this.lineEndZNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineEndZNumericUpDown.DecimalPlaces = 2;
            this.lineEndZNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lineEndZNumericUpDown.Location = new System.Drawing.Point(1782, 412);
            this.lineEndZNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineEndZNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineEndZNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.lineEndZNumericUpDown.Name = "lineEndZNumericUpDown";
            this.lineEndZNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.lineEndZNumericUpDown.TabIndex = 41;
            this.lineEndZNumericUpDown.ValueChanged += new System.EventHandler(this.lineEndNumericUpDown_ValueChanged);
            // 
            // refclectXYbutton
            // 
            this.refclectXYbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refclectXYbutton.Location = new System.Drawing.Point(1565, 612);
            this.refclectXYbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refclectXYbutton.Name = "refclectXYbutton";
            this.refclectXYbutton.Size = new System.Drawing.Size(196, 28);
            this.refclectXYbutton.TabIndex = 42;
            this.refclectXYbutton.Text = "Отразить по XY";
            this.refclectXYbutton.UseVisualStyleBackColor = true;
            this.refclectXYbutton.Click += new System.EventHandler(this.refclectXYbutton_Click);
            // 
            // refclectXZbutton
            // 
            this.refclectXZbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refclectXZbutton.Location = new System.Drawing.Point(1565, 647);
            this.refclectXZbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refclectXZbutton.Name = "refclectXZbutton";
            this.refclectXZbutton.Size = new System.Drawing.Size(196, 28);
            this.refclectXZbutton.TabIndex = 43;
            this.refclectXZbutton.Text = "Отразить по XZ";
            this.refclectXZbutton.UseVisualStyleBackColor = true;
            this.refclectXZbutton.Click += new System.EventHandler(this.refclectXZbutton_Click);
            // 
            // refclectYZbutton
            // 
            this.refclectYZbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refclectYZbutton.Location = new System.Drawing.Point(1565, 683);
            this.refclectYZbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refclectYZbutton.Name = "refclectYZbutton";
            this.refclectYZbutton.Size = new System.Drawing.Size(196, 28);
            this.refclectYZbutton.TabIndex = 44;
            this.refclectYZbutton.Text = "Отразить по YZ";
            this.refclectYZbutton.UseVisualStyleBackColor = true;
            this.refclectYZbutton.Click += new System.EventHandler(this.refclectYZbutton_Click);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 921);
            this.Controls.Add(this.refclectYZbutton);
            this.Controls.Add(this.refclectXZbutton);
            this.Controls.Add(this.refclectXYbutton);
            this.Controls.Add(this.lineEndZNumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lineEndYNumericUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lineEndXNumericUpDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ScaleAboutZRadioButton);
            this.Controls.Add(this.ScaleAboutYRadioButton);
            this.Controls.Add(this.ScaleAboutXRadioButton);
            this.Controls.Add(this.TranslateAboutZRadioButton);
            this.Controls.Add(this.TranslateAboutYRadioButton);
            this.Controls.Add(this.TranslateAboutXRadioButton);
            this.Controls.Add(this.ScaleRadioButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lineVecZNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lineVecYNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lineVecXNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lineStartZNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineStartYNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lineStartXNumericUpDown);
            this.Controls.Add(this.customRotatingRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RotateAboutZRadioButton);
            this.Controls.Add(this.RotateAboutYRadioButton);
            this.Controls.Add(this.RotateAboutXRadioButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Scene";
            this.Text = "Scene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.lineStartXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineStartYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineStartZNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineVecZNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineVecYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineVecXNumericUpDown)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineEndYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineEndXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineEndZNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RotateAboutXRadioButton;
        private System.Windows.Forms.RadioButton RotateAboutYRadioButton;
        private System.Windows.Forms.RadioButton RotateAboutZRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton customRotatingRadioButton;
        private System.Windows.Forms.NumericUpDown lineStartXNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown lineStartYNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown lineStartZNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown lineVecZNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown lineVecYNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown lineVecXNumericUpDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TetrahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HexahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OctahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IcosahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DodecahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PerspectiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrimetricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DimetricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IsometricToolStripMenuItem;
        private System.Windows.Forms.RadioButton ScaleRadioButton;
        private System.Windows.Forms.RadioButton TranslateAboutZRadioButton;
        private System.Windows.Forms.RadioButton TranslateAboutYRadioButton;
        private System.Windows.Forms.RadioButton TranslateAboutXRadioButton;
        private System.Windows.Forms.RadioButton ScaleAboutXRadioButton;
        private System.Windows.Forms.RadioButton ScaleAboutYRadioButton;
        private System.Windows.Forms.RadioButton ScaleAboutZRadioButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown lineEndYNumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown lineEndXNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown lineEndZNumericUpDown;
        private System.Windows.Forms.Button refclectXYbutton;
        private System.Windows.Forms.Button refclectXZbutton;
        private System.Windows.Forms.Button refclectYZbutton;
    }
}

