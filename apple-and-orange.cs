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
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int hitByAppleCount = 0;
        int hitByOrangeCount = 0;
        
        int samsHouseStart = s;
        int samsHouseEnd = t;
        
        int locAppleTree = a;
        int locOrangeTree = b;
        
        foreach (int fallingApple in apples)
        {
            int exactFallingAppleLoc = locAppleTree + fallingApple;
            bool afterHouseStart = exactFallingAppleLoc >= samsHouseStart;
            bool beforeHouseEnd = exactFallingAppleLoc <= samsHouseEnd;
            
            if (afterHouseStart && beforeHouseEnd)
            {
                hitByAppleCount++;
                continue;
            }
        }
        
         foreach (int fallingorange in oranges)
        {
            int exactFallingOrangeLoc = fallingorange + locOrangeTree;
            bool afterHouseStart = exactFallingOrangeLoc >= samsHouseStart;
            bool beforeHouseEnd = exactFallingOrangeLoc <= samsHouseEnd;
            
            if (afterHouseStart && beforeHouseEnd)
            {
                hitByOrangeCount++;
                continue;
            }
        }
        
        Console.WriteLine(hitByAppleCount);
        Console.WriteLine(hitByOrangeCount);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
