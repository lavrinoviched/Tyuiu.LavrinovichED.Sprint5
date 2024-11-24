using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5; 

namespace Tyuiu.LavrinovichED.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    {
        public string SaveToFileTextData(int x)
        {
            double calculatedResult = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);


            int intResult = (int)Math.Round(calculatedResult, 3);


            string tempPath = Path.GetTempPath();


            string filePath = Path.Combine(tempPath, "OutPutFileTask3.bin");


            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(intResult);
            }


            byte[] fileBytes = File.ReadAllBytes(filePath);
            string base64String = Convert.ToBase64String(fileBytes);

            return filePath;
        }
    }
}
