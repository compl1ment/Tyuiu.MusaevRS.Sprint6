
namespace Tyuiu.MusaevRS.Sprint6.Task1.V1
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
            this.groupBoxConditions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.labelInPutY = new System.Windows.Forms.Label();
            this.LabelInPutX = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxConditions.SuspendLayout();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConditions
            // 
            this.groupBoxConditions.Controls.Add(this.label1);
            this.groupBoxConditions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConditions.Name = "groupBoxConditions";
            this.groupBoxConditions.Size = new System.Drawing.Size(540, 310);
            this.groupBoxConditions.TabIndex = 0;
            this.groupBoxConditions.TabStop = false;
            this.groupBoxConditions.Tag = "";
            this.groupBoxConditions.Text = "Условие";
            this.groupBoxConditions.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Произвести табулирование f(x) на заданном диапазоне с шагом 1. Результат вывести " +
    "на TextBox";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.buttonHelp);
            this.groupBoxInPut.Controls.Add(this.buttonMain);
            this.groupBoxInPut.Controls.Add(this.labelInPutY);
            this.groupBoxInPut.Controls.Add(this.LabelInPutX);
            this.groupBoxInPut.Controls.Add(this.textBoxY);
            this.groupBoxInPut.Controls.Add(this.textBoxX);
            this.groupBoxInPut.Location = new System.Drawing.Point(21, 328);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(531, 100);
            this.groupBoxInPut.TabIndex = 1;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных:";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(301, 37);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(86, 36);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMain.Location = new System.Drawing.Point(406, 23);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(106, 64);
            this.buttonMain.TabIndex = 2;
            this.buttonMain.Text = "Выполнить";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // labelInPutY
            // 
            this.labelInPutY.AutoSize = true;
            this.labelInPutY.Location = new System.Drawing.Point(186, 30);
            this.labelInPutY.Name = "labelInPutY";
            this.labelInPutY.Size = new System.Drawing.Size(69, 13);
            this.labelInPutY.TabIndex = 0;
            this.labelInPutY.Text = "Конец шага:";
            this.labelInPutY.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelInPutX
            // 
            this.LabelInPutX.AutoSize = true;
            this.LabelInPutX.Location = new System.Drawing.Point(42, 30);
            this.LabelInPutX.Name = "LabelInPutX";
            this.LabelInPutX.Size = new System.Drawing.Size(67, 13);
            this.LabelInPutX.TabIndex = 0;
            this.LabelInPutX.Text = "Старт шага:";
            this.LabelInPutX.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(175, 46);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 2;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(26, 46);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxMain);
            this.groupBoxResult.Controls.Add(this.label2);
            this.groupBoxResult.Location = new System.Drawing.Point(570, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(218, 403);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных:";
            // 
            // textBoxMain
            // 
            this.textBoxMain.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMain.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMain.Location = new System.Drawing.Point(9, 32);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMain.Size = new System.Drawing.Size(209, 350);
            this.textBoxMain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxConditions);
            this.Name = "FormMain";
            this.Text = "Sprint 6 | Task 1 | V1 | MusaevRS";
            this.groupBoxConditions.ResumeLayout(false);
            this.groupBoxConditions.PerformLayout();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.Label LabelInPutX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelInPutY;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMain;
    }
}

