using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
            // I cannot return a string that reads "error" or "same number" when the declared return type of the signature is integer & not string
            // If I return "0" then that is not proper communication with the user
            //else if (number1 == number2)
            //{
            //    return number1 && number2;
            //}
        }

        public long Multiply(long factor1, long factor2)
        {
            long product =  factor1 * factor2;
            return product;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
