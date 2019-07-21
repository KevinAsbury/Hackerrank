using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void miniMaxSum(int[] arr)
    {
        int[][] newAr = new int[arr.Count()][];
        long[] sums = new long[arr.Count()];

        for (int i = 0; i < arr.Count(); i++)
        {
            var tempList = new List<int>(arr);
            tempList.RemoveAt(i);
            newAr[i] = tempList.ToArray();

            long sum = 0;

            foreach (int num in newAr[i])
            {
                sum += Convert.ToInt64(num);
                sums[i] = sum;
            }
        }

        Console.WriteLine($"{sums.Min()} {sums.Max()}");
    }

    static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        string[] input = File.ReadAllLines("input.txt");
        int[] arr = Array.ConvertAll(input[0].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        miniMaxSum(arr);
    }
}