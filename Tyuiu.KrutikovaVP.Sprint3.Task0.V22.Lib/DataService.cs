using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrutikovaVP.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            for (int i = 1; i<=8; i++)
            {
                multiplySeries *= (Math.Pow(value, i) + 4) * Math.Cos(value);
            }
            return Math.Round(multiplySeries,3);
        }
    }
}
