using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var result = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }
            return result;
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //var i = 0;
            //var length = new int[4];
            //var array = new object[]{ str1, str2, str3, str4 };
            //foreach (var str in array)
            //{

            //    var word = str.ToString();
            //    var stringLength = word.Length;
            //    length[i] = stringLength;

            //    i++;
            //}
            //return length.Min();

            var array = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            return array.Min();




        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var array = new int[] { number1, number2, number3, number4 };
            return array.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //var a = sideLength1;
            //var b = sideLength2;
            //var c = sideLength3;


            //if (a + b > c )
            //{
            //    if (b + c > a)
            //    {
            //        if (c + a > b)
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;

            var tri = sideLength1 + sideLength2 > sideLength3;
            var an = sideLength2 + sideLength3 > sideLength1;
            var gle = sideLength3 + sideLength1 > sideLength2;

            return tri && an && gle;
           
        }

        public bool IsStringANumber(string input)
        {
            decimal num;
            return decimal.TryParse(input, out num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullObjects = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    nullObjects++;
                }
            }

            return nullObjects > (objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            var evenNums = 0;
            List<int> newNumbers = new List<int>();

            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        evenNums++;
                        newNumbers.Add(num);
                    }
                }
            }

            if (evenNums == 0)
            {
                return 0;
            }
            else
            {
                return newNumbers.Average();
            }

            

            
            
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
