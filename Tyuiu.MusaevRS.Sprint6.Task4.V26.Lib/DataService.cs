using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusaevRS.Sprint6.Task4.V26.Lib
{
    public class DataService : ISprint6Task4V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x < stopValue; x++)
            {
                y = Math.Round((5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5))), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
