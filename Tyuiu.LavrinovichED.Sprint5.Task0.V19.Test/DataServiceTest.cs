using System.IO;
using Tyuiu.LavrinovichED.Sprint5.Task0.V19.Lib; 

namespace Tyuiu.LavrinovichED.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint5\Tyuiu.LavrinovichED.Sprint5.Task0.V19\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}