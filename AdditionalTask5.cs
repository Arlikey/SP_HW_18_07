using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_HW_18_07
{
    internal class AdditionalTask5
    {
        static void Main(string[] args)
        {
            string fileName = "names.txt";
            using (StreamReader sr = new StreamReader(fileName))
            {
                for (int i = 1; !sr.EndOfStream; i++)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine($"Длина строки #{i}: {line.Length}");
                }

            }
        }
    }
}
