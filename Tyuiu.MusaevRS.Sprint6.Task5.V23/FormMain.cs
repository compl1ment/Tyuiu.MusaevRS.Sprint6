using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MusaevRS.Sprint6.Task5.V23.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        string path = @"C:\Users\rumu2\Source\Repos\Tyuiu.MusaevRS.Sprint6\Tyuiu.MusaevRS.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 5 выполнил студент ПКТБ 23-2 Мусаев Руслан","Сообщение");
        }
    }
}
