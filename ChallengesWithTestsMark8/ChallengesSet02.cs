using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            for (int counter = 0; counter < alphabet.Length; counter++)
            {
                if (alphabet[counter] == c)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            // if (numbers.Count == 0)
            // {
            //     double? sum = null;
            // }

            double minimum = numbers[0];
            for (int counter = 1; counter <= numbers.Count - 1; counter = counter + 1)
            {
                if (numbers[counter] < minimum)
                {
                    minimum = numbers[counter];
                }
            }

            double maximum = numbers[0];
            for (int counter = 1; counter <= numbers.Count - 1; counter = counter + 1)
            {
                if (numbers[counter] > maximum)
                {
                    maximum = numbers[counter];
                }
            }

            double sum = minimum + maximum;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            for (int counter = 0; counter <= numbers.Length - 1; counter = counter + 1)
            {
                int x = 0;
                x = x + numbers[counter];
            }
            return x;
        }

        public int SumEvens(int[] numbers)
        {
            List<int> numbersList = numbers.ToList();
            for (int counter = 0; counter <= numbersList.Count - 1; counter = counter + 1)
            {
                int number = numbersList[counter];
                if (number % 2 != 0)
                {
                    numbersList.RemoveAt(counter);
                }
            }
            
            int[] EvenNumbersArray = numbersList.ToArray();
            
            for (int counter = 0; counter <= numbers.Length - 1; counter = counter + 1)
            {
                int y = 0;
                y = y + EvenNumbersArray[counter];
            }
            return y;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            // int x is the greatest odd positive integer less than number
            number = Math.Abs(number);
            
            //The remainder is an integer and odd numbers are integers
            
            if (number % 2 == 0)
            {
                x = (number / 2) * 2 - 1;
            }
            else
            {
                x = (number / 2) * 2 + 1;
            }
            
            //Use a for loop to construct a list of all odd numbers below number
            List<int> oddNumbersBelowLongList = new List<int>();
            for (int counter = x - 1; counter >= 0; counter = counter - 2)
            {
                oddNumbersBelowLongList.Add(x = x -2);
            }
            
            //Then add each number in the list oddNumbersBelowLongList so that numSum = num1 + num2 +num3...
            //The same problem that values are not stored in a for looop!
            for (int counter = 1; counter <= OddNumbersBelowLongList.Length - 1; counter = counter + 1)
            {
                OddNumbersBelowLongList[counter] = OddNumbersBelowLongList[counter - 1] + OddNumbersBelowLongList[counter];
            }
        }
    }
}
