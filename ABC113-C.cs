using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int N = int.Parse(str[0]);
            int M = int.Parse(str[1]);
            int[][] B = new int[M][];
            for (var i = 0; i < M; i++)
            {
                B[i] = new int[3];
                string[] str2 = Console.ReadLine().Split();
                B[i][0] = int.Parse(str2[0]);
                B[i][1] = int.Parse(str2[1]);
                B[i][2] = i;
            }
            Array.Sort(B, (x, y) => x[1] - y[1]);
            int[,] C = new int[M, 2];
            int[] D = new int[N];
            for (var i = 0; i < M; i++)
            {
                C[B[i][2], 0] = B[i][0];
                C[B[i][2], 1] = D[B[i][0] - 1] + 1;
                D[B[i][0] - 1] += 1;
            }
            string[] E = new string[M];
            for (var i = 0; i < M; i++)
            {
                string a1 = "000000" + C[i, 0].ToString();
                a1 = a1.Substring(a1.Length - 6, 6);
                string a2 = "000000" + C[i, 1].ToString();
                a2 = a2.Substring(a2.Length - 6, 6);
                E[i] = a1 + a2;
            }
            for (var i = 0; i < M; i++)
            {
                Console.WriteLine(E[i]);
            }
        }
    }
}
