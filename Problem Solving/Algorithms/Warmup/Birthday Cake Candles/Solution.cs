using System;
using System.IO;

class Solution
{
    static int birthdayCakeCandles(int[] ar)
    {
        int height = 0;
        int count = 0;

        foreach (int num in ar)
            if (num > height) height = num;

        foreach (int num in ar)
            if (num == height) count += 1;

        return count;
    }

    static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        string[] input = File.ReadAllLines("input.txt");

        int[] ar = Array.ConvertAll(input[1].Split(' '), arTemp => Convert.ToInt32(arTemp));

        int result = birthdayCakeCandles(ar);

        Console.WriteLine(result);
    }
}