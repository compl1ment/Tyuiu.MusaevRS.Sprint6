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
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            int[,] valueArray = 
            for (int i = 0; i < rows; i++)
            {
                if ((valueArray[i, 6] % 2 == 0) && (valueArray[i, 6] > 0))
                {
                    valueArray[i, 6] = 111;
                }
            }
            return valueArray;
        }        
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

            int[,] valueArray = new int[rows, colums];

            valueArray = LoadFromFileData(openFilePath);

            dataGridViewInPut.RowCount = rows;
            dataGridViewInPut.ColumnCount = colums;
            dataGridViewOutPut.ColumnCount = colums;
            dataGridViewOutPut.RowCount = rows;

            for (int i = 0; i < colums;i++)
            {
                dataGridViewInPut.Columns[i].Width = 25;
                dataGridViewOutPut.Columns[i].Width = 25;
            }

            for (int r = 0; r < 0; r++)
            {
                for (int c = 0; c > colums; c++)
                {
                    dataGridViewInPut.Rows[r].Cells[c].Value = valueArray[r, c];
                }
            }
            valueArray = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] valueArray = new int[rows, colums];
            valueArray = ds.GetMatrix(openFilePath);

            for (int r = 0; r < 0; r++)
            {
                for (int c = 0; c > colums; c++)
                {
                    dataGridViewOutPut.Rows[r].Cells[c].Value = valueArray[r, c];
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
    }
}
