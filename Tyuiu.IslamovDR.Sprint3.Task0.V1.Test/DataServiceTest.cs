using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IslamovDR.Sprint3.Task0.V1.Lib;

namespace Tyuiu.IslamovDR.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int x = 4;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(x, startValue, stopValue);

            Assert.AreEqual(1935, res);
        }
    }
}
