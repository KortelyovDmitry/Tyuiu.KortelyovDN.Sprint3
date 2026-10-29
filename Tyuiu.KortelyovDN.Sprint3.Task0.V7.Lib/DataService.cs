using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KortelyovDN.Sprint3.Task0.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                sumSeries = sumSeries + (Math.Pow(value, k) + 1) * Math.Cos(k);
            }

            return Math.Round(sumSeries, 3);
        }
    }
}