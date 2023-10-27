using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint3.Task6.V26.Lib;

namespace Tyuiu.KrutikovaVP.Sprint3.Task6.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = 15, stopValue = 22;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #26                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                      *");
            Console.WriteLine("* принадлежащих числовому отрезку [15, 22] количество всех делителей       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Начало отрезка = {startValue}");
            Console.WriteLine($"Конец отрезка = {stopValue}");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Количество делителей = {ds.GetSumTheDivisors(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
    
}
