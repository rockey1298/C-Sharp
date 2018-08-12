using System;

class Program
    {
        static void Main(string[] args)
        {
            int firstNumber=10, secondNumber=10, thirdNumber=7, result, secondResult;
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
            secondResult = firstNumber + thirdNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, thirdNumber, secondResult);
        }
    }
