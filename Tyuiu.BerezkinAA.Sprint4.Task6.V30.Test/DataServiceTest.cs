using Tyuiu.BerezkinAA.Sprint4.Task6.V30.Lib;
namespace Tyuiu.BerezkinAA.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var array = new string[] { "������", "���", "����", "�����", "�����", "�����" };

            string[] res = ds.Calculate(array);
            string a = res[0];
            string wait = "������";

            Assert.AreEqual(wait, a);
        }
    }
}