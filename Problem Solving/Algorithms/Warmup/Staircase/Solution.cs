using System;
using System.IO;

class Solution
{
    static void staircase(int n)
    {
        string s = "";
        int x = n - 1;

        for (int i = 0; i < n; i++)
        {
            var line = new String(' ', x);
            s += "#";
            Console.WriteLine(line + s);
            x -= 1;
        }
    }

    static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        string[] input = File.ReadAllLines("input.txt");
        int n = Convert.ToInt32(input[0]);

        staircase(n);
    }
}