using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusaevRS.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    resStr = resStr + " " + line;
                }
            }          
            var slova = "";
            int count = 0;
            string cursor = "";
            while ((count < resStr.Length))
            {
                bool inword = true; ;
                while (inword == true)
                {
                    if(resStr[count] != ' ')
                    {
                        inword = true;
                        cursor += resStr[count];
                        count++;
                    }
                    else
                    {
                        inword = false;
                        count++;
                    }                                      
                }
                if (cursor.Contains("b"))
                {
                    slova = slova + cursor + " ";
                }
                cursor = "";

            }
            return slova;
            
            
        }

    }
}
