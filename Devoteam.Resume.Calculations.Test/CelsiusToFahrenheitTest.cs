using System;
using Devoteam.Resume.Calculations.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Devoteam.Resume.Calculations.Test
{
    [TestClass]
    public class CelsiusToFahrenheitTest
    {
        private ICelsiusToFahrenheit _celsiusToFahrenheit;

        [TestInitialize]
        public void Setup()
        {
            _celsiusToFahrenheit = new Calculations.CelsiusToFahrenheit();
        }

        [TestMethod]
        public void When_Positive_Input_Should_Return_Expected_Output()
        {
            var fahrenheit = _celsiusToFahrenheit.Calculate(21);

            Assert.AreEqual(69, fahrenheit);
        }

        [TestMethod]
        public void When_Negative_Input_Should_Return_Expected_Output()
        {
            var fahrenheit = _celsiusToFahrenheit.Calculate(-10);

            Assert.AreEqual(15, fahrenheit);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void When_Crazy_Input_Should_Return_ArgumentOutOfRangeException()
        {
            _celsiusToFahrenheit.Calculate(int.MaxValue);
        }
    }
}
