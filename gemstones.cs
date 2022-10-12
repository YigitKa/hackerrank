using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void PrintGems(string[] s)
        {
            int[] map = new int['z' - 'a' + 1];

            for (int i = 0; i < s.Length; i++)
            {
                int[] intmap = new int['z' - 'a' + 1];

                for (int j = 0; j < s[i].Length; j++)
                {
                    if (intmap[s[i][j] - 'a']++ == 0)
                    {
                        map[s[i][j] - 'a']++;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == s.Length)
                    sum++;
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] S = new string[N];

            for (int i = 0; i < N; i++)
            {
                S[i] = Console.ReadLine();
            }

            PrintGems(S);
            Console.ReadLine();
        }
    }
}
