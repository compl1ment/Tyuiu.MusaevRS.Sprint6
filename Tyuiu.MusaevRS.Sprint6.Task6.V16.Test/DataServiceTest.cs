using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MusaevRS.Sprint6.Task6.V16.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\rumu2\Downloads\Sprint6Task6\Sprint6Task6\InPutFileTask6V16.txt";
            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, exists);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\Users\rumu2\Downloads\Sprint6Task6\Sprint6Task6\InPutFileTask6V16.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "brIBPtX bWk ";
            Assert.AreEqual(wait, res);

        }
    }
}
