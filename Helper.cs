using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class Helper
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static int Multi(int a, int b)
        {
            return a * b;
        }

        public static double Multi(double a, double b)
        {
            return a * b;
        }

        public static int Abs(int a)
        {   
            if (a < 0) 
                return a + (a * -2);
            return a;
        }

        public static double Abs(double a)
        {
            if (a < 0)
                return a + (a * -2);
            return a;
        }

        public static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

        public static double Min(double a, double b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        public static double Max(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
         
        //bonus
        public static double Expo(int _base, int power)
        {   
            if (power == 0)
                return 1;

            double baseDouble = _base;
            double result = _base;
            
            if (power < 0 && _base != 0)
            {
                baseDouble = 1d / baseDouble;
                result = baseDouble;
            }

            for (int i = 1; i < Helper.Abs(power); i++)
                result *= baseDouble;

            return result;
        }
    }
}
