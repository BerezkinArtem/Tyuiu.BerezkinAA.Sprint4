using Tyuiu.BerezkinAA.Sprint4.Task7.V26.Lib;
namespace Tyuiu.BerezkinAA.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "351268459614723";
            int res = ds.Calculate(n, m, value);
            int wait = 0;
            Assert.AreEqual(wait, res);

        }
    }
}