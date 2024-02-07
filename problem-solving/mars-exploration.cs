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
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
        string[] splitted = s.Split("SOS", StringSplitOptions.RemoveEmptyEntries);
        
        // bazı ihtimaller baştn elenmeli
        if (splitted.Length == s.Length - 1 / 3)
        {
            return 0;
        }
        
        int diffCount = 0;
        for (int i = 0; i < s.Length; i = i + 3)
        {
            if (i == s.Length)
            {
                return diffCount;
            }
            string sos = s.Substring(i, 3);
            if (sos != "SOS")
            {
              if (sos[0] != 'S')
                diffCount++;
              if (sos[1] != 'O')
                diffCount++;
              if (sos[2] != 'S')
                diffCount++;
            }
        }
        return diffCount;
    }
    }

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
