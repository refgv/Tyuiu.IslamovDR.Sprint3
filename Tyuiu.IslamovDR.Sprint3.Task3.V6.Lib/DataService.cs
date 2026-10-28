using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IslamovDR.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    value = value.Replace(chr, item);
                }
            }
            return value;
        }
    }
}
