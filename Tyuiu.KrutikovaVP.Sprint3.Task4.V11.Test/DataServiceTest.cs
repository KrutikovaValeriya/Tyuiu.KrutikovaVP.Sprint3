using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint3.Task4.V11.Lib;

namespace Tyuiu.KrutikovaVP.Sprint3.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double wait = 0.526;
            var res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);

        }
    }
}
