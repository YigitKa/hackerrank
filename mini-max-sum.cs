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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long retMax = 0;
        long retMin = 0;
         arr.Sort();
         
        for (int i = 0; i < arr.Count; i++)
        {
            if (i == 0)
            {
                retMin = retMin + arr[i];
                continue;
            }
            
            if (i == arr.Count - 1)
            {
                retMax = retMax + arr[i];
                continue;
            }
            retMin  = retMin+ arr[i];
            retMax = retMax + arr[i];
        }
        
        Console.Write(retMin + " " + retMax);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
