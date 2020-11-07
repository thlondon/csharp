using System;
using System.Linq;

namespace Array
{
    class Program
    {
              static int[] RemoveDublicate(int[] myArray, int[] Result)
              {
              return Result = myArray.Distinct().ToArray();
              }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 2, 3, 4, 4, 7, 8};
            int s = myArray.Length;
            int[] Result = new int [s];
            Result = RemoveDublicate(myArray, Result);
 
            Console.ReadLine();
        }
    }
}
