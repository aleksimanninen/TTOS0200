using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vk44laskin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk44laskin.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //testataan mycalculator-luokan add-metodia, AAA-malli
            //arrange
            int i = 10;
            int j = 12;
            int tulos = 22;
            MyCalculator laskin = new MyCalculator();
            //act
            int summa = laskin.Add(i, j);
            //assert
            Assert.AreEqual(tulos, summa);
            //.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }
    }
}