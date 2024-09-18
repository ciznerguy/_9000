using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9000
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //1
        // param: positive number
        // return: sum of all numbers from 1 to n
        // n = 5 return 15 (1+2+3+4+5)
        public static int sum(int n)
        {
            return 0;
        }
        //2
        // param: positive number
        // return: n! (factorial n)
        // n = 4 return 24 (1*2*3*4)
        public static int factorial(int n)
        {
            return 0;

        }
        //3
        // param: positive number
        // return: num of digits
        // n = 2981 return 4
        public static int numOfDigits(int n)
        {
            return 0;


        }
        //4
        // param: positive number
        // return: sum of digits over and over until sum is one digit
        // 991 -> 19 -> 10 -> 1
        public static int sumOfDigits(int n) //פעולה עוטפת
        {
            return 0;

        }
        public static int sumOfDigitsHelp(int n)
        {
            return 0;

        }
        //5
        // param: double number
        // return: fractional part
        // 991.123 -> 0.123
        // use only +/-
        public static double fractionalPart(double num)
        {
            return 0;


        }
        //6
        // param: positive number
        // return: product of odd numbers from 1 to n
        // n = 5 return 15 (1*3*5)
        // n = 6 return 15 (1*3*5)
        public static int oddsProduct(int n)
        {
            if (n % 2 == 0)
                n--;
            return oddsProductHelp(n);
        }
        public static int oddsProductHelp(int n)
        {
            if (n == 1) return 1;

            return n * oddsProductHelp(n - 2);
        }
        //7
        // param: 2 positive numbers
        // return: n*m
        // use only +/-
        // n=8 m=2 reuslt = 16
        // n=10 m=3 result = 30
        public static int mult(int n, int m)
        {
            if (m == 0)
                return 0;
            return n + mult(n, m - 1);
        }
        //8
        // param: 2 positive numbers
        // return: n/m
        // use only +/-
        // n=8 m=2 reuslt = 4
        // n=10 m=3 result = 3
        public static int quotient(int n, int m)
        {
            if (n == m) return 1;
            if (n < m) return 0;
            return (1 + quotient(n - m, m));
        }
        //9
        // param: 2 positive numbers
        // return: n%m
        // use only +/-
        // n=8 m=2 reuslt = 0
        // n=10 m=3 result = 1
        public static int remainder(int n, int m)
        {
            if (n < m) return n;
            return remainder((n - m), m);

        }
        //10
        // param: positive number
        // return: biggestDifferenceBetweenTwoAdjacentDigits
        // n = 291655 return 8 (9-1 > 9-2,6-1,6-5,5-5)
        public static int biggestDifferenceBetweenTwoAdjacentDigits(int num)
        {
            if (num < 10) return 0;
            int leftDiff = biggestDifferenceBetweenTwoAdjacentDigits(num / 10);
            int rightDiff = num % 10 - (num / 10) % 10;
            if (rightDiff > leftDiff)
                return rightDiff;
            return leftDiff;
        }

        public static int biggestDiff2(int num) //another solution for the above
        {
            if (num < 10) return 0;
            int digit = num % 10;
            num = num / 10;
            return Math.Max(Math.Abs(digit - num % 10), biggestDiff2(num));
        }




    }
}