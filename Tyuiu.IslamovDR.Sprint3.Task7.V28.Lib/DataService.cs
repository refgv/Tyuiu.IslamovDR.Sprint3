using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IslamovDR.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((x + 2.5) == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
