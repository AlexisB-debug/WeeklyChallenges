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
            Console.WriteLine("This method subtracts a subtrahend from a minuend.\nPlease, choose the minuend.");
            double minuend = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, choose the subtrahend.");
            double subtrahend = double.Parse(Console.ReadLine());
            double difference = minuend - subtrahend;
            return difference;
            //Code for the main method
            //Console.WriteLine($"The difference is {Subtract(7,7)}")
        }

        public int Add(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            throw new NotImplementedException();
        }

        public string GetHey()
        {
            throw new NotImplementedException();
        }
    }
}
