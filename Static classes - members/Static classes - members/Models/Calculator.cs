using System;
using System.Collections.Generic;
using System.Text;

namespace Static_classes___members_.Models
{
    static class Calculator
    {
        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }

    }
}
