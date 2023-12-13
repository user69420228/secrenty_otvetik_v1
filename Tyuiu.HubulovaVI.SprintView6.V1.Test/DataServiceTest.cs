using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.SprintView6.V1.Lib;

namespace Tyuiu.HubulovaVI.SprintView6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService dataService = new DataService();
            int[,] myArray = { { 1, 2, 3 },
                               { 4, 5, 6 },
                               { 7, 8, 9 } };

            double sum = dataService.result(myArray, 1, 9, 1, 0, 2);

            Assert.AreEqual(15, sum);
        }
    }
}