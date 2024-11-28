using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavrinovichED.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string putj = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.txt";
            FileInfo fileInfo = new FileInfo(putj);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(putj);
            }
            string str = File.ReadAllText(path);
            string result = Regex.Replace(str, @"\b[ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ][а-я]+", "");
            File.AppendAllText(putj, result + Environment.NewLine);
            return putj;
        }
    }
}
