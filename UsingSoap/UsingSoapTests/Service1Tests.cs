using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsingSoap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSoap.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetPrisTest()
        {
            // Arrange
            Service1 b1 = new Service1();
            int expectedResult = 240;
            // Act
            var actualResult = b1.GetPrisBil() ;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod()]
        public void KøretøjForBilTest()
        {
            // Arrange
             Service1 b2 = new Service1();
            string expectedResult = "Bil";

            // Act
            var actualResult = b2.GetBil();

            //  Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod()]
        public void PrisForMCTest()
        {
            // Arrange 
            Service1 mc1 = new Service1();
            int expectedResult = 125;

            // Act
            var actualResult = mc1.GetPrisMC();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}