using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MusaevRS.Sprint6.Task3.V15.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelMain_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            int[,] mtrx = new int[5, 5] { { 33, 28, 31, 19, 4 }, { 1, 32, -3, -17, -12 },{ 24, -19, 26, 31, -3 }, { 30, -16, 29,28, 8},{ 30, 5, 11, 7, 32 } };
            mtrx = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            dataGridViewMain.ColumnCount = colums;
            dataGridViewMain.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewMain.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMain.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
