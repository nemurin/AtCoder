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
            //ABC113-A
            string[] temp = Console.ReadLine().Split(' ');
            int AtoB = int.Parse(temp[0]);
            int BtoC = int.Parse(temp[1]) / 2;
            Console.WriteLine(AtoB+BtoC);
        }
    }
}
