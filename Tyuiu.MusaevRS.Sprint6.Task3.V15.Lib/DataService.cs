using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusaevRS.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            int ValueMax = 0;
            List<int> spisok = new List<int>();           

            int count = 0;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = colums; colums == 3;)
                {
                    spisok.Add(matrix[i, j]);
                }
            }


            
             var orderedNumbers = from i in spisok
                                 orderby i ascending
                                 select i;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 3; colums == 3;)
                {
                    matrix[i, j] = spisok[count];
                    count++;
                }
            }
            return matrix;
        }                                                
    }
}
