using System;
using System.Linq;

namespace RemoveDublicateArray
{
    class Program
    {
        static int[] RemoveDublicate(int[] myArray)
        {
            int c = 0;
            int s = myArray.Length;
            int[] result = new int[s];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (!result.Contains(myArray[i]))
                    result[c] = myArray[i];
            }
            Array.Resize(ref result, c);
            return result;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 4, 6, 2 };

            int[] result = RemoveDublicate(myArray);
        }
    }
}
