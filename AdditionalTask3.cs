using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_HW_18_07
{
    internal class AdditionalTask3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter path: ");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            Console.Write("Enter path of the destination: ");
            string destinationPath = Console.ReadLine();

            string text = "";
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }
            using (StreamWriter writer = new StreamWriter(destinationPath))
            {
                writer.WriteLine(text.ToUpper());
            }

        }
    }
}
