using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar)
    {
        int sum = 0;

        foreach (var num in ar) sum += num;

        return sum;
    }

    static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        string[] lines = File.ReadAllLines("input.txt");

        int n = Convert.ToInt32(lines[0].TrimEnd());
        int[] ar = new int[n];

        ar = Array.ConvertAll(lines[1].Split(' '), arTemp => Convert.ToInt32(arTemp));

        int result = simpleArraySum(ar);
        Console.WriteLine(result);
    }
}