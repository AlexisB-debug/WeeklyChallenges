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

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
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
    }
}
