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
     * Complete the 'timeInWords' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER h
     *  2. INTEGER m
     */

    public static string timeInWords(int h, int m)
    {
        string[] hourWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
        
        string[] minuteWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
                                    , "eleven", "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty"
                                    , "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight","twenty nine" };

        if (m == 0)
        {
            return $"{hourWords[h - 1]} o' clock";
        }
        if ((m > 0 && m < 15) || (m > 15 && m < 30))
        {
            return $"{minuteWords[m - 1]} minutes past {hourWords[h - 1]}";
        }

        if ((m > 30 && m < 45) || (m > 45 && m < 60))
        {
          return $"{minuteWords[60 - m - 1]} minutes to {hourWords[h]}";
        }

        if (m == 15)
        {
           return $"quarter past {hourWords[h - 1]}";
        }

        if (m == 30)
        {
           return $"half past {hourWords[h - 1]}";
        }

        if (m == 45)
        {
            return $"quarter to {hourWords[h]}";
        }
        return string.Empty;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine().Trim());

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
