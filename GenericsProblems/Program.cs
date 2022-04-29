
using System;
using System.Collections.Generic;

namespace GenericsProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 50, 42, 543, 545, 21, 43, 90 };
            double[] doubleArr = { 1.2, 2.3, 3.4, 4.5, 5.6 };
            PrintArray intArray = new PrintArray();
            intArray.MaxInteger(arr);
            intArray.MaxDouble(doubleArr);
        }
    }
}