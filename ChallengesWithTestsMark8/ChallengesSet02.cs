using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);    
        }
        
        public bool CountOfElementsIsEven(string[] vals)
        {
            //bool IsNumberEven = false;

            //if (vals.Length % 2 == 0)
            //{
            //    IsNumberEven = true;
            //}

            //return IsNumberEven;

            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers?.Any() != true )
            {
                return 0;
            }
            else
            {
                return (numbers.Max() + numbers.Min());
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers?.Any() != true)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers?.Any() != true)
            {
                return sum;
            }
            else
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }

                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers?.Any() != true)
            {
                return  false;
            }
            else
            {
                var sum = numbers.Sum();
                return sum % 2 != 0;
            }
           
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddSum = 0;
            for (var i = 1; i < number; i += 2)
            {
                oddSum += 1;
            }

            return oddSum;
        }
    }
}
