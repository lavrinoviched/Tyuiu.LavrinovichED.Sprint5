using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavrinovichED.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint5\DataSprint5\InPutDataFileTask7V3.txt";

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(Convert.ToChar(line[i]) >= 'а' && Convert.ToChar(line[i]) <= 'я' ||
                            Convert.ToChar(line[i]) >= 'А' && Convert.ToChar(line[i]) <= 'Я'|| (line[i] != '!') && (line[i] != ',')))
                        {
                            strLine = strLine + line[i];
                        }
                    }
                    strLine = "";
                }
            }
            FileInfo fileInfo = new FileInfo(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V3.txt" }));
            if (fileInfo.Exists)
            {
                File.Delete(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V3.txt" }));
            }
            using (StreamWriter writer = new StreamWriter(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V3.txt" })))
            {
                writer.WriteLine(pathSaveFile);
            }
            return pathSaveFile;

        }
    }
}
