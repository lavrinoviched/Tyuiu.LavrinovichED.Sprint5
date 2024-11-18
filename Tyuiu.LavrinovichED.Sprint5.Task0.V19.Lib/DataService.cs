using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5; 

namespace Tyuiu.LavrinovichED.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });

            double a = 2 * Math.Pow(x, 2) - 1 / Math.Sqrt(Math.Pow(x, 2) - 2);
            a = Math.Round(a, 3);

            File.WriteAllText(path, Convert.ToString(a));
            return path; 
        }
    }
}
