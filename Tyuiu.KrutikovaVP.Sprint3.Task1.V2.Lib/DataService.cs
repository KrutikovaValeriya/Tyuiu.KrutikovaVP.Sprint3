﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrutikovaVP.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            while (startValue<=stopValue)
            {
                sumSeries += Math.Sin(startValue) / 2;
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
