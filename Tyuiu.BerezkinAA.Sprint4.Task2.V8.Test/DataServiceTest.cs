using Tyuiu.BerezkinAA.Sprint4.Task2.V8.Lib;

namespace Tyuiu.BerezkinAA.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsarray = {2, 4, 5, 3, 6, 7, 1, 6, 3, 4, 7 };
            int res = ds.Calculate(numsarray);
            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}