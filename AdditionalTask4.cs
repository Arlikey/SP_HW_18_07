using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_HW_18_07
{
    internal class AdditionalTask4
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Oleg", "Kirill", "Nastya", "Joe", "Robert", "Larry"
            };

            string fileName = "names.txt";
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                foreach(string name in names)
                {
                    sw.WriteLine(name);
                }
            }
        }
    }
}
