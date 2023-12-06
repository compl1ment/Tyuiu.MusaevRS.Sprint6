using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint6.Task4.V26.Lib;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint6.Task4.V26.Test
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
            double[] valueArray;
            valueArray = ds.GetMassFunction(startValue, stopValue);
            double res = valueArray[0];
            double wait = 19.81;
            

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\rumu2\source\repos\Tyuiu.MusaevRS.Sprint6\Tyuiu.MusaevRS.Sprint6.Task4.V26\bin\Debug\OutPutFileTask4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool Exist = fileInfo.Exists;
            bool waiting = true;
            Assert.AreEqual(waiting, Exist);

        }
    }
}
