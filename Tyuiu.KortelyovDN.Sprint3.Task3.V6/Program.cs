using Tyuiu.KortelyovDN.Sprint3.Task3.V6.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "12able 1o s4gh";
            char item = 't';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ замены = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Итоговая строка = " + ds.ReplaceNumOnChar(value, item));

            Console.ReadKey();
        }
    }
}