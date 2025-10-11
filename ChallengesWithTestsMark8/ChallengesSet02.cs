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
            for (int counter = 0; counter <= numbers.Count - 1; counter = counter + 1)
            {
                int z = 0;
                z = z + numbers[counter];
            }

            bool SumIsOdd;
            if (z % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                if (number % 2 == 0)
                {
                     long x = (number / 2) * 2 - 1;
                    return x;
                }
                else
                {
                    long y = (number / 2) * 2 + 1;
                    return y;
                }
            }
        }
    }
}
