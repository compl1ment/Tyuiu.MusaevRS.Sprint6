using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusaevRS.Sprint6.Task1.V1.Lib
{
    public class DataService : ISprint6Task1V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x+2.5 != 0)
                {
                    y = Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x;
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
                

            }
            return valueArray;
        }
    }
}
