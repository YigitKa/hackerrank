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
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        string inputText = s;
        int colCount = (int)Math.Ceiling(Math.Sqrt(inputText.Length));
        string encryptedText = string.Empty;
        for (int i = 0; i < colCount; i++)
        {
            int counter = 0;
            while (i + (counter * colCount) < inputText.Length)
            {
                encryptedText += inputText[i + (counter * colCount)];
                counter++;
            }
            encryptedText += " ";
        }
        return encryptedText;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
