using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MusaevRS.Sprint6.Task2.V9.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task2.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 2 выполнил студент ТИУ ПКТБ-23-2 Мусаев Руслан","Сообщение");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int StartStep = Convert.ToInt32(textBoxX.Text);
                int StopStep = Convert.ToInt32(textBoxY.Text);

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);

                this.SplineMain.Titles.Add("График функции f(x)");

                this.SplineMain.ChartAreas[0].AxisX.Title = "Ось X";
                this.SplineMain.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewMain.Rows.Add(Convert.ToString(StartStep), Convert.ToString(valueArray[i]));
                    this.SplineMain.Series[0].Points.AddXY(StartStep, valueArray[i]);
                    StartStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SplineMain_Click(object sender, EventArgs e)
        {

        }

        private void buttonMain_MouseDown(object sender, MouseEventArgs e)
        {
            buttonMain.BackColor = Color.Blue;
        }

        private void buttonMain_MouseEnter(object sender, EventArgs e)
        {
            buttonMain.BackColor = Color.Red;
        }

        private void buttonMain_MouseLeave(object sender, EventArgs e)
        {
            buttonMain.BackColor = Color.Green;
        }
    }
}
