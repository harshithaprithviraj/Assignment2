using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2;

namespace TriangleTest
{
    [TestFixture]

    class TriangleTests
    {
        [Test]
        public void Analyze_Input5_Input8and15_expectedResultEqualsNotATriangle()
        {
            //Arrange

            int firstNumber = 5;
            int secondNumber = 8;
            int thirdNumber = 15;

            string expectedResult = "It doesn't form a triangle";
            TriangleTests testTriangleSolver = new TriangleTests( );

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input2_Input2and2_expectedResultEqualsEquilateralTriangle()
        {
            //Arrange

            int firstNumber = 2;
            int secondNumber = 2;
            int thirdNumber = 2;

            string expectedResult = "It forms a triangle of type Equilateral triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input8_Input5and8_expectedResultEqualsIsoscelesTriangle()
        {
            //Arrange

            int firstNumber = 8;
            int secondNumber = 5;
            int thirdNumber = 8;

            string expectedResult = "It forms a triangle of type Isosceles triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input3_Input4and5_expectedResultEqualsScaleneTriangle()
        {
            //Arrange

            int firstNumber = 3;
            int secondNumber = 4;
            int thirdNumber = 5;

            string expectedResult = "It forms a triangle of type Scalene triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input0_Input1and2_expectedResultEqualsNotATriangle()
        {
            //Arrange

            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 2;

            string expectedResult = "It doesn't form a triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input70000_Input70000and70000_expectedResultEqualsEquilateralTriangle()
        {
            //Arrange

            int firstNumber = 70000;
            int secondNumber = 70000;
            int thirdNumber = 70000;

            string expectedResult = "It forms a triangle of type Equilateral triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input1500000_Input200and1500000_expectedResultEqualsIsoscelesTriangle()
        {
            //Arrange

            int firstNumber = 1500000;
            int secondNumber = 200;
            int thirdNumber = 1500000;

            string expectedResult = "It forms a triangle of type Isosceles triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input300000000_Input400000000and500000000_expectedResultEqualsScaleneTriangle()
        {
            //Arrange

            int firstNumber = 300000000;
            int secondNumber = 400000000;
            int thirdNumber = 500000000;

            string expectedResult = "It forms a triangle of type Scalene triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
