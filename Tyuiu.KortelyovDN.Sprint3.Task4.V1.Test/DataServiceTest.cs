using Tyuiu.KortelyovDN.Sprint3.Task4.V1.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 1.346;

            Assert.AreEqual(wait, res);
        }
    }
}