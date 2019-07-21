using System.Collections;
using System.IO;
using System.Linq;
using System;

class Solution
{

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        double negatives = 0d;
        double zeros = 0d;
        double positivies = 0d;
        int n = arr.Count();

        foreach (int num in arr)
        {
            if (num < 0) negatives += 1;
            if (num == 0) zeros += 1;
            if (num > 0) positivies += 1;
        }

        Console.WriteLine(String.Format("{0:0.000000}", positivies / n));
        Console.WriteLine(String.Format("{0:0.000000}", negatives / n));
        Console.WriteLine(String.Format("{0:0.000000}", zeros / n));
    }

    static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        string[] lines = File.ReadAllLines("input.txt");

        int[] arr = Array.ConvertAll(lines[1].Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        plusMinus(arr);
    }
}