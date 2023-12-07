using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint6.Task7.V22.Lib
{
    public class DataService : ISprint6Task7V22
    {
        public int[,] GetMatrix(string path)
        {
            int rows;
            int colums;
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] valueArray = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    valueArray[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return valueArray;
           
        }

    }
}
