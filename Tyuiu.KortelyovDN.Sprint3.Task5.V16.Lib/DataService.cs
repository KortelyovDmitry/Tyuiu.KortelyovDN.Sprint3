using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KortelyovDN.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task5V16
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += Math.Cos(k) + Math.Pow(x, 2);
                }
            }

            return Math.Round(sum, 3);
        }
    }
}