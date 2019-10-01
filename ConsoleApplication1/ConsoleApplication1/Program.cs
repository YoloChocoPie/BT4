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

        // Bai 1
        public static bool IsOdd(int n) 
        {
            return true; 
        }
        public static bool IsOdd1(int n)
        {
            return false;
        }

        // Bai 2
        public static bool IsEven(int n) 
        {
            return false;
        }

        public static bool IsEven1(int n)
        {
            return true;
        }

        //Bai3

        public static bool IsPrimeNumber(int n)
        {
            return true;
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
