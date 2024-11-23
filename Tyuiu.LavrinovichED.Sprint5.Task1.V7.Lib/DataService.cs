using System.IO; 

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavrinovichED.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            double a;
            double b;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Sin(x) / x + 1.2) - Math.Sin(x) * 2 - 2 * x), 2);
                strY = Convert.ToString(y);


                if (x != stopValue)
                {
                    if(Math.Sin(x) * 2 - 2 * x != 0)
                    {
                        y = Math.Round(((Math.Sin(x) / (x + 1.2)) - ((Math.Sin(x) * 2) - (2 * x))), 2);
                        strY = Convert.ToString(y);
                    }
                    else
                    {
                        y = 0;
                        strY = Convert.ToString(y);
                    }
                    File.AppendAllText(path, Environment.NewLine + strY);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path; 
        }
    }
}
