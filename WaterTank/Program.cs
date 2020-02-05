using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTank
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                WaterTank wt = new WaterTank(int.Parse(args[0]), int.Parse(args[1]), int.Parse(args[2]));
                wt.Solve();
                wt.print();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please check argmuments");
            }
        }
    }
}
