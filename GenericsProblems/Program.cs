
using System;
using System.Collections.Generic;

namespace GenericsProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 50, 42, 543, 545, 21, 43, 90 };
            PrintArray intArray = new PrintArray();
            intArray.MaxInteger(arr);
        }
    }
}