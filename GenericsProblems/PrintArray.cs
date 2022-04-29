using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class PrintArray
    {
        int index;
        public void MaxInteger(int[] arr)
        {
            int max = arr[0];
            for (index = 1; index < arr.Length; index++)
                if (arr[index] > max)
                {
                    max = arr[index];
                }
            Console.WriteLine("Maximum Integer Value in Array is : " + max);
        }
        public void MaxDouble(double[] arrd)
        {
            double maxd = arrd[0];
            for (index = 1; index < arrd.Length; index++)
                if (arrd[index] > maxd)
                {
                    maxd = arrd[index];
                }
            Console.WriteLine("Maximum Double Value in Array is : " + maxd);
        }public void MaxChar(char[] arrd)
        {
            double maxc = arrd[0];
            for (index = 1; index < arrd.Length; index++)
                if (arrd[index] > maxc)
                {
                    maxc = arrd[index];
                }
            Console.WriteLine("Maximum Char Value in Array is : " + maxc);
        }
    }
}