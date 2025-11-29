using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            if (ignoreCase == true)
            {
                foreach (string w in words)
                {
                    if (w != null)
                    {
                        if (w.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                    }
                }
            }

            if (ignoreCase == false)
            {
                foreach (string w in words)
                {
                    if (w == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            int[] primes = new[]
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101,
                103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211,
                223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313
            };

            if (num <= 0)
            {
                return false;
            }
            else if (num == 1)
            {
                return false;
            }
            else
            {
                foreach (int prime in primes)
                {
                    if (prime * prime > num)
                    {
                        break;
                    }

                    if (num % prime == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            char[] letters = new char[]
            {
                'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K',
                'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u',
                'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z'
            };
            char[] characters = str.ToCharArray();
            List<char> targets = new List<char>();
            foreach (char character in characters)
            {
                if (letters.Contains(character))
                {
                    targets.Add(character);
                }
            }

            Dictionary<char, int> targetCount = new Dictionary<char, int>();
            foreach (char letter in targets)
            {
                if (targetCount.ContainsKey(letter))
                {
                    targetCount[letter]++;
                }
                else
                {
                    targetCount.Add(letter, 1);
                }
            }

            for (int counter = targets.Count - 1; counter >= 0; counter--)
            {
                if (targetCount[targets[counter]] == 1)
                {
                    return counter;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] != numbers[i])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return [];
            }

            for (int counter = 0; counter < elements.Count; counter++)
            {
                if (elements[counter] % n != 0)
                {
                    elements.RemoveAt(counter);
                    counter--;
                }
            }

            return elements.ToArray();
        }
    }
}