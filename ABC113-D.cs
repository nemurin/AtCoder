using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    namespace Competitive
    {
        internal class Solution
        {
            public int H, W, K;
            public long MOD = 1000000007;
            public int[] used;
            public long[,] DP;
            public void Run()
            {
                {
                    var line = Input.ReadIntArray();
                    H = line[0];
                    W = line[1];
                    K = line[2];
                }

                DP = new long[H + 1, W];
                DP[0, K - 1] = 1;

                for (int i = 1; i <= H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        DP[i, j] += DP[i - 1, j] * Comb(j) * Comb(W - (j + 1));
                        DP[i, j] %= MOD;
                        if (j > 0) DP[i, j] += DP[i - 1, j - 1] * Comb(j - 1) * Comb(W - (j + 1));
                        DP[i, j] %= MOD;
                        if (j < W - 1) DP[i, j] += DP[i - 1, j + 1] * Comb(j) * Comb(W - (j + 2));
                        DP[i, j] %= MOD;
                    }
                }

                Console.WriteLine(DP[H, 0]);
            }

            public long Comb(int w)
            {
                if (w < 0) return 0;
                if (w <= 1) return 1;
                if (w == 2) return 2;
                return Comb(w - 1) + Comb(w - 2);
            }
        }

        // libs ----------


        // common ----------

        internal static class Input
        {
            public static string ReadString()
            {
                string line = Console.ReadLine();
                return line;
            }

            public static int ReadInt()
            {
                string line = Console.ReadLine();
                return int.Parse(line);
            }

            public static int[] ReadIntArray()
            {
                string line = Console.ReadLine();
                return line.Split(' ').Select(int.Parse).ToArray();
            }

            public static long ReadLong()
            {
                string line = Console.ReadLine();
                return long.Parse(line);
            }

            public static long[] ReadLongArray()
            {
                string line = Console.ReadLine();
                return line.Split(' ').Select(long.Parse).ToArray();
            }

            public static double[] ReadDoubleArray()
            {
                string line = Console.ReadLine();
                return line.Split(' ').Select(double.Parse).ToArray();
            }
        }

        internal class Program
        {
            public static void Main(string[] args)
            {
                var s = new Solution();
                s.Run();
            }
        }
    }
}
