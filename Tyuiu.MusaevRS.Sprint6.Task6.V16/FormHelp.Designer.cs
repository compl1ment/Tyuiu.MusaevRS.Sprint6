
namespace Tyuiu.MusaevRS.Sprint6.Task6.V16
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Image = global::Tyuiu.MusaevRS.Sprint6.Task6.V16.Properties.Resources.resize_image_online_com_1701928794_mishkajpg_Fjwr0g43;
            this.pictureBoxAbout.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(252, 243);
            this.pictureBoxAbout.TabIndex = 0;
            this.pictureBoxAbout.TabStop = false;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout.Location = new System.Drawing.Point(283, 24);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(323, 129);
            this.textBoxAbout.TabIndex = 1;
            this.textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(458, 259);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(122, 38);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 341);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.pictureBoxAbout);
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Button buttonOk;
    }
}