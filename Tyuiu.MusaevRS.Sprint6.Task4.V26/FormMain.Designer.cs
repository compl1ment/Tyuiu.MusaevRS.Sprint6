
namespace Tyuiu.MusaevRS.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GroupBoxMain = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttondone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut = new System.Windows.Forms.TextBox();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBoxMain.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxMain
            // 
            this.GroupBoxMain.Controls.Add(this.textBox1);
            this.GroupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxMain.Name = "GroupBoxMain";
            this.GroupBoxMain.Size = new System.Drawing.Size(247, 107);
            this.GroupBoxMain.TabIndex = 0;
            this.GroupBoxMain.TabStop = false;
            this.GroupBoxMain.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 80);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Произвести табулирование f(x) на заданном диапазоне  [-5; 5] с шагом 1.\r\nПроизвес" +
    "ти проверку деления на ноль. \r\nПри делении на ноль вернуть значение 0. \r\nОкругли" +
    "ть до двух знаков после запятой.";
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.labelStart);
            this.groupBox.Controls.Add(this.textBoxEnd);
            this.groupBox.Controls.Add(this.textBoxStart);
            this.groupBox.Location = new System.Drawing.Point(265, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(304, 96);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ввод данных:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(15, 49);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 0;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(140, 49);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 0;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(25, 34);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(67, 13);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Старт шага:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конец шага:";
            // 
            // buttondone
            // 
            this.buttondone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttondone.Location = new System.Drawing.Point(584, 31);
            this.buttondone.Name = "buttondone";
            this.buttondone.Size = new System.Drawing.Size(87, 54);
            this.buttondone.TabIndex = 2;
            this.buttondone.Text = "Выполнить";
            this.buttondone.UseVisualStyleBackColor = false;
            this.buttondone.Click += new System.EventHandler(this.buttondone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp.Location = new System.Drawing.Point(788, 31);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(87, 54);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Blue;
            this.buttonSave.Location = new System.Drawing.Point(686, 31);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 54);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOutPut);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 293);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод:";
            // 
            // textBoxOutPut
            // 
            this.textBoxOutPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut.Multiline = true;
            this.textBoxOutPut.Name = "textBoxOutPut";
            this.textBoxOutPut.ReadOnly = true;
            this.textBoxOutPut.Size = new System.Drawing.Size(241, 274);
            this.textBoxOutPut.TabIndex = 0;
            // 
            // chartMain
            // 
            chartArea5.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartMain.Legends.Add(legend5);
            this.chartMain.Location = new System.Drawing.Point(293, 126);
            this.chartMain.Name = "chartMain";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "SeriesMain";
            this.chartMain.Series.Add(series5);
            this.chartMain.Size = new System.Drawing.Size(582, 300);
            this.chartMain.TabIndex = 4;
            title5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.ForeColor = System.Drawing.Color.Blue;
            title5.Name = "Title1";
            title5.Text = "График функции f(x)";
            this.chartMain.Titles.Add(title5);
            this.chartMain.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.chartMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttondone);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.GroupBoxMain);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FormMain";
            this.Text = "Sprint 6 | Task 4 | MusaevRS | V26";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxMain.ResumeLayout(false);
            this.GroupBoxMain.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Button buttondone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOutPut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
    }
}

