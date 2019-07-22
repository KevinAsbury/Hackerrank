using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{

    public static int getTotalX(List<int> a, List<int> b)
    {
        if (a.Max() > 100 || a.Min() < 1) return 0;
        if (b.Max() > 100 || b.Min() < 1) return 0;

        int count = 1;
        int total = 0;
        int considered = a.Max();

        while (considered <= b.Min())
        {
            bool factorOfAll = true;

            foreach (var num in a)
                if (considered % num != 0)
                {
                    factorOfAll = false;
                    break;
                }

            if (factorOfAll)
                foreach (var num in b)
                    if (num % considered != 0)
                    {
                        factorOfAll = false;
                        break;
                    }

            if (factorOfAll)
                total++;

            count++;
            considered = a.Max() * count;
        }

        return total;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        var input = File.ReadAllLines("input.txt");

        List<int> arr = input[1].TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = input[2].TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);
    }
}