
namespace Tyuiu.MusaevRS.Sprint6.Task0.V28
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.LabelConditions = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxInPut = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelOut = new System.Windows.Forms.Label();
            this.buttonMain = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.pictureBoxMain);
            this.groupBoxMain.Controls.Add(this.LabelConditions);
            this.groupBoxMain.Location = new System.Drawing.Point(29, 30);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(731, 228);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Условие:";
            this.groupBoxMain.Enter += new System.EventHandler(this.groupBoxMain_Enter);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = global::Tyuiu.MusaevRS.Sprint6.Task0.V28.Properties.Resources._123;
            this.pictureBoxMain.Location = new System.Drawing.Point(280, 19);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(445, 50);
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // LabelConditions
            // 
            this.LabelConditions.AutoSize = true;
            this.LabelConditions.Location = new System.Drawing.Point(6, 16);
            this.LabelConditions.Name = "LabelConditions";
            this.LabelConditions.Size = new System.Drawing.Size(225, 13);
            this.LabelConditions.TabIndex = 0;
            this.LabelConditions.Text = "Дано выражение, вычислить его значение";
            this.LabelConditions.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.labelX);
            this.groupBoxInPut.Controls.Add(this.textBoxInPut);
            this.groupBoxInPut.Location = new System.Drawing.Point(29, 264);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(231, 111);
            this.groupBoxInPut.TabIndex = 2;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(34, 36);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(82, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Переменная x:";
            // 
            // textBoxInPut
            // 
            this.textBoxInPut.Location = new System.Drawing.Point(37, 53);
            this.textBoxInPut.Name = "textBoxInPut";
            this.textBoxInPut.Size = new System.Drawing.Size(100, 20);
            this.textBoxInPut.TabIndex = 0;
            this.textBoxInPut.TextChanged += new System.EventHandler(this.textBoxInPut_TextChanged);
            this.textBoxInPut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInPut_KeyPress);
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.LabelOut);
            this.groupBoxOutPut.Controls.Add(this.TextBoxResult);
            this.groupBoxOutPut.Location = new System.Drawing.Point(288, 264);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(298, 111);
            this.groupBoxOutPut.TabIndex = 3;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных:";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(54, 52);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResult.TabIndex = 0;
            this.TextBoxResult.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LabelOut
            // 
            this.LabelOut.AutoSize = true;
            this.LabelOut.Location = new System.Drawing.Point(51, 36);
            this.LabelOut.Name = "LabelOut";
            this.LabelOut.Size = new System.Drawing.Size(119, 13);
            this.LabelOut.TabIndex = 1;
            this.LabelOut.Text = "Значение выражения:";
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(623, 281);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(131, 56);
            this.buttonMain.TabIndex = 4;
            this.buttonMain.Text = "Вычислить";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonHelp
            // 
            this.buttonHelp.AccessibleName = "";
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(638, 343);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(98, 45);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Tag = "";
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 0 | MusaevRS | V28";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label LabelConditions;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.TextBox textBoxInPut;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.Label LabelOut;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button buttonHelp;
    }
}

