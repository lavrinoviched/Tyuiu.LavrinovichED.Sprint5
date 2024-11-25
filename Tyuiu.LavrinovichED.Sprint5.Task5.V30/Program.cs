using System.IO;
using Tyuiu.LavrinovichED.Sprint5.Task5.V30.Lib;

namespace Tyuiu.LavrinovichED.Sprint5.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                                          *");
            Console.WriteLine("* Задание #4                                                                                       *");
            Console.WriteLine("* Вариант #15                                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл в котором есть вещественное значение. Прочитать значение из файла и подставить вместо Х *");
            Console.WriteLine("* в формуле.  Вычислить значение по формуле  и вернуть полученный результат на консоль.            *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint5\DataSprint5\InPutDataFileTask5V30.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
