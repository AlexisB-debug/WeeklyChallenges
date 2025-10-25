using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (vals.Contains(false))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum = sum + number;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = PasswordContainsUpper(password);
            bool lower = PasswordContainsLower(password);
            bool number = PasswordContainsNumber(password);
            
            if (upper && lower && number)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpper(string password)
        {
            List<char> uppers = new List<char>()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };
            
            foreach (char upper in uppers)
            {
                if (password.Contains(upper))
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsLower(string password)
        {List<char> lowers = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };
            foreach (char lower in lowers)
            {
                if (password.Contains(lower))
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsNumber(string password)
        {
            List<char> numbers = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            
            foreach (char number in numbers)
            {
                if (password.Contains(number))
                {
                    return true;
                }
            }
            return false;
        }
        public char GetFirstLetterOfString(string val)
        {
            char[] valArray = val.ToCharArray();
            List<char> valChars = new List<char>(valArray);

            for (int counter = valChars.Count - 1; valChars.Count > 1; counter = counter - 1)
            {
                valChars.RemoveAt(counter);
            }
            
            char[] redactedValArray = valChars.ToArray();
            string redactedValsString = new string(redactedValArray);
            char firstLetter = Convert.ToChar(redactedValsString);
            return firstLetter;
        }
        public char GetLastLetterOfString(string val)
        {
            char[] valArray = val.ToCharArray();
            List<char> valChars = new List<char>(valArray);

            for (int counter = 0; counter < valChars.Count - 1; counter = counter + 1)
            {
                valChars.RemoveAt(counter);
                counter = counter - 1;
            }
            
            char[] redactedValArray = valChars.ToArray();
            string redactedValsString = new string(redactedValArray);
            char lastLetter = Convert.ToChar(redactedValsString);
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                decimal result = dividend / divisor;
                return result;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int lastMinusFirst = nums[nums.Length - 1] - nums[0];
            return lastMinusFirst;
        }

        public int[] GetOddsBelow100()
        {
            int[] oddsBelow = new int[50];
            
            for (int counter = 0; counter <= oddsBelow.Length - 1; counter = counter + 1)
            {
                int evenElement = 2 * counter + 2;
                int oddElement = evenElement - 1;
                oddsBelow[counter] = oddElement;
            }
            return oddsBelow;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int counter = 0; counter <= words.Length - 1; counter = counter + 1)
            {
                words[counter] = words[counter].ToUpper();
            }
        }
    }
}
