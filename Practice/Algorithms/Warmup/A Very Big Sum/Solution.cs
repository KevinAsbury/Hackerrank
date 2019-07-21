using System;
using System.IO;
using System.Linq;

class Solution {

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum (long[] ar) {
        return ar.Sum ();
    }

    static void Main (string[] args) {
        if (!File.Exists ("input.txt")) {
            Console.WriteLine ("Missing input.txt file.");
            return;
        }

        string[] input = File.ReadAllLines ("input.txt");

        int arCount = Convert.ToInt32 (input[0]);
        long[] ar = Array.ConvertAll (input[1].Split (' '), arTemp => Convert.ToInt64 (arTemp));
        long result = aVeryBigSum (ar);

        Console.WriteLine (result);
    }
}