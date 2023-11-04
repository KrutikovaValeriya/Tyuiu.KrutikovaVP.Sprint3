using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint3.Task1.V2.Lib;

namespace Tyuiu.KrutikovaVP.Sprint3.Task1.V2.Test
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

            var res = ds.GetSumSeries(startValue, stopValue);
            var wait = 0.968;
            Assert.AreEqual(wait, res);
        }
    }
}
