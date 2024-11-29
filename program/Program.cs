using System.IO;
using library;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint5\DataSprint5\InPutDataFileTask7V14.txt";
            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V14.txt" });

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            path2 = ds.LoadDataAndSave(path);
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
