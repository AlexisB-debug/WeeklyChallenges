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

            foreach (char letter in alphabet)
            {
                if (letter == c)
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
            if (num % 2 != 0)
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
            // List<double> numbersList = numbers.ToList();
            // if (numbersList == null)
            // {
            //     return 0;
            // }
            //
            // if (numbersList.Count() == 0)
            // {
            //     return 0;
            // }
            //
            // double minimum = numbersList[0];
            // for (int counter = 1; counter <= numbersList.Count - 1; counter = counter + 1)
            // {
            //     if (numbersList[counter] < minimum)
            //     {
            //         minimum = numbersList[counter];
            //     }
            // }
            //
            // double maximum = numbersList[0];
            // for (int counter = 1; counter <= numbersList.Count - 1; counter = counter + 1)
            // {
            //     if (numbersList[counter] > maximum)
            //     {
            //         maximum = numbersList[counter];
            //     }
            // }
            // double sum = minimum + maximum;
            // return sum;
            
            if (numbers == null)
            {
                return 0;
            }
            
            if (numbers.Count() == 0)
            {
                return 0;
            }
            
            return numbers.Min() + numbers.Max();
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
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            for (int counter = 0; counter <= numbers.Length - 1; counter = counter + 1)
            {
                //int x = 0;
                sum = sum + numbers[counter];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            List<int> numbersList = numbers.ToList();

            for (int counter = 0; counter <= numbersList.Count - 1; counter = counter + 1)
            {
                int number = numbersList[counter];
                if (number % 2 != 0)
                {
                    numbersList.RemoveAt(counter);
                }
            }
            
            int[] evenNumbersArray = numbersList.ToArray();

            if (evenNumbersArray.Length == 1)
            {
                return evenNumbersArray[0];
            }

            int y = 0;
            for (int counter = 0; counter <= evenNumbersArray.Length - 1; counter = counter + 1)
            {
                //int y = 0;
                y = y + evenNumbersArray[counter];
            }
            return y;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int z = 0;
            for (int counter = 0; counter <= numbers.Count - 1; counter = counter + 1)
            {
                //int z = 0;
                z = z + numbers[counter];
            }

            //bool SumIsOdd;
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
            long cardinality = 0;
            //The cardinal number of elements in a set of odd numbers is an integer; Why is the return type a long?
            if (number <= 0)
            {
                cardinality = 0;
            }
            else // number > 0
            {
                if (number == (number / 1))//If 'long number' is an integer, then 'number' is not 'below' 'number'
                {
                    cardinality = number / 2;
                }
                else //(0 < (number / 1) < number < (number / 1) + 1)
                {
                    if ((number / 1) % 2 == 0)
                    {
                        cardinality = (number / 1) / 2;
                    }
                    else //((number / 1) % 2 != 0)
                    {
                        cardinality = (number / 1) / 2 + 1;
                    }
                }
            }
            return cardinality;
        }
    }
}