using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint6.Task2.V9.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5,5);
            double wait = 4.34;
            double resultat = res[0];
            Assert.AreEqual(wait, resultat);
        }
    }
}
