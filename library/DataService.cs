using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace library
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V14.txt" });

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c >= 'а' && c <= 'я')
                        {
                            strLine += (char)(c - ('а' - 'А'));
                        }
                        else
                        {
                            strLine += c;
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);

                }
            }
            return pathSaveFile;
        }
    }
}
