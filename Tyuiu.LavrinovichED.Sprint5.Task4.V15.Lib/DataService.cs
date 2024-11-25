using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.LavrinovichED.Sprint5.Task4.V15.Lib;

namespace Tyuiu.LavrinovichED.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string content;
            using (StreamReader sr = new StreamReader(path))
            {
                content = sr.ReadToEnd().Trim();
            }

            double x;
            if (!double.TryParse(content, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                content = content.Replace('.', ',');
            }

            double y = Math.Round(Math.Sin(Convert.ToDouble(x)) + (Math.Pow(Convert.ToDouble(x), 2 ) / 2), 3);

            return Math.Round(y, 3);
        }
    }
}
