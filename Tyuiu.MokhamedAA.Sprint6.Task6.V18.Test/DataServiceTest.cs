using Tyuiu.MokhamedAA.Sprint6.Task6.V18.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Kirya\Desktop\DataSprint6\InPutFileTask6V18.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "VAYYbnhDwTg sNnk CMmHkUlnNoZen nqrB ";
            Assert.AreEqual(wait, res);
        }
    }
}