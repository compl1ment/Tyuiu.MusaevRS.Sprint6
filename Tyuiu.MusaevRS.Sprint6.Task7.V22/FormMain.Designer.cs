
namespace Tyuiu.MusaevRS.Sprint6.Task7.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut = new System.Windows.Forms.DataGridView();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask = new System.Windows.Forms.SaveFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMain.SuspendLayout();
            this.groupBoxInPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut)).BeginInit();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.textBox1);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 72);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(642, 85);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(608, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.dataGridViewInPut);
            this.groupBoxInPut.Location = new System.Drawing.Point(12, 163);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(330, 257);
            this.groupBoxInPut.TabIndex = 1;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод:";
            // 
            // dataGridViewInPut
            // 
            this.dataGridViewInPut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut.ColumnHeadersVisible = false;
            this.dataGridViewInPut.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewInPut.Name = "dataGridViewInPut";
            this.dataGridViewInPut.RowHeadersVisible = false;
            this.dataGridViewInPut.Size = new System.Drawing.Size(318, 232);
            this.dataGridViewInPut.TabIndex = 0;
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.dataGridViewOutPut);
            this.groupBoxOutPut.Location = new System.Drawing.Point(411, 163);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(296, 257);
            this.groupBoxOutPut.TabIndex = 1;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод:";
            // 
            // dataGridViewOutPut
            // 
            this.dataGridViewOutPut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut.ColumnHeadersVisible = false;
            this.dataGridViewOutPut.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOutPut.Name = "dataGridViewOutPut";
            this.dataGridViewOutPut.RowHeadersVisible = false;
            this.dataGridViewOutPut.Size = new System.Drawing.Size(284, 232);
            this.dataGridViewOutPut.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Image = global::Tyuiu.MusaevRS.Sprint6.Task7.V22.Properties.Resources.help;
            this.buttonHelp.Location = new System.Drawing.Point(694, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(94, 54);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Tyuiu.MusaevRS.Sprint6.Task7.V22.Properties.Resources.page_save;
            this.buttonSave.Location = new System.Drawing.Point(234, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 54);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Image = global::Tyuiu.MusaevRS.Sprint6.Task7.V22.Properties.Resources.page_go;
            this.buttonDone.Location = new System.Drawing.Point(134, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(94, 54);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = global::Tyuiu.MusaevRS.Sprint6.Task7.V22.Properties.Resources.folder_page;
            this.buttonOpenFile.Location = new System.Drawing.Point(34, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(94, 54);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTipMain
            // 
            this.toolTipMain.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipMain.IsBalloon = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxMain);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxInPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut)).EndInit();
            this.groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.DataGridView dataGridViewInPut;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.DataGridView dataGridViewOutPut;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

