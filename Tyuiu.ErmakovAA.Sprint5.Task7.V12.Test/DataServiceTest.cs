using Tyuiu.ErmakovAA.Sprint5.Task7.V12.Lib;
namespace Tyuiu.ErmakovAA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\alexe\AppData\Local\Temp\InPutDataFileTask7V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
