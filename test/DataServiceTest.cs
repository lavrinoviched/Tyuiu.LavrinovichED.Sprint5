using System.IO;
using library;

namespace test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\y_lav\source\repos\Tyuiu.LavrinovichED.Sprint5\DataSprint5\InPutDataFileTask7V14.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}