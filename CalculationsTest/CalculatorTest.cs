using System;
using Calculations;
using Xunit;

namespace CalculationsTest
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator = new Calculator(); 
        
        [Fact]
        public void SaltedSummTest()
        {
            Assert.True(_calculator.SaltedSumm(1, 1) == 14);
        }
    }
}