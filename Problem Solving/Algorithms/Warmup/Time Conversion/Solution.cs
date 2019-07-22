using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static string timeConversion(string s) 
    {
        bool pm = false;
        int hour = Convert.ToInt32($"{s[0]}{s[1]}");
        string h = "00";
        string m = s.Substring(2, 6);

        if (s.ToUpper()[8] == 'P') pm = true;
        if (!pm && hour == 12) hour = 0;
        if (pm && hour != 12) hour += 12;
        if (hour > 9) h = hour.ToString();
        if (hour < 10) h = $"0{hour.ToString()}";

        return h + m;
    }

    static void Main(string[] args) 
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }
        
        string[] s = File.ReadAllLines("input.txt");

        string result = timeConversion(s[0]);

        Console.WriteLine(result);
    }
}
