using Tyuiu.MokhamedAA.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var path = @"C:\DataSprint6\InPutFileTask5V6.txt";
            var res = ds.LoadFromDataFile(path);
            double[] wait = { -12 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}