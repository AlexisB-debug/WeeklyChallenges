using System;
using System.Linq;
using System.Collections.Generic;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            List<int> numbersToList = numbers.ToList();
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach (int number in numbersToList)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            int evensSum = 0;
            foreach (int even in evens)
            {
                evensSum = evensSum + even;
            }
            
            int  oddsSum = 0;
            foreach (int odd in odds)
            {
                oddsSum = oddsSum + odd;
            }
            
            int answer =  evensSum - oddsSum;
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = new [] { str1, str2, str3, str4 };
            string shortest = strings[0];
            foreach (string str in strings)
            {
                if (str.Length < shortest.Length)
                {
                    shortest = str;
                }
            }
            return shortest.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new [] { number1, number2, number3, number4 };
            int smallest = numbers[0];
            foreach (int number in numbers)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool triInequFirst = Math.Abs((sideLength1 - sideLength2)) < sideLength3;
            bool tirInequSecond = sideLength3 < (sideLength1 + sideLength2);

            if (triInequFirst == true)
            {
                if (tirInequSecond == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<object> nulls = new List<object>();
            List<object> contains =  new List<object>();

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nulls.Add(obj);
                }
                else
                {
                    contains.Add(obj);
                }
            }
            
            int nullsCount = nulls.Count;
            int containsCount = contains.Count;

            if (nullsCount > containsCount)
            {
                return true;
            }
            else //(nullsCount <= containsCount)
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            List<int> evens = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
            }

            int evensSum = 0;
            foreach (int even in evens)
            {
                evensSum = even + evensSum;
            }
            
            int evensCardinality = evens.Count;

            if (evensCardinality == 0)
            {
                return 0;
            }
            else
            {
                double averageEvens = (double) evensSum / evensCardinality;
                return averageEvens;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }
            else if (number == 0)
            {
                return 1;
            }
            else
            {
                int[] numbers = new int[number];
            
                for (int counter = 0; counter <= numbers.Length - 1; counter = counter + 1)
                {
                    numbers[counter] = counter + 1;
                }
            
                int factorial = 1;
                foreach (int num in numbers)
                {
                    factorial = factorial * num;
                }
                return factorial;
            }
        }
    }
}
