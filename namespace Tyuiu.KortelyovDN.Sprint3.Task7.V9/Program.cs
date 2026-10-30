using Tyuiu.KortelyovDN.Sprint3.Task7.V9.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("--------------------");
            Console.WriteLine("    x     |   F(x)   ");
            Console.WriteLine("--------------------");

            for (int i = 0; i <= valueArray.Length - 1; i++)
            {
                Console.WriteLine("{0,5:d}     |  {1, 6:f2}  ", startValue, valueArray[i]);
                startValue++;
            }
            Console.ReadKey();
        }
    }
}