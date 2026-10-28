using System;
using Tyuiu.IslamovDR.Sprint3.Task3.V6.Lib;

namespace Tyuiu.IslamovDR.Sprint3.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Исламов Д. Р. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Исламов Даниил Радикович | СМАРТб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву t в строке:               *");
            Console.WriteLine("* 12able 1o s4gh                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "12able 1o s4gh";
            char item = 't';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Символ замены = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат замены = " + ds.ReplaceNumOnChar(value, item));

            Console.ReadLine();
        }
    }
}
