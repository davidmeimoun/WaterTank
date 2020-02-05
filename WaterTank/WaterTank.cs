using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WaterTank
{
    class WaterTank
    {
        private int firstContainer;
        private int secondContainer;
        private int litterResearch;
        private int maxFirstContainer;
        private int maxSecondContainer;
        private List<String> pathSolve;

        public WaterTank(int maxFirstContainer, int maxSecondContainer, int litterResearch)
        {
            this.firstContainer = 0;
            this.secondContainer = 0;
            this.litterResearch = litterResearch;
            this.maxFirstContainer = maxFirstContainer;
            this.maxSecondContainer = maxSecondContainer;
        }


        public void Solve()
        {
            List<String> path = new List<String>();
            if (isPossible())
            {
                for (var i = 1; ; i++)
                {
                    if (isGoodResult(firstContainer, litterResearch) || isGoodResult(secondContainer, litterResearch))
                    {
                        pathSolve = path;
                        return;
                    }

                    if (isContainerEmpty(firstContainer))
                    {
                        firstContainer = maxFirstContainer;
                        path.Add("* -> A : (" + firstContainer + "," + secondContainer + ")");
                    }
                    else if (!isContainerEmpty(firstContainer) && canAddWater(secondContainer, maxSecondContainer))
                    {
                        FillContainerAtoB(ref firstContainer, ref secondContainer, maxSecondContainer);
                        path.Add("A -> B : (" + firstContainer + "," + secondContainer + ")");
                    }
                    else if (!isContainerEmpty(firstContainer) && isFullContainer(secondContainer, maxSecondContainer))
                    {
                        secondContainer = 0;
                        path.Add("* -> B : (" + firstContainer + "," + secondContainer + ")");
                    }
                }
            }
            else
            {
                path.Add("No Solution");
                pathSolve = path;
            }
        }

        public bool isPossible()
        {

            var d = BigInteger.GreatestCommonDivisor(maxFirstContainer, maxSecondContainer);

            var number = litterResearch / d;
            if (number % 1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void print()
        {
            foreach (String path in pathSolve)
            {
                Console.WriteLine(path);
            }
        }


        private void FillContainerAtoB(ref int firstContainer, ref int secondContainer, int containerBMax)
        {
            while (!isContainerEmpty(firstContainer) && !isFullContainer(secondContainer, containerBMax))
            {
                addWater(ref secondContainer, containerBMax);
                removeWater(ref firstContainer);
            }
        }

        private bool isGoodResult(int container, int gallonsToFill)
        {
            return container == gallonsToFill;
        }

        private bool isFullContainer(int container, int containerMax)
        {
            return container == containerMax;
        }

        private bool isContainerEmpty(int container)
        {
            return container == 0;
        }

        private void removeWater(ref int container)
        {
            container -= 1;
            if (container < 0)
            {
                container = 0;
            }
        }

        private void addWater(ref int container, int containerMax)
        {
            container += 1;
            if (container > containerMax)
            {
                container = containerMax;
            }
        }


        private bool canAddWater(int container, int containerMax)
        {
            return container < containerMax;
        }

    }
}
