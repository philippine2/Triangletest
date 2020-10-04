using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SUT = Homework4.Triangle;

namespace Homework4.unitTest
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfTheTriangleIsEqulateral()
        {
            //Arrange
            Triangle triangle = new Triangle(2, 2, 2);
            string expected = "Equilateral";

            //Act
            string result = SUT.Analyzemethod(triangle);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckIfTheTraingleIsIsocele()
        {
            //Arrange
            Triangle triangle2 = new Triangle(2, 2, 1);
            string expected = "isoceles";

            //Act
            string result = SUT.Analyzemethod(triangle2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckIfTheTraingleIsScalene()
        {
            //Arrange
            Triangle triangle3 = new Triangle(2, 4, 3);
            string expected = "scalene";

            //Act
            string result = SUT.Analyzemethod(triangle3);

            //Assert
            Assert.AreEqual(expected, result);
        }





        [TestMethod]
        public void WhenSideBGreaterThanTheSumOfSideASide()
        {
            //Arrange
            Triangle triangle1 = new Triangle(5, 9, 1);

            // Act and Assert
            Assert.ThrowsException<TriangleException>(() => SUT.Analyzemethod(triangle1));
        }
        [TestMethod]
        public void WhenSideAGreaterThanSumOfBothSideBSideC()
        {
            //Arrange
            Triangle triangle2 = new Triangle(10, 3, 4);


            // Act and Assert
            Assert.ThrowsException<TriangleException>(() => SUT.Analyzemethod(triangle2));
        }
        [TestMethod]
        public void Ifanyarenotpositivenumbers()
        {
            //Arrange
            Triangle triangle3 = new Triangle(8, -6, 5);

            // Act and Assert
            Assert.ThrowsException<TriangleException>(() => SUT.Analyzemethod(triangle3));
        }

        [TestMethod]
        public void WhenSideCGreaterThanSumOfBothSideASideB()
        {
            //Arrange
            Triangle triangle4 = new Triangle(7, 3, 15);


            // Act and Assert
            Assert.ThrowsException<TriangleException>(() => SUT.Analyzemethod(triangle4));
        }
        [TestMethod]
        public void Ifanyarenotpositivenumbers1()
        {
            //Arrange
            Triangle triangle5 = new Triangle(9, 10, 0);

            // Act and Assert
            Assert.ThrowsException<TriangleException>(() => SUT.Analyzemethod(triangle5));

        }

        [TestMethod]
        public void TryingNewException_WhenSideaAndSidebAreEqualAndSideCequalToFive()
        {
            //Arrange
            Triangle triangle1 = new Triangle(4, 4, 5);

            // Act and Assert
            Assert.ThrowsException<TriangleException>(() => SUT.Analyzemethod(triangle1));
        }







    }

}
