using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaterTank;

namespace WaterTankTest
{
    [TestClass]
    public class WaterTankTest
    {
        [TestMethod]
        public void solveGoodContainer()
        {
            WaterTankSolver waterTank = new WaterTankSolver(5, 3, 4);
            waterTank.solve();
            String solution = waterTank.PathSolve[waterTank.PathSolve.Count - 1];
            Assert.AreEqual("A -> B : (4,3)", solution);
        }

        [TestMethod]
        public void solveBadContainer()
        {
            WaterTankSolver waterTank = new WaterTankSolver(15, 3, 4);
            waterTank.solve();
            String solution = waterTank.PathSolve[waterTank.PathSolve.Count - 1];
            Assert.AreEqual("No Solution", solution);
        }
    }
}
