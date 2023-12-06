
namespace Tyuiu.MusaevRS.Sprint6.Task5.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.dataGridViewNums = new System.Windows.Forms.DataGridView();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.textBoxMain);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(257, 95);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Условие:";
            // 
            // textBoxMain
            // 
            this.textBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMain.Location = new System.Drawing.Point(7, 17);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.Size = new System.Drawing.Size(245, 70);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.Text = "Дан список из чисел. \r\nВывести все числа, меньше 0.\r\nПостроить диаграмму по этим " +
    "значениям.\r\nУ вещественных значений округлить до трёх знаков после запятой.";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewNums);
            this.groupBoxResult.Location = new System.Drawing.Point(13, 113);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(256, 325);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных:";
            // 
            // chartDiag
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiag.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDiag.Legends.Add(legend4);
            this.chartDiag.Location = new System.Drawing.Point(291, 119);
            this.chartDiag.Name = "chartDiag";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "SeriesMain";
            this.chartDiag.Series.Add(series4);
            this.chartDiag.Size = new System.Drawing.Size(421, 319);
            this.chartDiag.TabIndex = 2;
            this.chartDiag.Text = "chart";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDone.Location = new System.Drawing.Point(327, 29);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(105, 50);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Blue;
            this.buttonOpen.Location = new System.Drawing.Point(483, 29);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(105, 50);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp.Location = new System.Drawing.Point(638, 29);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(105, 50);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // dataGridViewNums
            // 
            this.dataGridViewNums.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums.ColumnHeadersVisible = false;
            this.dataGridViewNums.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewNums.Name = "dataGridViewNums";
            this.dataGridViewNums.RowHeadersVisible = false;
            this.dataGridViewNums.Size = new System.Drawing.Size(244, 300);
            this.dataGridViewNums.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.chartDiag);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxMain);
            this.Name = "FormMain";
            this.Text = "Sprint 6 | Task 5 | MusaevRS | V23";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridView dataGridViewNums;
    }
}

