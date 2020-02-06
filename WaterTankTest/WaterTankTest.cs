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
            WaterTankModel model = new WaterTankModel(5, 3, 4);
            Solver.solve(model);
            String solution = model.PathSolve[model.PathSolve.Count - 1];
            Assert.AreEqual("A -> B : (4,3)", solution);
        }

        [TestMethod]
        public void solveBadContainer()
        {
            WaterTankModel model = new WaterTankModel(15, 3, 4);
            Solver.solve(model);
            String solution = model.PathSolve[model.PathSolve.Count - 1];
            Assert.AreEqual("No Solution", solution);
        }
    }
}
