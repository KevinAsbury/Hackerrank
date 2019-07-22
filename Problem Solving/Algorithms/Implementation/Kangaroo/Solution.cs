using System;
using System.IO;

class Solution
{

    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 == v2 && x1 == x2) return "YES";

        // The Loop Method
        int i = 0, j1 = x1, j2 = x2;

        do
        {
            j1 += v1;
            j2 += v2;

            if (j1 == j2) return "YES";

            i++;
        } while (i < 10001);

        return "NO";
    }

    static void Main(string[] args)
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }
        
        string[] input = File.ReadAllLines("input.txt");

        string[] x1V1X2V2 = input[0].Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);
        int v1 = Convert.ToInt32(x1V1X2V2[1]);
        int x2 = Convert.ToInt32(x1V1X2V2[2]);
        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}