using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> newGrades = new List<int>();

        foreach (int grade in grades)
        {
            int rounded = grade;

            if (rounded > 37)
            {
                if (5 - (grade % 5) < 3)
                {
                    rounded = grade + 5 - (grade % 5);
                }
            }

            newGrades.Add(rounded);
        }

        return newGrades;
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

        string[] input = File.ReadAllLines("input.txt");

        int gradesCount = Convert.ToInt32(input[0].Trim());

        List<int> grades = new List<int>();

        for (int i = 1; i < gradesCount + 1; i++)
        {
            int gradesItem = Convert.ToInt32(input[i].Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));
    }
}