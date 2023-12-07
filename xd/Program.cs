using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint6.Task6.V16.Lib;

namespace xd
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rumu2\Downloads\Sprint6Task6\Sprint6Task6\InPutFileTask6V16.txt";
            DataService ds = new DataService();
            Console.WriteLine(ds.CollectTextFromFile(path));
            Console.ReadKey();
        }
    }
}
