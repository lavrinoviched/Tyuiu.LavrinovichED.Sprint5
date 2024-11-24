using System.IO;
using Tyuiu.LavrinovichED.Sprint5.Task2.V10.Lib;

namespace Tyuiu.LavrinovichED.Sprint5.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\y_lav\AppData\Local\Temp\OutPutFileTask2.cvs";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}