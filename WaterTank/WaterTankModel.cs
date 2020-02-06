using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTank
{
    public class WaterTankModel
    {

        private int firstContainer;
        private int secondContainer;
        private int litterResearch;
        private int maxFirstContainer;
        private int maxSecondContainer;
        private List<String> pathSolve;

        public List<string> PathSolve { get => pathSolve; set => pathSolve = value; }
        public int FirstContainer { get => firstContainer; set => firstContainer = value; }
        public int SecondContainer { get => secondContainer; set => secondContainer = value; }
        public int LitterResearch { get => litterResearch; set => litterResearch = value; }
        public int MaxFirstContainer { get => maxFirstContainer; set => maxFirstContainer = value; }
        public int MaxSecondContainer { get => maxSecondContainer; set => maxSecondContainer = value; }

        public WaterTankModel(int maxFirstContainer, int maxSecondContainer, int litterResearch)
        {
            this.firstContainer = 0;
            this.secondContainer = 0;
            this.litterResearch = litterResearch;
            this.maxFirstContainer = maxFirstContainer;
            this.maxSecondContainer = maxSecondContainer;
        }

    }
}
