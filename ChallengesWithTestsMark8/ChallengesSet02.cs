using System;
using System.Collections.Generic;

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
                numbers[counter + 1] = numbers[counter] + numbers[counter + 1];
            }

            for (int counter = 1; counter <= numbers.Length - 1; counter = counter + 1)
            {
                numbers[counter] = numbers[counter - 1] + numbers[counter];
            }

            for (int counter = 0; counter <= numbers.Length - 1; counter = counter + 1)
            {
                int i = numbers[counter];
                int j = numbers[counter + 1];
                int k == i + j;
            }
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
