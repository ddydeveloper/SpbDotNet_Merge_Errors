using System;
using Calculations;
using Xunit;

namespace CalculationsTest
{
    public class CalculatorTest
    {
        [Fact]
        public void SaltedSumTest()
        {
            Assert.True(Calculator.SaltedSum(1, 1) == 13);
        }
    }
}