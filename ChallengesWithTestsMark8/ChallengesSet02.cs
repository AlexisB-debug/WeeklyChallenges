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
            List<double> numbersList = numbers.ToList();
             if (numbersList.Count == 0)
             {
                 throw new ArgumentException("null");
             }

            double minimum = numbersList[0];
            for (int counter = 1; counter <= numbersList.Count - 1; counter = counter + 1)
            {
                if (numbersList[counter] < minimum)
                {
                    minimum = numbersList[counter];
                }
            }

            double maximum = numbersList[0];
            for (int counter = 1; counter <= numbersList.Count - 1; counter = counter + 1)
            {
                if (numbersList[counter] > maximum)
                {
                    maximum = numbersList[counter];
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
            int x = 0;
            for (int counter = 0; counter <= numbers.Length - 1; counter = counter + 1)
            {
                //int x = 0;
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
            
            int[] evenNumbersArray = numbersList.ToArray();
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
                //return cardinality;
            }
            else // number > 0
            {
                if (number == (number / 1))//If 'long number' is an integer, then 'number' is not 'below' 'number'
                {
                    cardinality = number / 2;
                    //return cardinality;
                }
                else //(0 < (number / 1) < number < (number / 1) + 1)
                {
                    if ((number / 1) % 2 == 0)
                    {
                        cardinality = (number / 1) / 2;
                        //return cardinality;
                    }
                    else //((number / 1) % 2 != 0)
                    {
                        cardinality = (number / 1) /2 + 1;
                        //return cardinality;
                    }
                }
            }
            //If I return "cardinality" within the if-scope of the if-else statement, then the else is unreachable.
            //If I return "cardinality outside the if-else statements, then it does not exist.
            return cardinality;
        }
    }
}