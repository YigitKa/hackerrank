using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static int CalcSize(int cycle)
        {
            int Size = 1;
            for (int i = 0; i < cycle; i++)
            {
                if ((i % 2) == 0)
                    Size = Size * 2;
                else
                    Size = Size + 1;
            }
            return Size;

        }
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            int[] N = new int[T];

            for (int i = 0; i < T; i++)
            {
                N[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine(CalcSize(N[i]));
            }
            Console.ReadLine();
        }
    }
}
