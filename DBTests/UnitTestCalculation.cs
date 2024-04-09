using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCyberAware.Methods;

namespace DBTests
{
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

    }
}
