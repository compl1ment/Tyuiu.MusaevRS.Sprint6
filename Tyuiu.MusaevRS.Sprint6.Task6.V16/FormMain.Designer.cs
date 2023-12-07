
namespace Tyuiu.MusaevRS.Sprint6.Task6.V16
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
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.textBoxInPut = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.textBoxMain);
            this.groupBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMain.Location = new System.Drawing.Point(12, 78);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(666, 108);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Условие:";
            // 
            // textBoxMain
            // 
            this.textBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMain.Location = new System.Drawing.Point(6, 19);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.Size = new System.Drawing.Size(635, 77);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.Text = resources.GetString("textBoxMain.Text");
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.textBoxInPut);
            this.groupBoxInPut.Location = new System.Drawing.Point(34, 192);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(320, 246);
            this.groupBoxInPut.TabIndex = 2;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод:";
            this.groupBoxInPut.Enter += new System.EventHandler(this.groupBoxInPut_Enter);
            // 
            // textBoxInPut
            // 
            this.textBoxInPut.BackColor = System.Drawing.Color.White;
            this.textBoxInPut.Location = new System.Drawing.Point(6, 49);
            this.textBoxInPut.Multiline = true;
            this.textBoxInPut.Name = "textBoxInPut";
            this.textBoxInPut.ReadOnly = true;
            this.textBoxInPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut.Size = new System.Drawing.Size(306, 191);
            this.textBoxInPut.TabIndex = 0;
            this.textBoxInPut.TextChanged += new System.EventHandler(this.textBoxInPut_TextChanged);
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.textBoxOutPut);
            this.groupBoxOutPut.Location = new System.Drawing.Point(398, 192);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(329, 246);
            this.groupBoxOutPut.TabIndex = 2;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод:";
            this.groupBoxOutPut.Enter += new System.EventHandler(this.groupBoxInPut_Enter);
            // 
            // textBoxOutPut
            // 
            this.textBoxOutPut.BackColor = System.Drawing.Color.White;
            this.textBoxOutPut.Location = new System.Drawing.Point(6, 49);
            this.textBoxOutPut.Multiline = true;
            this.textBoxOutPut.Name = "textBoxOutPut";
            this.textBoxOutPut.ReadOnly = true;
            this.textBoxOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut.Size = new System.Drawing.Size(306, 191);
            this.textBoxOutPut.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Image = global::Tyuiu.MusaevRS.Sprint6.Task6.V16.Properties.Resources.help;
            this.buttonHelp.Location = new System.Drawing.Point(697, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(91, 60);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDone.Image = global::Tyuiu.MusaevRS.Sprint6.Task6.V16.Properties.Resources.page_go;
            this.buttonDone.Location = new System.Drawing.Point(124, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(91, 60);
            this.buttonDone.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.buttonDone, "Производит поиск в файле слов с буквой b.");
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOpenFile.Image = global::Tyuiu.MusaevRS.Sprint6.Task6.V16.Properties.Resources.folder_page;
            this.buttonOpenFile.Location = new System.Drawing.Point(18, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(80, 60);
            this.buttonOpenFile.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.buttonOpenFile, "Открыть файл\r\nВыберите нужный для обработки. ");
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.groupBoxMain);
            this.Name = "FormMain";
            this.Text = "Sprint 6 | Task 6 | MusaevRS | V16";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.TextBox textBoxInPut;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.TextBox textBoxOutPut;
    }
}

