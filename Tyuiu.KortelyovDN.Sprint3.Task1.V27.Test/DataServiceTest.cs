using Tyuiu.KortelyovDN.Sprint3.Task1.V27.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 413233.156;

            Assert.AreEqual(wait, res);
        }
    }
}