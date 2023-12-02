
namespace Tyuiu.MusaevRS.Sprint6.Task2.V9
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.labelMainTwo = new System.Windows.Forms.Label();
            this.labelMainOne = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.SplineMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTextBoxColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInPut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplineMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.pictureBox1);
            this.groupBoxMain.Controls.Add(this.labelMainTwo);
            this.groupBoxMain.Controls.Add(this.labelMainOne);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(544, 273);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Условие:";
            // 
            // labelMainTwo
            // 
            this.labelMainTwo.AutoSize = true;
            this.labelMainTwo.Location = new System.Drawing.Point(23, 34);
            this.labelMainTwo.Name = "labelMainTwo";
            this.labelMainTwo.Size = new System.Drawing.Size(179, 13);
            this.labelMainTwo.TabIndex = 1;
            this.labelMainTwo.Text = "Значения занести в DataGridView.";
            // 
            // labelMainOne
            // 
            this.labelMainOne.AutoSize = true;
            this.labelMainOne.Location = new System.Drawing.Point(23, 21);
            this.labelMainOne.Name = "labelMainOne";
            this.labelMainOne.Size = new System.Drawing.Size(346, 13);
            this.labelMainOne.TabIndex = 0;
            this.labelMainOne.Text = "Произвести табулирование f(x) на заданном диапазоне с шагом 1.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.MusaevRS.Sprint6.Task2.V9.Properties.Resources._123456;
            this.pictureBox1.Location = new System.Drawing.Point(26, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 41);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.button1);
            this.groupBoxInPut.Controls.Add(this.buttonMain);
            this.groupBoxInPut.Controls.Add(this.label2);
            this.groupBoxInPut.Controls.Add(this.label1);
            this.groupBoxInPut.Controls.Add(this.textBoxY);
            this.groupBoxInPut.Controls.Add(this.textBoxX);
            this.groupBoxInPut.Location = new System.Drawing.Point(14, 291);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(542, 147);
            this.groupBoxInPut.TabIndex = 1;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(24, 70);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(162, 70);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Конец шага:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Старт шага:";
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.Color.Green;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Location = new System.Drawing.Point(406, 50);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(107, 59);
            this.buttonMain.TabIndex = 4;
            this.buttonMain.Text = "Выполнить";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            this.buttonMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMain_MouseDown);
            this.buttonMain.MouseEnter += new System.EventHandler(this.buttonMain_MouseEnter);
            this.buttonMain.MouseLeave += new System.EventHandler(this.buttonMain_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(306, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SplineMain);
            this.groupBox1.Controls.Add(this.dataGridViewMain);
            this.groupBox1.Location = new System.Drawing.Point(562, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных:";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnX,
            this.dataGridViewTextBoxColumnf});
            this.dataGridViewMain.Location = new System.Drawing.Point(17, 19);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.Size = new System.Drawing.Size(117, 369);
            this.dataGridViewMain.TabIndex = 3;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // SplineMain
            // 
            chartArea5.Name = "ChartArea1";
            this.SplineMain.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.SplineMain.Legends.Add(legend5);
            this.SplineMain.Location = new System.Drawing.Point(140, 21);
            this.SplineMain.Name = "SplineMain";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "График функции f(x)";
            this.SplineMain.Series.Add(series5);
            this.SplineMain.Size = new System.Drawing.Size(300, 300);
            this.SplineMain.TabIndex = 4;
            this.SplineMain.Text = "Вывод данных:";
            this.SplineMain.Click += new System.EventHandler(this.SplineMain_Click);
            // 
            // dataGridViewTextBoxColumnX
            // 
            this.dataGridViewTextBoxColumnX.HeaderText = "X";
            this.dataGridViewTextBoxColumnX.Name = "dataGridViewTextBoxColumnX";
            this.dataGridViewTextBoxColumnX.Width = 50;
            // 
            // dataGridViewTextBoxColumnf
            // 
            this.dataGridViewTextBoxColumnf.HeaderText = "f(x)";
            this.dataGridViewTextBoxColumnf.Name = "dataGridViewTextBoxColumnf";
            this.dataGridViewTextBoxColumnf.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxMain);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplineMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label labelMainTwo;
        private System.Windows.Forms.Label labelMainOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart SplineMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnf;
    }
}

