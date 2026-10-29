using Tyuiu.KortelyovDN.Sprint3.Task3.V6.Lib;

namespace Tyuiu.KortelyovDN.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string str = "12able 1o s4gh";
            char chr = 't';

            string res = ds.ReplaceNumOnChar(str, chr);

            string wait = "ttable to stgh";

            Assert.AreEqual(wait, res);
        }
    }
}