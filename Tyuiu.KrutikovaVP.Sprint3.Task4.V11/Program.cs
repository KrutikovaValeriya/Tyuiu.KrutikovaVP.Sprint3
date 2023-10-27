using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint3.Task4.V11.Lib;

namespace Tyuiu.KrutikovaVP.Sprint3.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = - 5, stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                         *");
            Console.WriteLine("* вычислить значение функции y=x/(sin(x) - x)+2                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Произведение ряда = {ds.Calculate(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
