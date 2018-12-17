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
            string temp=Console.ReadLine();
            int place_num=int.Parse(temp);
          　string[] temp_d = Console.ReadLine().Split(' ');
            int tempature_base=int.Parse(temp_d[0]);
            int target=int.Parse(temp_d[1]);
            string[] temp_h = Console.ReadLine().Split(' ');
            double[] tempature_place=new double[place_num];
            double abs=1000000;
            int output=0;
            for(int i=0;i<place_num;i++){
            int h=int.Parse(temp_h[i]);
            tempature_place[i]=tempature_base-h*0.006d;
              if(abs>Math.Abs(tempature_place[i]-target))
              {abs=Math.Abs(tempature_place[i]-target);
               output=i+1;             
              }
            }
            
            Console.WriteLine(output);
        }
    }
}
