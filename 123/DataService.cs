using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    public class DataService
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
                if (Math.Cos(x) + x != 0)
                {
                    y = ((2*x+6)/(Math.Cos(x) + x))-3;
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }


            }
            return valueArray;
        }
    }
}
