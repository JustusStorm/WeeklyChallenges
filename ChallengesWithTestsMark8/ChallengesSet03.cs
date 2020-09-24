using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool result = false;
            foreach (var val in vals)
            {
                if (val == false)
                {
                    result = true;
                }
                
            }
            return result;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            int sumOfOdds = 0; 
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sumOfOdds += num;
                }
            }

            if (sumOfOdds % 2 != 0)
            {
                return true;
            }

            return false;
        
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNum = false;
            int num;

            foreach (var ch in password)
            {
                if (int.TryParse(ch.ToString(), out num))
                {
                    isNum = true;
                }
                else
                {
                    if (ch == char.ToUpper(ch))
                    {
                        isUpper = true;
                    }
                
                    if (ch == char.ToLower(ch))
                    {
                        isLower = true;
                    }
                }
            }
                if (isUpper & isLower & isNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0]; 
        }

        public int[] GetOddsBelow100()
        {
            var intList = new List<int>();
            for (int i = 1; i < 100; i += 2 )
            {
                intList.Add(i);
            }
            return intList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
