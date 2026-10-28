using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IslamovDR.Sprint3.Task1.V18.Lib;

namespace Tyuiu.IslamovDR.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 0.121;
            Assert.AreEqual(wait, res);
        }
    }
}
