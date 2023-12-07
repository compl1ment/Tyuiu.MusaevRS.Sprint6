using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MusaevRS.Sprint6.Task6.V16.Lib;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string openFilePath;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonDone.Enabled = false;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {            
            textBoxOutPut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInPut_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
            openFilePath = openFileDialogMain.FileName;
            textBoxInPut.Text = File.ReadAllText(openFilePath);
            groupBoxInPut.Text = groupBoxInPut.Text + " " + openFileDialogMain.FileName;
            buttonDone.Enabled = true;
        }

        private void textBoxInPut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();

        }
    }
}
