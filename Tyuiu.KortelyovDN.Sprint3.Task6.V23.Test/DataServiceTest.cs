using Tyuiu.KortelyovDN.Sprint3.Task6.V23.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 18;
            int stopValue = 28;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 34;

            Assert.AreEqual(wait, res);
        }
    }
}