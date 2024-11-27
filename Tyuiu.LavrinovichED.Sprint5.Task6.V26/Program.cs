using System.IO;
using Tyuiu.LavrinovichED.Sprint5.Task6.V26.Lib;

namespace Tyuiu.LavrinovichED.Sprint5.Task6.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* Спринт #6                                                                                          *");
            Console.WriteLine("* Тема: Обработка текстовый файлов                                                                   *");
            Console.WriteLine("* Задание #6                                                                                         *");
            Console.WriteLine("* Вариант #26                                                                                        *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                         *");
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                           *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Найти количество знаков вопроса в заданной строке *");
            Console.WriteLine("*                                                                                                    *");
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                   *");
            Console.WriteLine("******************************************************************************************************");

            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint5\DataSprint5\InPutDataFileTask6V26.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                         *");
            Console.WriteLine("******************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
