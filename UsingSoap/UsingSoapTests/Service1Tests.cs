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
            var actualResult = b1.GetPris();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}