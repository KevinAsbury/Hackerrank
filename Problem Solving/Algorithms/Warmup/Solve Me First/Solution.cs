using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{

    static int solveMeFirst(int a, int b) 
    { 
      // Hint: Type return a+b; below  
      return a + b;
    }

    static void Main(String[] args) 
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }
        
        string[] input = File.ReadAllLines("input.txt");
        int val1 = Convert.ToInt32(input[0]);
        int val2 = Convert.ToInt32(input[1]);
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}