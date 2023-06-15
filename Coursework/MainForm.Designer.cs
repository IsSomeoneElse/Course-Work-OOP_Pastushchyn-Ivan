namespace Coursework
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.matrixListView = new System.Windows.Forms.ListView();
            this.SetTableSizeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.matrixListView3 = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FindDeterminantButton = new System.Windows.Forms.Button();
            this.MatrixTransposeButton = new System.Windows.Forms.Button();
            this.matrixNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.matrixListView2 = new System.Windows.Forms.ListView();
            this.MatrixMultiplyButton = new System.Windows.Forms.Button();
            this.MatrixAddButton = new System.Windows.Forms.Button();
            this.matrixBNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matrixANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.columnsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.indexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.RestartProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.CleanListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixNumericUpDown)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixBNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixANumericUpDown)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexNumericUpDown)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 27);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(373, 180);
            this.dataGridView.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(239, 78);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Додати матрицю";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(355, 78);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(128, 23);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Відсортувати масив";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.Location = new System.Drawing.Point(139, 52);
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.SizeNumericUpDown.TabIndex = 5;
            // 
            // matrixListView
            // 
            this.matrixListView.HideSelection = false;
            this.matrixListView.Location = new System.Drawing.Point(7, 27);
            this.matrixListView.Name = "matrixListView";
            this.matrixListView.Size = new System.Drawing.Size(373, 180);
            this.matrixListView.TabIndex = 8;
            this.matrixListView.TileSize = new System.Drawing.Size(10, 10);
            this.matrixListView.UseCompatibleStateImageBehavior = false;
            // 
            // SetTableSizeButton
            // 
            this.SetTableSizeButton.Location = new System.Drawing.Point(189, 49);
            this.SetTableSizeButton.Name = "SetTableSizeButton";
            this.SetTableSizeButton.Size = new System.Drawing.Size(160, 23);
            this.SetTableSizeButton.TabIndex = 9;
            this.SetTableSizeButton.Text = "Встановити розмір матриці";
            this.SetTableSizeButton.UseVisualStyleBackColor = true;
            this.SetTableSizeButton.Click += new System.EventHandler(this.SetTableSizeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введіть розмір матриці:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Додати нову матрицю/відсортувати масив:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(507, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 216);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введення масиву";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.matrixListView);
            this.groupBox2.Location = new System.Drawing.Point(507, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 216);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введений масив матриць";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SizeNumericUpDown);
            this.groupBox3.Controls.Add(this.SetTableSizeButton);
            this.groupBox3.Controls.Add(this.SortButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.AddButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 123);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основні функції введення";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(437, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Введіть розмір матриці та нажміть Встановити розмір матриці для початку введення";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 415);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дії з матрицями";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelResult);
            this.groupBox6.Controls.Add(this.matrixListView3);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.FindDeterminantButton);
            this.groupBox6.Controls.Add(this.MatrixTransposeButton);
            this.groupBox6.Controls.Add(this.matrixNumericUpDown);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(9, 239);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(474, 170);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Транспонування та пошук визначника";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(352, 85);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(41, 13);
            this.labelResult.TabIndex = 22;
            this.labelResult.Text = "label11";
            // 
            // matrixListView3
            // 
            this.matrixListView3.HideSelection = false;
            this.matrixListView3.Location = new System.Drawing.Point(6, 49);
            this.matrixListView3.Name = "matrixListView3";
            this.matrixListView3.Size = new System.Drawing.Size(151, 115);
            this.matrixListView3.TabIndex = 19;
            this.matrixListView3.TileSize = new System.Drawing.Size(10, 10);
            this.matrixListView3.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Визначник обраної матриці:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Результат транспонування:";
            // 
            // FindDeterminantButton
            // 
            this.FindDeterminantButton.Location = new System.Drawing.Point(173, 114);
            this.FindDeterminantButton.Name = "FindDeterminantButton";
            this.FindDeterminantButton.Size = new System.Drawing.Size(109, 23);
            this.FindDeterminantButton.TabIndex = 20;
            this.FindDeterminantButton.Text = "Знайти визначник";
            this.FindDeterminantButton.UseVisualStyleBackColor = true;
            this.FindDeterminantButton.Click += new System.EventHandler(this.FindDeterminantButton_Click);
            // 
            // MatrixTransposeButton
            // 
            this.MatrixTransposeButton.Location = new System.Drawing.Point(173, 85);
            this.MatrixTransposeButton.Name = "MatrixTransposeButton";
            this.MatrixTransposeButton.Size = new System.Drawing.Size(109, 23);
            this.MatrixTransposeButton.TabIndex = 19;
            this.MatrixTransposeButton.Text = "Транспонувати";
            this.MatrixTransposeButton.UseVisualStyleBackColor = true;
            this.MatrixTransposeButton.Click += new System.EventHandler(this.MatrixTransposeButton_Click);
            // 
            // matrixNumericUpDown
            // 
            this.matrixNumericUpDown.Location = new System.Drawing.Point(209, 51);
            this.matrixNumericUpDown.Name = "matrixNumericUpDown";
            this.matrixNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.matrixNumericUpDown.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер матриці:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.matrixListView2);
            this.groupBox5.Controls.Add(this.MatrixMultiplyButton);
            this.groupBox5.Controls.Add(this.MatrixAddButton);
            this.groupBox5.Controls.Add(this.matrixBNumericUpDown);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.matrixANumericUpDown);
            this.groupBox5.Location = new System.Drawing.Point(9, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(474, 170);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Додавання/множення";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Результат:";
            // 
            // matrixListView2
            // 
            this.matrixListView2.HideSelection = false;
            this.matrixListView2.Location = new System.Drawing.Point(250, 42);
            this.matrixListView2.Name = "matrixListView2";
            this.matrixListView2.Size = new System.Drawing.Size(213, 118);
            this.matrixListView2.TabIndex = 9;
            this.matrixListView2.TileSize = new System.Drawing.Size(10, 10);
            this.matrixListView2.UseCompatibleStateImageBehavior = false;
            // 
            // MatrixMultiplyButton
            // 
            this.MatrixMultiplyButton.Location = new System.Drawing.Point(31, 128);
            this.MatrixMultiplyButton.Name = "MatrixMultiplyButton";
            this.MatrixMultiplyButton.Size = new System.Drawing.Size(110, 23);
            this.MatrixMultiplyButton.TabIndex = 17;
            this.MatrixMultiplyButton.Text = "Помножити";
            this.MatrixMultiplyButton.UseVisualStyleBackColor = true;
            this.MatrixMultiplyButton.Click += new System.EventHandler(this.MatrixMultiplyButton_Click);
            // 
            // MatrixAddButton
            // 
            this.MatrixAddButton.Location = new System.Drawing.Point(31, 99);
            this.MatrixAddButton.Name = "MatrixAddButton";
            this.MatrixAddButton.Size = new System.Drawing.Size(110, 23);
            this.MatrixAddButton.TabIndex = 14;
            this.MatrixAddButton.Text = "Додати";
            this.MatrixAddButton.UseVisualStyleBackColor = true;
            this.MatrixAddButton.Click += new System.EventHandler(this.MatrixAddButton_Click);
            // 
            // matrixBNumericUpDown
            // 
            this.matrixBNumericUpDown.Location = new System.Drawing.Point(136, 61);
            this.matrixBNumericUpDown.Name = "matrixBNumericUpDown";
            this.matrixBNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.matrixBNumericUpDown.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Номер другої матриці:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Номер першої матриці:";
            // 
            // matrixANumericUpDown
            // 
            this.matrixANumericUpDown.Location = new System.Drawing.Point(136, 29);
            this.matrixANumericUpDown.Name = "matrixANumericUpDown";
            this.matrixANumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.matrixANumericUpDown.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Для роботи з певними матрицями масиву, зазначеного у блоці Введений масив,\r\nпотрі" +
    "бно ввести їх індекси у масиві (порядкові номери, починаючи з нуля)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.ValueTextBox);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.EditButton);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.columnsNumericUpDown);
            this.groupBox7.Controls.Add(this.rowNumericUpDown);
            this.groupBox7.Controls.Add(this.indexNumericUpDown);
            this.groupBox7.Location = new System.Drawing.Point(507, 473);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(388, 99);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Заміна елементів матриць";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(122, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Стовпець:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Рядок:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(303, 19);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(37, 20);
            this.ValueTextBox.TabIndex = 29;
            this.ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Введіть координати:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Номер матриці:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(260, 61);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(109, 23);
            this.EditButton.TabIndex = 23;
            this.EditButton.Text = "Редагувати";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Замінити елемент на:";
            // 
            // columnsNumericUpDown
            // 
            this.columnsNumericUpDown.Location = new System.Drawing.Point(186, 69);
            this.columnsNumericUpDown.Name = "columnsNumericUpDown";
            this.columnsNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.columnsNumericUpDown.TabIndex = 25;
            // 
            // rowNumericUpDown
            // 
            this.rowNumericUpDown.Location = new System.Drawing.Point(186, 43);
            this.rowNumericUpDown.Name = "rowNumericUpDown";
            this.rowNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.rowNumericUpDown.TabIndex = 24;
            // 
            // indexNumericUpDown
            // 
            this.indexNumericUpDown.Location = new System.Drawing.Point(98, 20);
            this.indexNumericUpDown.Name = "indexNumericUpDown";
            this.indexNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.indexNumericUpDown.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(907, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartProgramMenuItem,
            this.ExitProgramMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // RestartProgramMenuItem
            // 
            this.RestartProgramMenuItem.Name = "RestartProgramMenuItem";
            this.RestartProgramMenuItem.Size = new System.Drawing.Size(138, 22);
            this.RestartProgramMenuItem.Text = "Перезапуск";
            this.RestartProgramMenuItem.Click += new System.EventHandler(this.RestartProgramMenuItem_Click);
            // 
            // ExitProgramMenuItem
            // 
            this.ExitProgramMenuItem.Name = "ExitProgramMenuItem";
            this.ExitProgramMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ExitProgramMenuItem.Text = "Вийти";
            this.ExitProgramMenuItem.Click += new System.EventHandler(this.ExitProgramMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.AutoToolTip = false;
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CleanListMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton3.Text = "Правка";
            // 
            // CleanListMenuItem
            // 
            this.CleanListMenuItem.Name = "CleanListMenuItem";
            this.CleanListMenuItem.Size = new System.Drawing.Size(218, 22);
            this.CleanListMenuItem.Text = "Очистити введений масив";
            this.CleanListMenuItem.Click += new System.EventHandler(this.CleanListMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoToolTip = false;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(53, 22);
            this.toolStripDropDownButton2.Text = "Довідка";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AboutMenuItem.Text = "Про програму";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 582);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Робота з масивом матриць";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixNumericUpDown)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixBNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixANumericUpDown)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexNumericUpDown)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
        private System.Windows.Forms.ListView matrixListView;
        private System.Windows.Forms.Button SetTableSizeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown matrixBNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown matrixANumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView matrixListView2;
        private System.Windows.Forms.Button MatrixMultiplyButton;
        private System.Windows.Forms.Button MatrixAddButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button FindDeterminantButton;
        private System.Windows.Forms.Button MatrixTransposeButton;
        private System.Windows.Forms.NumericUpDown matrixNumericUpDown;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListView matrixListView3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.NumericUpDown columnsNumericUpDown;
        private System.Windows.Forms.NumericUpDown rowNumericUpDown;
        private System.Windows.Forms.NumericUpDown indexNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem RestartProgramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitProgramMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem CleanListMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
    }
}

