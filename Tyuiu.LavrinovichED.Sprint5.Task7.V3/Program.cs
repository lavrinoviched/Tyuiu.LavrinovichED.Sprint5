using System.IO;
using Tyuiu.LavrinovichED.Sprint5.Task7.V3.Lib;

namespace Tyuiu.LavrinovichED.Sprint5.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #6                                                                                        *");
            Console.WriteLine("* Тема: Обработка текстовый файлов                                                                 *");
            Console.WriteLine("* Задание #7                                                                                       *");
            Console.WriteLine("* Вариант #3                                                                                       *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все русские буквы из файла.             *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint5\DataSprint5\InPutDataFileTask7V3.txt";
            string pathSaveFile = @"C:\Users\y_lav\AppData\Local\Temp\OutPutDataFileTask7V3.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                         *");
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("Данные находятся в файле: " + pathSaveFile);

            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
