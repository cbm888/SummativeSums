﻿using System;

namespace SummativeSums
{
    static class Program
    {
        static void Main(string[] args)
        {
            GetArraySums();
        }
        public static void GetArraySums()
        {
            int sum = 0;
            int[] array1 = new int[] { 1, 90, -33, -55, 67, -16, 28, -55, 15 };

            int[] array2 = new int[] { 999, -60, -77, 14, 160, 301 };

            int[] array3 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };

            for (int i = 0; i < array1.Length; i++)  //iterate through items of each array
            {
                sum += array1[i];   //get the sum of array elements
            }
            Console.WriteLine(sum);  //print sum of elements

            sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                
                sum += array2[i];
            }
            Console.WriteLine(sum);
            sum = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                sum += array3[i];
            }
            Console.WriteLine(sum);
        }
    }
}
