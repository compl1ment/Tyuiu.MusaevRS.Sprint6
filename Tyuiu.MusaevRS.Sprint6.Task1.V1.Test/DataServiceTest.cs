using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint6.Task1.V1.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;           
            int len = stopValue - startValue + 1;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            int count = 0;           
            double wait5 = -11.22;
            double res = valueArray[0];
            Assert.AreEqual(wait5, res);
        }
    }
}
