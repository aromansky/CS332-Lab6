namespace UI
{
    partial class TransformableRenderer
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
            scaleAroundZ_radioButton = new RadioButton();
            scaleAroundY_radioButton = new RadioButton();
            scaleAroundX_radioButton = new RadioButton();
            scaleAroundCenter_radioButton = new RadioButton();
            scale_groupBox = new GroupBox();
            rotateAxis_groupBox = new GroupBox();
            rotateAroundZ_radioButton = new RadioButton();
            rotateAroundY_radioButton = new RadioButton();
            rotateAroundX_radioButton = new RadioButton();
            translate_groupBox = new GroupBox();
            translateAroundZ_radioButton = new RadioButton();
            translateAboutX_radioButton = new RadioButton();
            translateAboutY_radioButton = new RadioButton();
            reflect_groupBox = new GroupBox();
            refclectYZ_button = new Button();
            refclectXY_button = new Button();
            refclectXZ_button = new Button();
            rotateAboutLine_groupBox = new GroupBox();
            lineEndZNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label7 = new Label();
            label5 = new Label();
            label10 = new Label();
            lineStartZNumericUpDown = new NumericUpDown();
            label13 = new Label();
            label3 = new Label();
            lineVecZNumericUpDown = new NumericUpDown();
            lineStartYNumericUpDown = new NumericUpDown();
            label11 = new Label();
            label6 = new Label();
            lineEndXNumericUpDown = new NumericUpDown();
            rotateAroundLine_radioButton = new RadioButton();
            label8 = new Label();
            label4 = new Label();
            lineEndYNumericUpDown = new NumericUpDown();
            lineVecXNumericUpDown = new NumericUpDown();
            label9 = new Label();
            label12 = new Label();
            lineStartXNumericUpDown = new NumericUpDown();
            lineVecYNumericUpDown = new NumericUpDown();
            groupBox = new GroupBox();
            scale_groupBox.SuspendLayout();
            rotateAxis_groupBox.SuspendLayout();
            translate_groupBox.SuspendLayout();
            reflect_groupBox.SuspendLayout();
            rotateAboutLine_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lineEndZNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineStartZNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineVecZNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineStartYNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineEndXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineEndYNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineVecXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineStartXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineVecYNumericUpDown).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // scaleAroundZ_radioButton
            // 
            scaleAroundZ_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scaleAroundZ_radioButton.AutoSize = true;
            scaleAroundZ_radioButton.Location = new Point(11, 109);
            scaleAroundZ_radioButton.Margin = new Padding(3, 2, 3, 2);
            scaleAroundZ_radioButton.Name = "scaleAroundZ_radioButton";
            scaleAroundZ_radioButton.Size = new Size(101, 24);
            scaleAroundZ_radioButton.TabIndex = 38;
            scaleAroundZ_radioButton.Text = "Отн. оси Z";
            scaleAroundZ_radioButton.UseVisualStyleBackColor = true;
            scaleAroundZ_radioButton.CheckedChanged += scaleAroundZ_radioButton_CheckedChanged;
            // 
            // scaleAroundY_radioButton
            // 
            scaleAroundY_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scaleAroundY_radioButton.AutoSize = true;
            scaleAroundY_radioButton.Location = new Point(11, 81);
            scaleAroundY_radioButton.Margin = new Padding(3, 2, 3, 2);
            scaleAroundY_radioButton.Name = "scaleAroundY_radioButton";
            scaleAroundY_radioButton.Size = new Size(100, 24);
            scaleAroundY_radioButton.TabIndex = 37;
            scaleAroundY_radioButton.Text = "Отн. оси Y";
            scaleAroundY_radioButton.UseVisualStyleBackColor = true;
            scaleAroundY_radioButton.CheckedChanged += scaleAroundY_radioButton_CheckedChanged;
            // 
            // scaleAroundX_radioButton
            // 
            scaleAroundX_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scaleAroundX_radioButton.AutoSize = true;
            scaleAroundX_radioButton.Location = new Point(11, 53);
            scaleAroundX_radioButton.Margin = new Padding(3, 2, 3, 2);
            scaleAroundX_radioButton.Name = "scaleAroundX_radioButton";
            scaleAroundX_radioButton.Size = new Size(101, 24);
            scaleAroundX_radioButton.TabIndex = 36;
            scaleAroundX_radioButton.Text = "Отн. оси X";
            scaleAroundX_radioButton.UseVisualStyleBackColor = true;
            scaleAroundX_radioButton.CheckedChanged += scaleAroundX_radioButton_CheckedChanged;
            // 
            // scaleAroundCenter_radioButton
            // 
            scaleAroundCenter_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scaleAroundCenter_radioButton.AutoSize = true;
            scaleAroundCenter_radioButton.Location = new Point(11, 25);
            scaleAroundCenter_radioButton.Margin = new Padding(3, 2, 3, 2);
            scaleAroundCenter_radioButton.Name = "scaleAroundCenter_radioButton";
            scaleAroundCenter_radioButton.Size = new Size(112, 24);
            scaleAroundCenter_radioButton.TabIndex = 35;
            scaleAroundCenter_radioButton.Text = "Отн. центра";
            scaleAroundCenter_radioButton.UseVisualStyleBackColor = true;
            scaleAroundCenter_radioButton.CheckedChanged += scaleAroundCenter_radioButton_CheckedChanged;
            // 
            // scale_groupBox
            // 
            scale_groupBox.Controls.Add(scaleAroundCenter_radioButton);
            scale_groupBox.Controls.Add(scaleAroundZ_radioButton);
            scale_groupBox.Controls.Add(scaleAroundX_radioButton);
            scale_groupBox.Controls.Add(scaleAroundY_radioButton);
            scale_groupBox.Location = new Point(6, 26);
            scale_groupBox.Name = "scale_groupBox";
            scale_groupBox.Size = new Size(350, 147);
            scale_groupBox.TabIndex = 39;
            scale_groupBox.TabStop = false;
            scale_groupBox.Text = "Масштабирование";
            // 
            // rotateAxis_groupBox
            // 
            rotateAxis_groupBox.Controls.Add(rotateAroundZ_radioButton);
            rotateAxis_groupBox.Controls.Add(rotateAroundY_radioButton);
            rotateAxis_groupBox.Controls.Add(rotateAroundX_radioButton);
            rotateAxis_groupBox.Location = new Point(6, 339);
            rotateAxis_groupBox.Name = "rotateAxis_groupBox";
            rotateAxis_groupBox.Size = new Size(350, 74);
            rotateAxis_groupBox.TabIndex = 40;
            rotateAxis_groupBox.TabStop = false;
            rotateAxis_groupBox.Text = "Поворот по оси";
            // 
            // rotateAroundZ_radioButton
            // 
            rotateAroundZ_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rotateAroundZ_radioButton.AutoSize = true;
            rotateAroundZ_radioButton.Location = new Point(100, 25);
            rotateAroundZ_radioButton.Margin = new Padding(3, 2, 3, 2);
            rotateAroundZ_radioButton.Name = "rotateAroundZ_radioButton";
            rotateAroundZ_radioButton.Size = new Size(39, 24);
            rotateAroundZ_radioButton.TabIndex = 12;
            rotateAroundZ_radioButton.Text = "Z";
            rotateAroundZ_radioButton.UseVisualStyleBackColor = true;
            rotateAroundZ_radioButton.CheckedChanged += rotateAroundZ_radioButton_CheckedChanged;
            // 
            // rotateAroundY_radioButton
            // 
            rotateAroundY_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rotateAroundY_radioButton.AutoSize = true;
            rotateAroundY_radioButton.Location = new Point(56, 25);
            rotateAroundY_radioButton.Margin = new Padding(3, 2, 3, 2);
            rotateAroundY_radioButton.Name = "rotateAroundY_radioButton";
            rotateAroundY_radioButton.Size = new Size(38, 24);
            rotateAroundY_radioButton.TabIndex = 11;
            rotateAroundY_radioButton.Text = "Y";
            rotateAroundY_radioButton.UseVisualStyleBackColor = true;
            rotateAroundY_radioButton.CheckedChanged += rotateAroundY_radioButton_CheckedChanged;
            // 
            // rotateAroundX_radioButton
            // 
            rotateAroundX_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rotateAroundX_radioButton.AutoSize = true;
            rotateAroundX_radioButton.Location = new Point(11, 25);
            rotateAroundX_radioButton.Margin = new Padding(3, 2, 3, 2);
            rotateAroundX_radioButton.Name = "rotateAroundX_radioButton";
            rotateAroundX_radioButton.Size = new Size(39, 24);
            rotateAroundX_radioButton.TabIndex = 10;
            rotateAroundX_radioButton.Text = "X";
            rotateAroundX_radioButton.UseVisualStyleBackColor = true;
            rotateAroundX_radioButton.CheckedChanged += rotateAroundX_radioButton_CheckedChanged;
            // 
            // translate_groupBox
            // 
            translate_groupBox.Controls.Add(translateAroundZ_radioButton);
            translate_groupBox.Controls.Add(translateAboutX_radioButton);
            translate_groupBox.Controls.Add(translateAboutY_radioButton);
            translate_groupBox.Location = new Point(6, 179);
            translate_groupBox.Name = "translate_groupBox";
            translate_groupBox.Size = new Size(350, 74);
            translate_groupBox.TabIndex = 41;
            translate_groupBox.TabStop = false;
            translate_groupBox.Text = "Смещение";
            // 
            // translateAroundZ_radioButton
            // 
            translateAroundZ_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            translateAroundZ_radioButton.AutoSize = true;
            translateAroundZ_radioButton.Location = new Point(148, 25);
            translateAroundZ_radioButton.Margin = new Padding(3, 2, 3, 2);
            translateAroundZ_radioButton.Name = "translateAroundZ_radioButton";
            translateAroundZ_radioButton.Size = new Size(63, 24);
            translateAroundZ_radioButton.TabIndex = 44;
            translateAroundZ_radioButton.Text = "По Z";
            translateAroundZ_radioButton.UseVisualStyleBackColor = true;
            translateAroundZ_radioButton.CheckedChanged += translateAroundZ_radioButton_CheckedChanged;
            // 
            // translateAboutX_radioButton
            // 
            translateAboutX_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            translateAboutX_radioButton.AutoSize = true;
            translateAboutX_radioButton.Location = new Point(11, 25);
            translateAboutX_radioButton.Margin = new Padding(3, 2, 3, 2);
            translateAboutX_radioButton.Name = "translateAboutX_radioButton";
            translateAboutX_radioButton.Size = new Size(63, 24);
            translateAboutX_radioButton.TabIndex = 42;
            translateAboutX_radioButton.Text = "По X";
            translateAboutX_radioButton.UseVisualStyleBackColor = true;
            translateAboutX_radioButton.CheckedChanged += translateAboutX_radioButton_CheckedChanged;
            // 
            // translateAboutY_radioButton
            // 
            translateAboutY_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            translateAboutY_radioButton.AutoSize = true;
            translateAboutY_radioButton.Location = new Point(80, 25);
            translateAboutY_radioButton.Margin = new Padding(3, 2, 3, 2);
            translateAboutY_radioButton.Name = "translateAboutY_radioButton";
            translateAboutY_radioButton.Size = new Size(62, 24);
            translateAboutY_radioButton.TabIndex = 43;
            translateAboutY_radioButton.Text = "По Y";
            translateAboutY_radioButton.UseVisualStyleBackColor = true;
            translateAboutY_radioButton.CheckedChanged += translateAboutY_radioButton_CheckedChanged;
            // 
            // reflect_groupBox
            // 
            reflect_groupBox.Controls.Add(refclectYZ_button);
            reflect_groupBox.Controls.Add(refclectXY_button);
            reflect_groupBox.Controls.Add(refclectXZ_button);
            reflect_groupBox.Location = new Point(6, 259);
            reflect_groupBox.Name = "reflect_groupBox";
            reflect_groupBox.Size = new Size(350, 74);
            reflect_groupBox.TabIndex = 42;
            reflect_groupBox.TabStop = false;
            reflect_groupBox.Text = "Отражение";
            // 
            // refclectYZ_button
            // 
            refclectYZ_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refclectYZ_button.Location = new Point(159, 28);
            refclectYZ_button.Margin = new Padding(4, 5, 4, 5);
            refclectYZ_button.Name = "refclectYZ_button";
            refclectYZ_button.Size = new Size(66, 35);
            refclectYZ_button.TabIndex = 47;
            refclectYZ_button.Text = "По YZ";
            refclectYZ_button.UseVisualStyleBackColor = true;
            // 
            // refclectXY_button
            // 
            refclectXY_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refclectXY_button.Location = new Point(11, 28);
            refclectXY_button.Margin = new Padding(4, 5, 4, 5);
            refclectXY_button.Name = "refclectXY_button";
            refclectXY_button.Size = new Size(66, 35);
            refclectXY_button.TabIndex = 45;
            refclectXY_button.Text = "По XY";
            refclectXY_button.UseVisualStyleBackColor = true;
            // 
            // refclectXZ_button
            // 
            refclectXZ_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refclectXZ_button.Location = new Point(85, 28);
            refclectXZ_button.Margin = new Padding(4, 5, 4, 5);
            refclectXZ_button.Name = "refclectXZ_button";
            refclectXZ_button.Size = new Size(66, 35);
            refclectXZ_button.TabIndex = 46;
            refclectXZ_button.Text = "По XZ";
            refclectXZ_button.UseVisualStyleBackColor = true;
            // 
            // rotateAboutLine_groupBox
            // 
            rotateAboutLine_groupBox.Controls.Add(lineEndZNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(label2);
            rotateAboutLine_groupBox.Controls.Add(label7);
            rotateAboutLine_groupBox.Controls.Add(label5);
            rotateAboutLine_groupBox.Controls.Add(label10);
            rotateAboutLine_groupBox.Controls.Add(lineStartZNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(label13);
            rotateAboutLine_groupBox.Controls.Add(label3);
            rotateAboutLine_groupBox.Controls.Add(lineVecZNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(lineStartYNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(label11);
            rotateAboutLine_groupBox.Controls.Add(label6);
            rotateAboutLine_groupBox.Controls.Add(lineEndXNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(rotateAroundLine_radioButton);
            rotateAboutLine_groupBox.Controls.Add(label8);
            rotateAboutLine_groupBox.Controls.Add(label4);
            rotateAboutLine_groupBox.Controls.Add(lineEndYNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(lineVecXNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(label9);
            rotateAboutLine_groupBox.Controls.Add(label12);
            rotateAboutLine_groupBox.Controls.Add(lineStartXNumericUpDown);
            rotateAboutLine_groupBox.Controls.Add(lineVecYNumericUpDown);
            rotateAboutLine_groupBox.Location = new Point(6, 431);
            rotateAboutLine_groupBox.Name = "rotateAboutLine_groupBox";
            rotateAboutLine_groupBox.Size = new Size(350, 276);
            rotateAboutLine_groupBox.TabIndex = 44;
            rotateAboutLine_groupBox.TabStop = false;
            rotateAboutLine_groupBox.Text = "Поворот по прямой";
            // 
            // lineEndZNumericUpDown
            // 
            lineEndZNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineEndZNumericUpDown.DecimalPlaces = 2;
            lineEndZNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineEndZNumericUpDown.Location = new Point(214, 177);
            lineEndZNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineEndZNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineEndZNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineEndZNumericUpDown.Name = "lineEndZNumericUpDown";
            lineEndZNumericUpDown.Size = new Size(61, 27);
            lineEndZNumericUpDown.TabIndex = 66;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(7, 33);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 45;
            label2.Text = "Координаты точки A";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(182, 123);
            label7.Name = "label7";
            label7.Size = new Size(21, 20);
            label7.TabIndex = 59;
            label7.Text = "Z:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(98, 64);
            label5.Name = "label5";
            label5.Size = new Size(20, 20);
            label5.TabIndex = 51;
            label5.Text = "Y:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(186, 181);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 65;
            label10.Text = "Z:";
            // 
            // lineStartZNumericUpDown
            // 
            lineStartZNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineStartZNumericUpDown.DecimalPlaces = 2;
            lineStartZNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineStartZNumericUpDown.Location = new Point(206, 62);
            lineStartZNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineStartZNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineStartZNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineStartZNumericUpDown.Name = "lineStartZNumericUpDown";
            lineStartZNumericUpDown.Size = new Size(61, 27);
            lineStartZNumericUpDown.TabIndex = 52;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(11, 154);
            label13.Name = "label13";
            label13.Size = new Size(152, 20);
            label13.TabIndex = 60;
            label13.Text = "Координаты точки B";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(7, 97);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 46;
            label3.Text = "Координаты вектора";
            // 
            // lineVecZNumericUpDown
            // 
            lineVecZNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineVecZNumericUpDown.DecimalPlaces = 2;
            lineVecZNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineVecZNumericUpDown.Location = new Point(206, 121);
            lineVecZNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineVecZNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineVecZNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineVecZNumericUpDown.Name = "lineVecZNumericUpDown";
            lineVecZNumericUpDown.Size = new Size(61, 27);
            lineVecZNumericUpDown.TabIndex = 58;
            // 
            // lineStartYNumericUpDown
            // 
            lineStartYNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineStartYNumericUpDown.DecimalPlaces = 2;
            lineStartYNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineStartYNumericUpDown.Location = new Point(122, 62);
            lineStartYNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineStartYNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineStartYNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineStartYNumericUpDown.Name = "lineStartYNumericUpDown";
            lineStartYNumericUpDown.Size = new Size(61, 27);
            lineStartYNumericUpDown.TabIndex = 50;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(102, 181);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 64;
            label11.Text = "Y:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(182, 64);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 53;
            label6.Text = "Z:";
            // 
            // lineEndXNumericUpDown
            // 
            lineEndXNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineEndXNumericUpDown.DecimalPlaces = 2;
            lineEndXNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineEndXNumericUpDown.Location = new Point(35, 177);
            lineEndXNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineEndXNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineEndXNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineEndXNumericUpDown.Name = "lineEndXNumericUpDown";
            lineEndXNumericUpDown.Size = new Size(61, 27);
            lineEndXNumericUpDown.TabIndex = 61;
            // 
            // rotateAroundLine_radioButton
            // 
            rotateAroundLine_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rotateAroundLine_radioButton.AutoSize = true;
            rotateAroundLine_radioButton.Location = new Point(11, 224);
            rotateAroundLine_radioButton.Margin = new Padding(3, 2, 3, 2);
            rotateAroundLine_radioButton.Name = "rotateAroundLine_radioButton";
            rotateAroundLine_radioButton.Size = new Size(240, 24);
            rotateAroundLine_radioButton.TabIndex = 47;
            rotateAroundLine_radioButton.Text = "Поворот относительно линии";
            rotateAroundLine_radioButton.UseVisualStyleBackColor = true;
            rotateAroundLine_radioButton.CheckedChanged += rotateAroundLine_radioButton_CheckedChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(98, 123);
            label8.Name = "label8";
            label8.Size = new Size(20, 20);
            label8.TabIndex = 57;
            label8.Text = "Y:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(7, 64);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 49;
            label4.Text = "X:";
            // 
            // lineEndYNumericUpDown
            // 
            lineEndYNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineEndYNumericUpDown.DecimalPlaces = 2;
            lineEndYNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineEndYNumericUpDown.Location = new Point(126, 177);
            lineEndYNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineEndYNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineEndYNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineEndYNumericUpDown.Name = "lineEndYNumericUpDown";
            lineEndYNumericUpDown.Size = new Size(61, 27);
            lineEndYNumericUpDown.TabIndex = 63;
            // 
            // lineVecXNumericUpDown
            // 
            lineVecXNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineVecXNumericUpDown.DecimalPlaces = 2;
            lineVecXNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineVecXNumericUpDown.Location = new Point(31, 121);
            lineVecXNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineVecXNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineVecXNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineVecXNumericUpDown.Name = "lineVecXNumericUpDown";
            lineVecXNumericUpDown.Size = new Size(61, 27);
            lineVecXNumericUpDown.TabIndex = 54;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(7, 123);
            label9.Name = "label9";
            label9.Size = new Size(21, 20);
            label9.TabIndex = 55;
            label9.Text = "X:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(7, 179);
            label12.Name = "label12";
            label12.Size = new Size(21, 20);
            label12.TabIndex = 62;
            label12.Text = "X:";
            // 
            // lineStartXNumericUpDown
            // 
            lineStartXNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineStartXNumericUpDown.DecimalPlaces = 2;
            lineStartXNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineStartXNumericUpDown.Location = new Point(31, 62);
            lineStartXNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineStartXNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineStartXNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineStartXNumericUpDown.Name = "lineStartXNumericUpDown";
            lineStartXNumericUpDown.Size = new Size(61, 27);
            lineStartXNumericUpDown.TabIndex = 48;
            // 
            // lineVecYNumericUpDown
            // 
            lineVecYNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineVecYNumericUpDown.DecimalPlaces = 2;
            lineVecYNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            lineVecYNumericUpDown.Location = new Point(122, 121);
            lineVecYNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            lineVecYNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lineVecYNumericUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            lineVecYNumericUpDown.Name = "lineVecYNumericUpDown";
            lineVecYNumericUpDown.Size = new Size(61, 27);
            lineVecYNumericUpDown.TabIndex = 56;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(translate_groupBox);
            groupBox.Controls.Add(rotateAboutLine_groupBox);
            groupBox.Controls.Add(scale_groupBox);
            groupBox.Controls.Add(reflect_groupBox);
            groupBox.Controls.Add(rotateAxis_groupBox);
            groupBox.Location = new Point(3, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(380, 713);
            groupBox.TabIndex = 45;
            groupBox.TabStop = false;
            groupBox.Text = "Афинные преобразования";
            // 
            // TransformablePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "TransformablePanel";
            Size = new Size(386, 713);
            scale_groupBox.ResumeLayout(false);
            scale_groupBox.PerformLayout();
            rotateAxis_groupBox.ResumeLayout(false);
            rotateAxis_groupBox.PerformLayout();
            translate_groupBox.ResumeLayout(false);
            translate_groupBox.PerformLayout();
            reflect_groupBox.ResumeLayout(false);
            rotateAboutLine_groupBox.ResumeLayout(false);
            rotateAboutLine_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lineEndZNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineStartZNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineVecZNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineStartYNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineEndXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineEndYNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineVecXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineStartXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineVecYNumericUpDown).EndInit();
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RadioButton scaleAroundZ_radioButton;
        private RadioButton scaleAroundY_radioButton;
        private RadioButton scaleAroundX_radioButton;
        private RadioButton scaleAroundCenter_radioButton;
        private GroupBox scale_groupBox;
        private GroupBox rotateAxis_groupBox;
        private RadioButton rotateAroundZ_radioButton;
        private RadioButton rotateAroundY_radioButton;
        private RadioButton rotateAroundX_radioButton;
        private GroupBox translate_groupBox;
        private RadioButton translateAroundZ_radioButton;
        private RadioButton translateAboutX_radioButton;
        private RadioButton translateAboutY_radioButton;
        private GroupBox reflect_groupBox;
        private Button refclectXY_button;
        private Button refclectYZ_button;
        private Button refclectXZ_button;
        private GroupBox rotateAboutLine_groupBox;
        private NumericUpDown lineEndZNumericUpDown;
        private Label label2;
        private Label label7;
        private Label label5;
        private Label label10;
        private NumericUpDown lineStartZNumericUpDown;
        private Label label13;
        private Label label3;
        private NumericUpDown lineVecZNumericUpDown;
        private NumericUpDown lineStartYNumericUpDown;
        private Label label11;
        private Label label6;
        private NumericUpDown lineEndXNumericUpDown;
        private RadioButton rotateAroundLine_radioButton;
        private Label label8;
        private Label label4;
        private NumericUpDown lineEndYNumericUpDown;
        private NumericUpDown lineVecXNumericUpDown;
        private Label label9;
        private Label label12;
        private NumericUpDown lineStartXNumericUpDown;
        private NumericUpDown lineVecYNumericUpDown;
        private GroupBox groupBox;
    }
}
