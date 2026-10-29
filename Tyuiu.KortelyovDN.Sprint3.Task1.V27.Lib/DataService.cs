using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KortelyovDN.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiply = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                multiply *= Math.Pow((1 / Math.Pow(value, k)), 3);
                k++;
            }

            return Math.Round(multiply, 3);
        }
    }
}