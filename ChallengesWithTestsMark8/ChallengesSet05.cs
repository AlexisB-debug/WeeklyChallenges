using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do
            {
                startNumber = startNumber + 1;
            } while (startNumber % n != 0);

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            IOrderedEnumerable<int> numbersAscend = numbers.OrderBy(n => n);
            if (!numbersAscend.SequenceEqual(numbers) || numbers.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            try
            {
                int sum = 0;

                for (int counter = 1; counter < numbers.Length; counter++)
                {
                    if (numbers[counter - 1] % 2 == 0)
                    {
                        sum = sum + numbers[counter];
                    }
                }

                return sum;
            }
            catch (NullReferenceException)
            {
                // throw new NullReferenceException();
                return 0;
            }
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            try
            {
                string[] wordsFiltered = words.Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
                IEnumerable<string> wordsWhiteSpaceStripped =
                    wordsFiltered.Select(w => new string(w.Where(c => !char.IsWhiteSpace(c)).ToArray()));
                string sentence = string.Join(" ", wordsWhiteSpaceStripped);
                return string.IsNullOrEmpty(sentence) ? "" : sentence + '.';
            }
            catch (ArgumentNullException)
            {
                // throw new ArgumentNullException();
                return "";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            try
            {
                List<double> fourthCollection = new List<double>();
                for (int counter = 3; counter < elements.Count; counter = counter + 4)
                {
                    fourthCollection.Add(elements[counter]);
                }

                return fourthCollection.ToArray();
            }
            catch (NullReferenceException)
            {
                // throw new NullReferenceException();
                return [];
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}