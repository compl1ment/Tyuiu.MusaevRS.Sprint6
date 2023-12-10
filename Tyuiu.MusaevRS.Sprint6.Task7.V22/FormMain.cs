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
using Tyuiu.MusaevRS.Sprint6.Task7.V22.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task7.V22
{

    public partial class FormMain : Form
    {
        static string openFilePath;
        static int rows;
        static int colums;
        DataService ds = new DataService();
          
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            dataGridViewInPut.ColumnCount = 50;
            dataGridViewOutPut.ColumnCount = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] valueArray = ds.GetMatrix(openFilePath);


            dataGridViewInPut.RowCount = valueArray.GetLength(0);
            dataGridViewInPut.ColumnCount = valueArray.GetLength(1);
            dataGridViewOutPut.ColumnCount = valueArray.GetLength(0);
            dataGridViewOutPut.RowCount = valueArray.GetLength(1);

            for (int i = 0; i < colums;i++)
            {
                dataGridViewInPut.Columns[i].Width = 25;
                dataGridViewOutPut.Columns[i].Width = 25;
            }

            for (int r = 0; r < valueArray.GetLength(0); r++)
            {
                for (int c = 0; c < valueArray.GetLength(1); c++)
                {
                    dataGridViewInPut.Rows[r].Cells[c].Value = valueArray[r, c];
                }
            }
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string path = openFilePath;
            int[,] valueArray = ds.GetMatrix(path);
            for (int r = 0; r < dataGridViewOutPut.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewOutPut.ColumnCount; c++)
                {
                    if ((c == 5) && (valueArray[r, c] > 0) && (valueArray[r, c] % 2 == 0))
                    {
                        dataGridViewOutPut.Rows[r].Cells[c].Value = 111;
                    }
                    else
                    {
                        dataGridViewOutPut.Rows[r].Cells[c].Value = valueArray[r, c];
                    }
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();
            string path = saveFileDialogTask.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut.RowCount;
            int columns = dataGridViewOutPut.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
