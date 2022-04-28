
using System;
using System.Collections.Generic;

namespace GenericsProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>  Welcome to GENERICS  <<<<\n");
            int[] intArr = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArr = { 1.2, 2.3, 3.4, 4.5, 5.6 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f' };
            PrintArray array = new PrintArray();
            Console.WriteLine("Values of Integer Array : ");
            array.ToPrint(intArr);
            Console.WriteLine("Values of double Array :");
            array.ToPrint(doubleArr);
            Console.WriteLine("Values of Char Array :");
            array.ToPrint(charArr);
        }
    }
}