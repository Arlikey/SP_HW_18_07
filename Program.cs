namespace SP_HW_18_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "file.txt";

            using(StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("Hello World!");
            }
            string textFromFile = "";
            using (StreamReader sr = new StreamReader(fileName))
            {
                textFromFile = sr.ReadToEnd();
            }

            Console.WriteLine(textFromFile);
        }
    }
}
