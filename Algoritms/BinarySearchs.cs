﻿namespace Algoritms
{
    public class BinarySearchs
    {
        public static int BinarySearch(int[] array, int number)
        {
            int p = 0;
            int r = array.Length - 1;
            while (p <= r)
            {
                double d = (p + r) / 2;
                //int q = (p + r) / 2;
                int q = (int)Math.Round(d, MidpointRounding.ToZero);
                if (array[q] == number) return q;
                else if (array[q] > number) r = q - 1;
                else p = q + 1;
            }
            return -1;
        }

        public static int RecursiveBinarySearch(int[] array, int number, int p = 0, int r = 0)
        {
            if (p > r) return -1;
            else
            {
                double d = (p + r) / 2;
                //int q = (p + r) / 2;
                int q = (int)Math.Round(d, MidpointRounding.ToZero);
                if (array[q] == number) return q;
                else if (array[q] > number) return RecursiveBinarySearch(array, number, p, q - 1);
                else return RecursiveBinarySearch(array, number, q + 1, r);
            }
        }

    }
}
