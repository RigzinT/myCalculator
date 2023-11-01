using System;
using NUnit.Framework;
using myCalculator;

namespace myCalculatorNunitTest
{
    public class Tests
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
        }
    }
}