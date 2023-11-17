using System;
using myCalculator;
using NUnit.Framework;

namespace myCalculatorNunitTest
{

    [TestFixture]
    public class ProgramTests
        {
            [Test]
            public void TestAddMethod()
            {
                // Arrange
                double expected = 5;
                double fno = 2;
                double sno = 3;

                // Act
                double actual = Program.AddMethod(fno, sno);

                // Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void TestMultiplyMethod()
            {
                // Arrange
                double expected = 6;
                double fno = 2;
                double sno = 3;

                // Act
                double actual = Program.MultiplyMethod(fno, sno);

                // Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void TestDivisionMethod()
            {
                // Arrange
                double expected = 2;
                double fno = 6;
                double sno = 3;

                // Act
                double actual = Program.DivMethod(fno, sno);

                // Assert
                Assert.AreEqual(expected, actual);
            }
            /* for testing
            [Test]
            public void TestSubtractionMethod()
            {
                // Arrange
                double expected = 3.3;
                double fno = 6.5;
                double sno = 3.2;

                // Act
                int actual = Program.SubtractionMethod(fno, sno);

                // Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void TestSubtractionNegativeMethod()
            {
                // Arrange
                double expected = -2.1;
                double fno = 1.1;
                double sno = 3.2;

                // Act
                int actual = Program.SubtractionMethod(fno, sno);

                // Assert
                Assert.AreEqual(expected, actual);
            } */
        
    } 
}