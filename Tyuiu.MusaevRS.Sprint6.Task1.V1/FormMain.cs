using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MusaevRS.Sprint6.Task1.V1.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxX.Text);
                int StopStep = Convert.ToInt32(textBoxY.Text);

                string strLine;

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);
                textBoxMain.Text = "";
                textBoxMain.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxMain.AppendText("|    X     +    f(x)  |" + Environment.NewLine);
                textBoxMain.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 5:f2}  |", StartStep, valueArray[i]);
                    textBoxMain.AppendText(strLine + Environment.NewLine);
                    StartStep++;
                }
                textBoxMain.AppendText("+----------+----------+" + Environment.NewLine);
                
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент ТИУ группы ПКТБ 23-2 Мусаев Руслан.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
