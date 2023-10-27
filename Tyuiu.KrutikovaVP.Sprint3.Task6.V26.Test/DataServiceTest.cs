using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint3.Task6.V26.Lib;

namespace Tyuiu.KrutikovaVP.Sprint3.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;
            int wait = 33;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
