using System;
using System.IO;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a,
        int b, int[] apples, int[] oranges)
    {
        int aCount = 0;
        int bCount = 0;

        foreach (int apple in apples)
        {
            if (apple > 0)
            {
                int d = a + apple;
                if (d >= s && d <= t) aCount += 1;
            }

        }

        foreach (int orange in oranges)
        {
            if (orange < 0)
            {
                int d = b + orange;
                if (d >= s && d <= t) bCount += 1;
            }

        }

        Console.WriteLine(aCount);
        Console.WriteLine(bCount);
    }

    static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        string[] input = File.ReadAllLines("input.txt");

        string[] st = input[0].Split(' ');
        int s = Convert.ToInt32(st[0]);
        int t = Convert.ToInt32(st[1]);

        string[] ab = input[1].Split(' ');
        int a = Convert.ToInt32(ab[0]);
        int b = Convert.ToInt32(ab[1]);

        int[] apples = Array.ConvertAll(input[3].Split(' '),
            applesTemp => Convert.ToInt32(applesTemp));

        int[] oranges = Array.ConvertAll(input[4].Split(' '),
            orangesTemp => Convert.ToInt32(orangesTemp));

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}