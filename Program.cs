using System;

namespace ConsoleApp133
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var separatorIndex = input.IndexOfAny(new char[] { '+', '-', '*', '/' });
            var separator = input[separatorIndex];
            var inputData = input.Split(separator);

            var firstNumber = int.Parse(inputData[0]);
            var secondNumber = int.Parse(inputData[1]);
            var result = Calculate(firstNumber, separator, secondNumber);

            Console.WriteLine(result);
        }

        static double Calculate(int firstNumber, char operation, int secondNumber)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '/':
                    result = firstNumber * 1.0 / secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
            }

            return result;
        }
    }
}
