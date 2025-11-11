namespace CS332_Lab8
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            RotateAboutXRadioButton = new RadioButton();
            RotateAboutYRadioButton = new RadioButton();
            RotateAboutZRadioButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            customRotatingRadioButton = new RadioButton();
            lineStartXNumericUpDown = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            lineStartYNumericUpDown = new NumericUpDown();
            label6 = new Label();
            lineStartZNumericUpDown = new NumericUpDown();
            label7 = new Label();
            lineVecZNumericUpDown = new NumericUpDown();
            label8 = new Label();
            lineVecYNumericUpDown = new NumericUpDown();
            label9 = new Label();
            lineVecXNumericUpDown = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            фигурыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            фигурыToolStripMenuItem1 = new ToolStripMenuItem();
            TetrahedronToolStripMenuItem = new ToolStripMenuItem();
            HexahedronToolStripMenuItem = new ToolStripMenuItem();
            OctahedronToolStripMenuItem = new ToolStripMenuItem();
            IcosahedronToolStripMenuItem = new ToolStripMenuItem();
            DodecahedronToolStripMenuItem = new ToolStripMenuItem();
            rotationFigureToolStripMenuItem = new ToolStripMenuItem();
            plotToolStripMenuItem = new ToolStripMenuItem();
            проекцияToolStripMenuItem = new ToolStripMenuItem();
            PerspectiveToolStripMenuItem = new ToolStripMenuItem();
            TrimetricToolStripMenuItem = new ToolStripMenuItem();
            DimetricToolStripMenuItem = new ToolStripMenuItem();
            IsometricToolStripMenuItem = new ToolStripMenuItem();
            ScaleRadioButton = new RadioButton();
            TranslateAboutZRadioButton = new RadioButton();
            TranslateAboutYRadioButton = new RadioButton();
            TranslateAboutXRadioButton = new RadioButton();
            ScaleAboutXRadioButton = new RadioButton();
            ScaleAboutYRadioButton = new RadioButton();
            ScaleAboutZRadioButton = new RadioButton();
            label10 = new Label();
            label11 = new Label();
            lineEndYNumericUpDown = new NumericUpDown();
            label12 = new Label();
            lineEndXNumericUpDown = new NumericUpDown();
            label13 = new Label();
            lineEndZNumericUpDown = new NumericUpDown();
            refclectXYbutton = new Button();
            refclectXZbutton = new Button();
            refclectYZbutton = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            setCamersRadioButton = new RadioButton();
            setPolyhedronRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)lineStartXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineStartYNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineStartZNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineVecZNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineVecYNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineVecXNumericUpDown).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lineEndYNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineEndXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineEndZNumericUpDown).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(11, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1528, 997);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // RotateAboutXRadioButton
            // 
            RotateAboutXRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RotateAboutXRadioButton.AutoSize = true;
            RotateAboutXRadioButton.Location = new Point(1565, 278);
            RotateAboutXRadioButton.Name = "RotateAboutXRadioButton";
            RotateAboutXRadioButton.Size = new Size(155, 24);
            RotateAboutXRadioButton.TabIndex = 7;
            RotateAboutXRadioButton.Text = "Поворот по оси X";
            RotateAboutXRadioButton.UseVisualStyleBackColor = true;
            RotateAboutXRadioButton.CheckedChanged += RotateAboutXRadioButton_CheckedChanged;
            // 
            // RotateAboutYRadioButton
            // 
            RotateAboutYRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RotateAboutYRadioButton.AutoSize = true;
            RotateAboutYRadioButton.Location = new Point(1566, 310);
            RotateAboutYRadioButton.Name = "RotateAboutYRadioButton";
            RotateAboutYRadioButton.Size = new Size(154, 24);
            RotateAboutYRadioButton.TabIndex = 8;
            RotateAboutYRadioButton.Text = "Поворот по оси Y";
            RotateAboutYRadioButton.UseVisualStyleBackColor = true;
            RotateAboutYRadioButton.CheckedChanged += RotateAboutYRadioButton_CheckedChanged;
            // 
            // RotateAboutZRadioButton
            // 
            RotateAboutZRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RotateAboutZRadioButton.AutoSize = true;
            RotateAboutZRadioButton.Location = new Point(1565, 345);
            RotateAboutZRadioButton.Name = "RotateAboutZRadioButton";
            RotateAboutZRadioButton.Size = new Size(155, 24);
            RotateAboutZRadioButton.TabIndex = 9;
            RotateAboutZRadioButton.Text = "Поворот по оси Z";
            RotateAboutZRadioButton.UseVisualStyleBackColor = true;
            RotateAboutZRadioButton.CheckedChanged += RotateAboutZRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1581, 389);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 10;
            label1.Text = "Поворот относительно прямой";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1583, 428);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 11;
            label2.Text = "Координаты точки A";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1583, 492);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 12;
            label3.Text = "Координаты вектора";
            // 
            // customRotatingRadioButton
            // 
            customRotatingRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customRotatingRadioButton.AutoSize = true;
            customRotatingRadioButton.Location = new Point(1564, 622);
            customRotatingRadioButton.Name = "customRotatingRadioButton";
            customRotatingRadioButton.Size = new Size(240, 24);
            customRotatingRadioButton.TabIndex = 13;
            customRotatingRadioButton.Text = "Поворот относительно линии";
            customRotatingRadioButton.UseVisualStyleBackColor = true;
            customRotatingRadioButton.CheckedChanged += customRotatingRadioButton_CheckedChanged;
            // 
            // lineStartXNumericUpDown
            // 
            lineStartXNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineStartXNumericUpDown.DecimalPlaces = 2;
            lineStartXNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineStartXNumericUpDown.Location = new Point(1607, 457);
            lineStartXNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineStartXNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineStartXNumericUpDown.Name = "lineStartXNumericUpDown";
            lineStartXNumericUpDown.Size = new Size(61, 27);
            lineStartXNumericUpDown.TabIndex = 14;
            lineStartXNumericUpDown.ValueChanged += lineStartNumericUpDown_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1583, 460);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 15;
            label4.Text = "X:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1674, 460);
            label5.Name = "label5";
            label5.Size = new Size(20, 20);
            label5.TabIndex = 17;
            label5.Text = "Y:";
            // 
            // lineStartYNumericUpDown
            // 
            lineStartYNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineStartYNumericUpDown.DecimalPlaces = 2;
            lineStartYNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineStartYNumericUpDown.Location = new Point(1698, 457);
            lineStartYNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineStartYNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineStartYNumericUpDown.Name = "lineStartYNumericUpDown";
            lineStartYNumericUpDown.Size = new Size(61, 27);
            lineStartYNumericUpDown.TabIndex = 16;
            lineStartYNumericUpDown.ValueChanged += lineStartNumericUpDown_ValueChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(1758, 460);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 19;
            label6.Text = "Z:";
            // 
            // lineStartZNumericUpDown
            // 
            lineStartZNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineStartZNumericUpDown.DecimalPlaces = 2;
            lineStartZNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineStartZNumericUpDown.Location = new Point(1782, 457);
            lineStartZNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineStartZNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineStartZNumericUpDown.Name = "lineStartZNumericUpDown";
            lineStartZNumericUpDown.Size = new Size(61, 27);
            lineStartZNumericUpDown.TabIndex = 18;
            lineStartZNumericUpDown.ValueChanged += lineStartNumericUpDown_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1758, 518);
            label7.Name = "label7";
            label7.Size = new Size(21, 20);
            label7.TabIndex = 25;
            label7.Text = "Z:";
            // 
            // lineVecZNumericUpDown
            // 
            lineVecZNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineVecZNumericUpDown.DecimalPlaces = 2;
            lineVecZNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineVecZNumericUpDown.Location = new Point(1782, 516);
            lineVecZNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineVecZNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineVecZNumericUpDown.Name = "lineVecZNumericUpDown";
            lineVecZNumericUpDown.Size = new Size(61, 27);
            lineVecZNumericUpDown.TabIndex = 24;
            lineVecZNumericUpDown.ValueChanged += lineVecNumericUpDown_ValueChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(1674, 518);
            label8.Name = "label8";
            label8.Size = new Size(20, 20);
            label8.TabIndex = 23;
            label8.Text = "Y:";
            // 
            // lineVecYNumericUpDown
            // 
            lineVecYNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineVecYNumericUpDown.DecimalPlaces = 2;
            lineVecYNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineVecYNumericUpDown.Location = new Point(1698, 516);
            lineVecYNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineVecYNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineVecYNumericUpDown.Name = "lineVecYNumericUpDown";
            lineVecYNumericUpDown.Size = new Size(61, 27);
            lineVecYNumericUpDown.TabIndex = 22;
            lineVecYNumericUpDown.ValueChanged += lineVecNumericUpDown_ValueChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(1583, 518);
            label9.Name = "label9";
            label9.Size = new Size(21, 20);
            label9.TabIndex = 21;
            label9.Text = "X:";
            // 
            // lineVecXNumericUpDown
            // 
            lineVecXNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineVecXNumericUpDown.DecimalPlaces = 2;
            lineVecXNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineVecXNumericUpDown.Location = new Point(1607, 516);
            lineVecXNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineVecXNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineVecXNumericUpDown.Name = "lineVecXNumericUpDown";
            lineVecXNumericUpDown.Size = new Size(61, 27);
            lineVecXNumericUpDown.TabIndex = 20;
            lineVecXNumericUpDown.ValueChanged += lineVecNumericUpDown_ValueChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { фигурыToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(132, 28);
            // 
            // фигурыToolStripMenuItem
            // 
            фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            фигурыToolStripMenuItem.Size = new Size(131, 24);
            фигурыToolStripMenuItem.Text = "Фигуры";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фигурыToolStripMenuItem1, проекцияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 3, 0, 3);
            menuStrip1.Size = new Size(1859, 30);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(166, 26);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click_1;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(166, 26);
            loadToolStripMenuItem.Text = "Загрузить";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // фигурыToolStripMenuItem1
            // 
            фигурыToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { TetrahedronToolStripMenuItem, HexahedronToolStripMenuItem, OctahedronToolStripMenuItem, IcosahedronToolStripMenuItem, DodecahedronToolStripMenuItem, rotationFigureToolStripMenuItem, plotToolStripMenuItem });
            фигурыToolStripMenuItem1.Name = "фигурыToolStripMenuItem1";
            фигурыToolStripMenuItem1.Size = new Size(76, 24);
            фигурыToolStripMenuItem1.Text = "Фигуры";
            // 
            // TetrahedronToolStripMenuItem
            // 
            TetrahedronToolStripMenuItem.Name = "TetrahedronToolStripMenuItem";
            TetrahedronToolStripMenuItem.Size = new Size(269, 26);
            TetrahedronToolStripMenuItem.Text = "Тетраэдр";
            TetrahedronToolStripMenuItem.Click += TetrahedronToolStripMenuItem_Click;
            // 
            // HexahedronToolStripMenuItem
            // 
            HexahedronToolStripMenuItem.Name = "HexahedronToolStripMenuItem";
            HexahedronToolStripMenuItem.Size = new Size(269, 26);
            HexahedronToolStripMenuItem.Text = "Гексаэдр ";
            HexahedronToolStripMenuItem.Click += HexahedronToolStripMenuItem_Click;
            // 
            // OctahedronToolStripMenuItem
            // 
            OctahedronToolStripMenuItem.Name = "OctahedronToolStripMenuItem";
            OctahedronToolStripMenuItem.Size = new Size(269, 26);
            OctahedronToolStripMenuItem.Text = "Октаэдр";
            OctahedronToolStripMenuItem.Click += OctahedronToolStripMenuItem_Click;
            // 
            // IcosahedronToolStripMenuItem
            // 
            IcosahedronToolStripMenuItem.Name = "IcosahedronToolStripMenuItem";
            IcosahedronToolStripMenuItem.Size = new Size(269, 26);
            IcosahedronToolStripMenuItem.Text = "Икосаэдр";
            IcosahedronToolStripMenuItem.Click += IcosahedronToolStripMenuItem_Click;
            // 
            // DodecahedronToolStripMenuItem
            // 
            DodecahedronToolStripMenuItem.Name = "DodecahedronToolStripMenuItem";
            DodecahedronToolStripMenuItem.Size = new Size(269, 26);
            DodecahedronToolStripMenuItem.Text = "Додекаэдр";
            DodecahedronToolStripMenuItem.Click += DodecahedronToolStripMenuItem_Click;
            // 
            // rotationFigureToolStripMenuItem
            // 
            rotationFigureToolStripMenuItem.Name = "rotationFigureToolStripMenuItem";
            rotationFigureToolStripMenuItem.Size = new Size(269, 26);
            rotationFigureToolStripMenuItem.Text = "Фигура вращения";
            rotationFigureToolStripMenuItem.Click += rotationFigureToolStripMenuItem_Click;
            // 
            // plotToolStripMenuItem
            // 
            plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            plotToolStripMenuItem.Size = new Size(269, 26);
            plotToolStripMenuItem.Text = "График двух переменных";
            plotToolStripMenuItem.Click += plotToolStripMenuItem_Click;
            // 
            // проекцияToolStripMenuItem
            // 
            проекцияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PerspectiveToolStripMenuItem, TrimetricToolStripMenuItem, DimetricToolStripMenuItem, IsometricToolStripMenuItem });
            проекцияToolStripMenuItem.Name = "проекцияToolStripMenuItem";
            проекцияToolStripMenuItem.Size = new Size(93, 24);
            проекцияToolStripMenuItem.Text = "Проекция";
            // 
            // PerspectiveToolStripMenuItem
            // 
            PerspectiveToolStripMenuItem.Name = "PerspectiveToolStripMenuItem";
            PerspectiveToolStripMenuItem.Size = new Size(224, 26);
            PerspectiveToolStripMenuItem.Text = "Перспективная ";
            PerspectiveToolStripMenuItem.Click += PerspectiveToolStripMenuItem_Click;
            // 
            // TrimetricToolStripMenuItem
            // 
            TrimetricToolStripMenuItem.Name = "TrimetricToolStripMenuItem";
            TrimetricToolStripMenuItem.Size = new Size(224, 26);
            TrimetricToolStripMenuItem.Text = "Триметрическая";
            TrimetricToolStripMenuItem.Click += TrimetricToolStripMenuItem_Click;
            // 
            // DimetricToolStripMenuItem
            // 
            DimetricToolStripMenuItem.Name = "DimetricToolStripMenuItem";
            DimetricToolStripMenuItem.Size = new Size(224, 26);
            DimetricToolStripMenuItem.Text = "Диметрическая";
            DimetricToolStripMenuItem.Click += DimetricToolStripMenuItem_Click;
            // 
            // IsometricToolStripMenuItem
            // 
            IsometricToolStripMenuItem.Name = "IsometricToolStripMenuItem";
            IsometricToolStripMenuItem.Size = new Size(224, 26);
            IsometricToolStripMenuItem.Text = "Изометрическая";
            IsometricToolStripMenuItem.Click += IsometricToolStripMenuItem_Click;
            // 
            // ScaleRadioButton
            // 
            ScaleRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScaleRadioButton.AutoSize = true;
            ScaleRadioButton.Location = new Point(1565, 134);
            ScaleRadioButton.Name = "ScaleRadioButton";
            ScaleRadioButton.Size = new Size(246, 24);
            ScaleRadioButton.TabIndex = 28;
            ScaleRadioButton.Text = "Масштабирование отн. центра";
            ScaleRadioButton.UseVisualStyleBackColor = true;
            ScaleRadioButton.CheckedChanged += ScaleRadioButton_CheckedChanged;
            // 
            // TranslateAboutZRadioButton
            // 
            TranslateAboutZRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TranslateAboutZRadioButton.AutoSize = true;
            TranslateAboutZRadioButton.Location = new Point(1564, 734);
            TranslateAboutZRadioButton.Name = "TranslateAboutZRadioButton";
            TranslateAboutZRadioButton.Size = new Size(168, 24);
            TranslateAboutZRadioButton.TabIndex = 31;
            TranslateAboutZRadioButton.Text = "Смещение по оси Z";
            TranslateAboutZRadioButton.UseVisualStyleBackColor = true;
            TranslateAboutZRadioButton.CheckedChanged += TranslateAboutZRadioButton_CheckedChanged;
            // 
            // TranslateAboutYRadioButton
            // 
            TranslateAboutYRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TranslateAboutYRadioButton.AutoSize = true;
            TranslateAboutYRadioButton.Location = new Point(1565, 700);
            TranslateAboutYRadioButton.Name = "TranslateAboutYRadioButton";
            TranslateAboutYRadioButton.Size = new Size(167, 24);
            TranslateAboutYRadioButton.TabIndex = 30;
            TranslateAboutYRadioButton.Text = "Смещение по оси Y";
            TranslateAboutYRadioButton.UseVisualStyleBackColor = true;
            TranslateAboutYRadioButton.CheckedChanged += TranslateAboutYRadioButton_CheckedChanged;
            // 
            // TranslateAboutXRadioButton
            // 
            TranslateAboutXRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TranslateAboutXRadioButton.AutoSize = true;
            TranslateAboutXRadioButton.Location = new Point(1564, 667);
            TranslateAboutXRadioButton.Name = "TranslateAboutXRadioButton";
            TranslateAboutXRadioButton.Size = new Size(168, 24);
            TranslateAboutXRadioButton.TabIndex = 29;
            TranslateAboutXRadioButton.Text = "Смещение по оси X";
            TranslateAboutXRadioButton.UseVisualStyleBackColor = true;
            TranslateAboutXRadioButton.CheckedChanged += TranslateAboutXRadioButton_CheckedChanged;
            // 
            // ScaleAboutXRadioButton
            // 
            ScaleAboutXRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScaleAboutXRadioButton.AutoSize = true;
            ScaleAboutXRadioButton.Location = new Point(1565, 164);
            ScaleAboutXRadioButton.Name = "ScaleAboutXRadioButton";
            ScaleAboutXRadioButton.Size = new Size(235, 24);
            ScaleAboutXRadioButton.TabIndex = 32;
            ScaleAboutXRadioButton.Text = "Масштабирование отн. оси X";
            ScaleAboutXRadioButton.UseVisualStyleBackColor = true;
            ScaleAboutXRadioButton.CheckedChanged += ScaleAboutXRadioButton_CheckedChanged;
            // 
            // ScaleAboutYRadioButton
            // 
            ScaleAboutYRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScaleAboutYRadioButton.AutoSize = true;
            ScaleAboutYRadioButton.Location = new Point(1565, 194);
            ScaleAboutYRadioButton.Name = "ScaleAboutYRadioButton";
            ScaleAboutYRadioButton.Size = new Size(234, 24);
            ScaleAboutYRadioButton.TabIndex = 33;
            ScaleAboutYRadioButton.Text = "Масштабирование отн. оси Y";
            ScaleAboutYRadioButton.UseVisualStyleBackColor = true;
            ScaleAboutYRadioButton.CheckedChanged += ScaleAboutYRadioButton_CheckedChanged;
            // 
            // ScaleAboutZRadioButton
            // 
            ScaleAboutZRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScaleAboutZRadioButton.AutoSize = true;
            ScaleAboutZRadioButton.Location = new Point(1564, 224);
            ScaleAboutZRadioButton.Name = "ScaleAboutZRadioButton";
            ScaleAboutZRadioButton.Size = new Size(235, 24);
            ScaleAboutZRadioButton.TabIndex = 34;
            ScaleAboutZRadioButton.Text = "Масштабирование отн. оси Z";
            ScaleAboutZRadioButton.UseVisualStyleBackColor = true;
            ScaleAboutZRadioButton.CheckedChanged += ScaleAboutZRadioButton_CheckedChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(1762, 576);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 40;
            label10.Text = "Z:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(1678, 576);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 39;
            label11.Text = "Y:";
            // 
            // lineEndYNumericUpDown
            // 
            lineEndYNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineEndYNumericUpDown.DecimalPlaces = 2;
            lineEndYNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineEndYNumericUpDown.Location = new Point(1702, 572);
            lineEndYNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineEndYNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineEndYNumericUpDown.Name = "lineEndYNumericUpDown";
            lineEndYNumericUpDown.Size = new Size(61, 27);
            lineEndYNumericUpDown.TabIndex = 38;
            lineEndYNumericUpDown.ValueChanged += lineEndNumericUpDown_ValueChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(1587, 576);
            label12.Name = "label12";
            label12.Size = new Size(21, 20);
            label12.TabIndex = 37;
            label12.Text = "X:";
            // 
            // lineEndXNumericUpDown
            // 
            lineEndXNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineEndXNumericUpDown.DecimalPlaces = 2;
            lineEndXNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineEndXNumericUpDown.Location = new Point(1611, 572);
            lineEndXNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineEndXNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineEndXNumericUpDown.Name = "lineEndXNumericUpDown";
            lineEndXNumericUpDown.Size = new Size(61, 27);
            lineEndXNumericUpDown.TabIndex = 36;
            lineEndXNumericUpDown.ValueChanged += lineEndNumericUpDown_ValueChanged;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(1587, 549);
            label13.Name = "label13";
            label13.Size = new Size(152, 20);
            label13.TabIndex = 35;
            label13.Text = "Координаты точки B";
            // 
            // lineEndZNumericUpDown
            // 
            lineEndZNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineEndZNumericUpDown.DecimalPlaces = 2;
            lineEndZNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineEndZNumericUpDown.Location = new Point(1790, 572);
            lineEndZNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineEndZNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineEndZNumericUpDown.Name = "lineEndZNumericUpDown";
            lineEndZNumericUpDown.Size = new Size(61, 27);
            lineEndZNumericUpDown.TabIndex = 41;
            lineEndZNumericUpDown.ValueChanged += lineEndNumericUpDown_ValueChanged;
            // 
            // refclectXYbutton
            // 
            refclectXYbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refclectXYbutton.Location = new Point(1564, 784);
            refclectXYbutton.Margin = new Padding(5);
            refclectXYbutton.Name = "refclectXYbutton";
            refclectXYbutton.Size = new Size(287, 35);
            refclectXYbutton.TabIndex = 42;
            refclectXYbutton.Text = "Отразить по XY";
            refclectXYbutton.UseVisualStyleBackColor = true;
            refclectXYbutton.Click += refclectXYbutton_Click;
            // 
            // refclectXZbutton
            // 
            refclectXZbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refclectXZbutton.Location = new Point(1564, 827);
            refclectXZbutton.Margin = new Padding(5);
            refclectXZbutton.Name = "refclectXZbutton";
            refclectXZbutton.Size = new Size(287, 35);
            refclectXZbutton.TabIndex = 43;
            refclectXZbutton.Text = "Отразить по XZ";
            refclectXZbutton.UseVisualStyleBackColor = true;
            refclectXZbutton.Click += refclectXZbutton_Click;
            // 
            // refclectYZbutton
            // 
            refclectYZbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refclectYZbutton.Location = new Point(1566, 872);
            refclectYZbutton.Margin = new Padding(5);
            refclectYZbutton.Name = "refclectYZbutton";
            refclectYZbutton.Size = new Size(285, 35);
            refclectYZbutton.TabIndex = 44;
            refclectYZbutton.Text = "Отразить по YZ";
            refclectYZbutton.UseVisualStyleBackColor = true;
            refclectYZbutton.Click += refclectYZbutton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(setCamersRadioButton);
            groupBox1.Controls.Add(setPolyhedronRadioButton);
            groupBox1.Location = new Point(1565, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 85);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор объекта";
            // 
            // setCamersRadioButton
            // 
            setCamersRadioButton.AutoSize = true;
            setCamersRadioButton.Location = new Point(14, 56);
            setCamersRadioButton.Name = "setCamersRadioButton";
            setCamersRadioButton.Size = new Size(83, 24);
            setCamersRadioButton.TabIndex = 1;
            setCamersRadioButton.TabStop = true;
            setCamersRadioButton.Text = "Камера";
            setCamersRadioButton.UseVisualStyleBackColor = true;
            setCamersRadioButton.CheckedChanged += setCamersRadioButton_CheckedChanged;
            // 
            // setPolyhedronRadioButton
            // 
            setPolyhedronRadioButton.AutoSize = true;
            setPolyhedronRadioButton.Location = new Point(14, 26);
            setPolyhedronRadioButton.Name = "setPolyhedronRadioButton";
            setPolyhedronRadioButton.Size = new Size(133, 24);
            setPolyhedronRadioButton.TabIndex = 0;
            setPolyhedronRadioButton.TabStop = true;
            setPolyhedronRadioButton.Text = "Многогранник";
            setPolyhedronRadioButton.UseVisualStyleBackColor = true;
            setPolyhedronRadioButton.CheckedChanged += setPolyhedronRadioButton_CheckedChanged;
            // 
            // Scene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1859, 1055);
            Controls.Add(groupBox1);
            Controls.Add(refclectYZbutton);
            Controls.Add(refclectXZbutton);
            Controls.Add(refclectXYbutton);
            Controls.Add(lineEndZNumericUpDown);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(lineEndYNumericUpDown);
            Controls.Add(label12);
            Controls.Add(lineEndXNumericUpDown);
            Controls.Add(label13);
            Controls.Add(ScaleAboutZRadioButton);
            Controls.Add(ScaleAboutYRadioButton);
            Controls.Add(ScaleAboutXRadioButton);
            Controls.Add(TranslateAboutZRadioButton);
            Controls.Add(TranslateAboutYRadioButton);
            Controls.Add(TranslateAboutXRadioButton);
            Controls.Add(ScaleRadioButton);
            Controls.Add(menuStrip1);
            Controls.Add(label7);
            Controls.Add(lineVecZNumericUpDown);
            Controls.Add(label8);
            Controls.Add(lineVecYNumericUpDown);
            Controls.Add(label9);
            Controls.Add(lineVecXNumericUpDown);
            Controls.Add(label6);
            Controls.Add(lineStartZNumericUpDown);
            Controls.Add(label5);
            Controls.Add(lineStartYNumericUpDown);
            Controls.Add(label4);
            Controls.Add(lineStartXNumericUpDown);
            Controls.Add(customRotatingRadioButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RotateAboutZRadioButton);
            Controls.Add(RotateAboutYRadioButton);
            Controls.Add(RotateAboutXRadioButton);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Scene";
            Text = "Scene";
            WindowState = FormWindowState.Maximized;
            SizeChanged += Scene_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)lineStartXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineStartYNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineStartZNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineVecZNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineVecYNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineVecXNumericUpDown).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lineEndYNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineEndXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineEndZNumericUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem rotationFigureToolStripMenuItem;
        private ToolStripMenuItem plotToolStripMenuItem;
        private GroupBox groupBox1;
        private RadioButton setCamersRadioButton;
        private RadioButton setPolyhedronRadioButton;
    }
}

