using Tyuiu.MokhamedAA.Sprint6.Task1.V9.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 0; int b = 1;
            double[] res = ds.GetMassFunction(a, b);
            double[] wail = new double[2];
            wail[0] = -5;
            wail[1] = -1;
            Assert.AreEqual(res[0], wail[0]);

            Assert.AreEqual(res[1], wail[1]);
        }
    }
}