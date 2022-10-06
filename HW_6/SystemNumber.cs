using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    internal class SystemNumber
    {
        public static void Calculate(string firstvalue, string secondvalue, char calculationOperation, int numberSystem)
        {
            int firstValue = Convert.ToInt32(firstvalue, numberSystem);
            int secondValue = Convert.ToInt32(secondvalue, numberSystem);
            int result;
            switch (calculationOperation)
            {
                case '+':
                    result = firstValue + secondValue;
                    string resultAddition = Convert.ToString(result,numberSystem);
                    Console.WriteLine($"{firstValue} + {secondvalue} = {resultAddition}");
                    break;
                case '-':
                    result = firstValue - secondValue;
                    string resultSubtraction = Convert.ToString(result, numberSystem);
                    Console.WriteLine($"{firstValue} - {secondValue} = {resultSubtraction}");
                    break;
                case '*':
                    result = firstValue * secondValue;
                    string resultMultiplication = Convert.ToString(result, numberSystem);
                    Console.WriteLine($"{firstValue}*{secondValue} = {resultMultiplication}");
                    break;
                case '/':
                    result = firstValue / secondValue;
                    string resultDivision = Convert.ToString(result, numberSystem);
                    Console.WriteLine($"{firstValue} / {secondValue} = {resultDivision}");
                    break;
                default:
                    break;

            }
        }
    }
}
