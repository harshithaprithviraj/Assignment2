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
        public void Analyze_Input5_Input8and15_expectedResultEqualsNotATriangle()
        {
            //Arrange

            int firstNumber = 5;
            int secondNumber = 8;
            int thirdNumber = 15;

            string expectedResult = "It doesn't form a triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input5_Input8and15_expectedResultEqualsNotATriangle()
        {
            //Arrange

            int firstNumber = 5;
            int secondNumber = 8;
            int thirdNumber = 15;

            string expectedResult = "It doesn't form a triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input5_Input8and15_expectedResultEqualsNotATriangle()
        {
            //Arrange

            int firstNumber = 5;
            int secondNumber = 8;
            int thirdNumber = 15;

            string expectedResult = "It doesn't form a triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

            //Act

            string actualResult = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input5_Input8and15_expectedResultEqualsNotATriangle()
        {
            //Arrange

            int firstNumber = 5;
            int secondNumber = 8;
            int thirdNumber = 15;

            string expectedResult = "It doesn't form a triangle";
            TriangleTests testTriangleSolver = new TriangleTests();

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

    }
}
