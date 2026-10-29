using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KortelyovDN.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string res = "";

            foreach (char chr in value)
            {
                if (Char.IsDigit(chr))
                {
                    res += item;
                }
                else
                {
                    res += chr;
                }
            }

            return res;
        }
    }
}