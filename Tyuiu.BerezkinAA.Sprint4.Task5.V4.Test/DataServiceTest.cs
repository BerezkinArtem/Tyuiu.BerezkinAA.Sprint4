using Tyuiu.BerezkinAA.Sprint4.Task5.V4.Lib;
namespace Tyuiu.BerezkinAA.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {{ -4, -3, -1, 0, 1 },
                                           { 2, 3, 4, 5, 6 },
                                           { -4, -3, -2, -1, 0 },
                                           { 1, 2, 3, 4, 5 },
                                           { 6, 0, -1, -2, -3 } };
            int res = ds.Calculate(matrix);
            int wait = 12;
            Assert.AreEqual(res, wait);
        }
    }
}
    