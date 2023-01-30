using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionTool
{
    public class LengthCoversionTool
    {
        //Convert feet to meter
        //https://techstudy.org/csharp/Csharp-Program-to-print-convert-feet-to-meter/
        [Test]
        public void ToolConverter()
        {
            //Arrange
            double feetLength = 50.00;
            double meterLength;
            double constant = 0.3048;
            //Act
            meterLength = constant * feetLength;
            //Assert
            Assert.AreEqual(15.24, meterLength, "Please check formula. Wrong conversion is calculated!");
        }


    }
}
