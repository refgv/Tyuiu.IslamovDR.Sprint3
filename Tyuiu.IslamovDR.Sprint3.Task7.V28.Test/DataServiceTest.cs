using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IslamovDR.Sprint3.Task7.V28.Lib;

namespace Tyuiu.IslamovDR.Sprint3.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = new double[11] { -11.22, -8.65, -4.76, -6.47, -2.98, 1.0, 1.82, 3.55, 6.99, 7.74, 9.03 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
