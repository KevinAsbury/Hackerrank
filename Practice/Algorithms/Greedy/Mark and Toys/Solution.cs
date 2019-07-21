using System;
using System.IO;
using System.Linq;

class Solution
{

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {
        int[] afford = Array.FindAll(prices, p => p <= k);
        Array.Sort(afford);
        int sum = 0;
        int count = 0;

        for (int i = 0; i < afford.Count(); i++)
        {
            if ((afford[i] + sum) <= k)
            {
                count += 1;
                sum += afford[i];
            }
        }

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
        string[] nk = input[0].Split(' ');

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(input[1].Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

        int result = maximumToys(prices, k);

        Console.WriteLine(result);
    }
}