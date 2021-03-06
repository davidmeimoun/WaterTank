﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace WaterTank
{
    public class Solver
    {

        public static void solve(WaterTankModel waterTank)
        {
            List<String> path = new List<String>();
            if (isPossible(waterTank))
            {
                for (var i = 1; ; i++)
                {
                    if (isGoodResult(waterTank.FirstContainer, waterTank.LitterResearch) || isGoodResult(waterTank.SecondContainer, waterTank.LitterResearch))
                    {
                        waterTank.PathSolve = path;
                        return;
                    }

                    if (isContainerEmpty(waterTank.FirstContainer))
                    {
                        waterTank.FirstContainer = waterTank.MaxFirstContainer;
                        path.Add("* -> A : (" + waterTank.FirstContainer + "," + waterTank.SecondContainer + ")");
                    }
                    else if (!isContainerEmpty(waterTank.FirstContainer) && canAddWater(waterTank.SecondContainer, waterTank.MaxSecondContainer))
                    {
                        FillContainerAtoB(ref waterTank, waterTank.MaxSecondContainer);
                        path.Add("A -> B : (" + waterTank.FirstContainer + "," + waterTank.SecondContainer + ")");
                    }
                    else if (!isContainerEmpty(waterTank.FirstContainer) && isFullContainer(waterTank.SecondContainer, waterTank.MaxSecondContainer))
                    {
                        waterTank.SecondContainer = 0;
                        path.Add("* -> B : (" + waterTank.FirstContainer + "," + waterTank.SecondContainer + ")");
                    }
                }
            }
            else
            {
                path.Add("No Solution");
                waterTank.PathSolve = path;
                return;
            }
        }

        private static bool isPossible(WaterTankModel waterTank)
        {

            double gcd = double.Parse(BigInteger.GreatestCommonDivisor(waterTank.MaxFirstContainer, waterTank.MaxSecondContainer).ToString());
            double number = waterTank.LitterResearch / gcd;
            if (number % 1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void print(WaterTankModel waterTank)
        {
            foreach (String path in waterTank.PathSolve)
            {
                Console.WriteLine(path);
            }
        }


        private static void FillContainerAtoB(ref WaterTankModel model, int containerBMax)
        {
            while (!isContainerEmpty(model.FirstContainer) && !isFullContainer(model.SecondContainer, containerBMax))
            {
                addWater(ref model);
                removeWater(ref model);
            }
        }

        private static bool isGoodResult(int container, int gallonsToFill)
        {
            return container == gallonsToFill;
        }

        private static bool isFullContainer(int container, int containerMax)
        {
            return container == containerMax;
        }

        private static bool isContainerEmpty(int container)
        {
            return container == 0;
        }

        private static void removeWater(ref WaterTankModel model)
        {
            model.FirstContainer -= 1;
            if (model.FirstContainer < 0)
            {
                model.FirstContainer = 0;
            }
        }

        private static void addWater(ref WaterTankModel model)
        {
            model.SecondContainer += 1;
            if (model.SecondContainer > model.MaxSecondContainer)
            {
                model.SecondContainer = model.MaxSecondContainer;
            }
        }


        private static bool canAddWater(int container, int containerMax)
        {
            return container < containerMax;
        }

    }
}
