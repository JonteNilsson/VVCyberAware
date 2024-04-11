using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCyberAware.Methods;

namespace DBTests
{
    // Paulines Unittest
    public class UnitTestCalculation
    {
        [Fact]
        public void TestCalculation()
        {
            // Arrange
            CalculatingProcent calculatingProcent = new CalculatingProcent();

            //Act
            double testsum = calculatingProcent.Calculation(2, 2);

            //Assert
            Assert.Equal(100, testsum);
        }

        [Theory]
        [InlineData(2, 2, 100)]
        [InlineData(4, 2, 200)]
        [InlineData(9, 3, 300)]
        [InlineData(16, 4, 400)]
        [InlineData(10, 2, 500)]
        [InlineData(12, 2, 600)]
        [InlineData(2, 0, 0)]
        public void TestCalculationTheory(int x, int y, int expected)
        {
            CalculatingProcent calculatingProcent = new CalculatingProcent();
            double testresult = calculatingProcent.Calculation(x, y);

            Assert.Equal(expected, testresult);
        }

    }
}
