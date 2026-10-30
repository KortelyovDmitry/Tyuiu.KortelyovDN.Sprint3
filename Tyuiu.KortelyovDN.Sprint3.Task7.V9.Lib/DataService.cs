using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KortelyovDN.Sprint3.Task7.V9.Lib
{
    public class DataService : ISprint3Task7V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                double znam = Math.Cos(x) - 2 * x;

                if (Math.Abs(znam) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(((2.0 * x - 3.0) / znam) + 5.0 * x - Math.Sin(x), 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}