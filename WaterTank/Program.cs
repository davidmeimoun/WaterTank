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

                WaterTankModel model = new WaterTankModel(5, 3, 4);
                Solver.solve(model);
                Solver.print(model); ;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please check argmuments");
            }
        }
    }
}
