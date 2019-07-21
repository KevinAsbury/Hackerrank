using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b) {
        var aScore = 0;
        var bScore = 0;
        var setOne = a[0].CompareTo(b[0]);
        var setTwo = a[1].CompareTo(b[1]);
        var setThree = a[2].CompareTo(b[2]);

        aScore += (setOne == 1) ? 1 : 0;
        bScore += (setOne == -1) ? 1 : 0;  

        aScore += (setTwo == 1) ? 1 : 0;
        bScore += (setTwo == -1) ? 1 : 0;  

        aScore += (setThree == 1) ? 1 : 0;
        bScore += (setThree == -1) ? 1 : 0; 

        return new List<int> { aScore, bScore }; 
    }

    static void Main(string[] args) 
    {
        if (!File.Exists("input.txt"))
        {
            Console.WriteLine("Missing input.txt file.");
            return;
        }
        
        string[] input = File.ReadAllLines("input.txt");

        List<int> a = input[0].TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = input[1].TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
    }
}
