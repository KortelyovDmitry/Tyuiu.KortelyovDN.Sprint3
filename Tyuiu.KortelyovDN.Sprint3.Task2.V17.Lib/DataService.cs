using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KortelyovDN.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                sum += Math.Pow(1.0 / (Math.Cos(k) + 2.0), 2);
                k++;
            } while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}