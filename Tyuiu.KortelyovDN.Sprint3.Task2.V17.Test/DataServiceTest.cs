using Tyuiu.KortelyovDN.Sprint3.Task2.V17.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 1; 
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 2.453;

            Assert.AreEqual(wait, res);
        }
    }
}