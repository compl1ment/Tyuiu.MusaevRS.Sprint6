using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MusaevRS.Sprint6.Task4.V26.Lib;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint6.Task4.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttondone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartMain.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartMain.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPut.Text = "";
                chartMain.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartMain.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPut.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutPut.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n  Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 V26 выполнил студент ПКТБ 23-2 Мусаев Руслан", "Сообщение");
        }
    }
}
