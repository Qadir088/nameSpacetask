using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
      public  static void Main(int[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 3, 4, 7, 6 };
            İsArrayContains(arr1, arr2);
        }
        static bool İsArrayContains(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1.ToString().Contains(arr2.ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
