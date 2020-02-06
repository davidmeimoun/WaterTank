using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WaterTank;

namespace WaterTankApp.Controllers
{
    public class WaterTankController : ApiController
    {
        [Route("api/watertank/{containerA}/{containerB}/{numberOfLiter}")]
        public List<String> GetAllSteps (int containerA,int containerB, int numberOfLiter)
        {
            WaterTankModel model = new WaterTankModel(containerA, containerB, numberOfLiter);
            Solver.solve(model);
            return model.PathSolve;
        }


    }
}
