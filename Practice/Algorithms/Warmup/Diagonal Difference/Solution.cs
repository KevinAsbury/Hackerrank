using System;
// using System.CodeDom.Compiler;
// using System.Collections;
using System.Collections.Generic;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
using System.IO;
using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text;
// using System.Text.RegularExpressions;

class Result {

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr) {
        int x = 0, y = 0, n = arr.Count();

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i == j) x += arr[i][j];

                if (i == n - j - 1) y += arr[i][j];
            }
        }

        return Math.Abs(x - y);
    }

}

class Solution {
    public static void Main(string[] args) {
        if (!File.Exists("input.txt")) {
            Console.WriteLine("Missing input.txt file.");
            return;
        }

        string[] input = File.ReadAllLines("input.txt");
        int n = Convert.ToInt32(input[0].Trim());
        List<List<int>> arr = new List<List<int>>();

        for (int i = 1; i < n + 1; i++) {
            arr.Add(input[i].TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}