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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positives = 0;
        int negatives = 0;
        int zeros = 0;
        
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < 0)
                negatives = negatives + 1;
            else if (arr[i] == 0)
                zeros = zeros + 1;
            else if (arr[i] > 0)
                positives = positives + 1;
        }
        
        int sum = negatives + positives + zeros;
        decimal divided = (decimal)sum / (decimal)arr.Count;
        
        Console.WriteLine(((decimal)positives / arr.Count).ToString("N6"));
        Console.WriteLine(((decimal)negatives / arr.Count).ToString("N6"));
        Console.WriteLine(((decimal)zeros / arr.Count).ToString("N6"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
