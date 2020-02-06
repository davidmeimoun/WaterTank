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
                WaterTankSolver waterTank = new WaterTankSolver(int.Parse(args[0]), int.Parse(args[1]), int.Parse(args[2]));
                waterTank.solve();
                waterTank.print();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please check argmuments");
            }
        }
    }
}
