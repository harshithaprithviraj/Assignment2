using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        private static bool checkValidity(int firstNumber, int secondNumber, int thirdNumber)
        {
            // check condition 
            if (firstNumber + secondNumber > thirdNumber && firstNumber + thirdNumber > secondNumber && secondNumber + thirdNumber > firstNumber)
            {
                return true;
            }
            else
                return false;
        }
        
        public static string Analyze(int firstNumber, int secondNumber, int thirdNumber)
        {
            string result = "Errr.....";
            
            if(checkValidity(firstNumber, secondNumber, thirdNumber))
            {
                result = "It forms a triangle of type ";
                if ((firstNumber == secondNumber) && (secondNumber == thirdNumber) && (firstNumber == thirdNumber))
                {
                    result += "Equilateral triangle";
                }
                else if ((firstNumber == secondNumber) || (secondNumber == thirdNumber) || (thirdNumber == firstNumber))
                {
                    result += "Isosceles triangle";
                }
                else if ((firstNumber != secondNumber) || (secondNumber != thirdNumber) || (thirdNumber != firstNumber))
                {
                    result += "Scalene triangle";
                }

            }
            else
            {
                return "It doesn't form a triangle";
            }
            
            return result;
        }
       
    }
}

