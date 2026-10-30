using Tyuiu.KortelyovDN.Sprint3.Task7.V9.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = -27.22;
            valueWaitArray[1] = -20.74;
            valueWaitArray[2] = -15.81;
            valueWaitArray[3] = -10.15;
            valueWaitArray[4] = -2.31;
            valueWaitArray[5] = -3.00;
            valueWaitArray[6] = 4.84;
            valueWaitArray[7] = 8.86;
            valueWaitArray[8] = 14.43;
            valueWaitArray[9] = 20.18;
            valueWaitArray[10] = 25.24;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}