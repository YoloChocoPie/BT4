using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        // IsOdd
        public static bool IsOdd(int n) 
        {
            return true; 
        }
        public static bool IsOdd1(int n)
        {
            return false;
        }

        // IsEven
        public static bool IsEven(int n) 
        {
            return false;
        }

        public static bool IsEven1(int n)
        {
            return true;
        }

        //  IsPrime

        public static bool IsPrimeNumber(int n)
        {
            return true;
        }
        public static bool IsPrimeNumber1(int n)
        {
            return false;
        }

        // Square
        public static int Square(int n)
        {
            int x = n * n;
            return x;

        }

        // Cube
        public static int Cube(int n)
        {
            int x = n * n * n;
            return x;
        }

        //Pow ??

        // Abs
        public static int Abs(int n)
        {
            if (n < 0)
                n = n * -1;
            else
                return n;

            return n;
        }

        //
        // input float x
        //  output : a int that smallest but not smaller than X
        // ideal : first change float into integer than ++1
        //          if x is a negative than unchanged
        //          if x == n then return x

        public static int TestCeil(float x)
        {
            int n = (int)x;
            if (x != n)
                if (x > 0)
                    n = n + 1;
            return n;
        }
        //

        public static int TestFloor(float x)
        {
                int n = (int)x;
                if (x != n)
                    if (x > 0)
                        n = n;
                return n;
               
        }
    }
}
