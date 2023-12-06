using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MusaevRS.Sprint6.Task5.V23.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\rumu2\Source\Repos\Tyuiu.MusaevRS.Sprint6\Tyuiu.MusaevRS.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";
            double[] valueArray;
            valueArray = ds.LoadFromDataFile(path);
            double res = valueArray[0];
            double wait = -17;
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\rumu2\Source\Repos\Tyuiu.MusaevRS.Sprint6\Tyuiu.MusaevRS.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool Exist = fileInfo.Exists;
            bool waiting = true;
            Assert.AreEqual(waiting, Exist);
        }
    }
}
