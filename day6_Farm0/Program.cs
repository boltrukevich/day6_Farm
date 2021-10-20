using System;
using System.Collections.Generic;

namespace day6_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Season season;
            season = Season.Spring;
            Console.WriteLine($"Current season is {season}");

            var farm = FarmHelper.CreateBaseFarm();
            Menu(farm, season);

        }
        public static void Menu(Farm farm, Season season)
        {
            bool ending;
            do
            {
                MenuUI();
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        MenuReport(farm);
                        ending = false;
                        break;
                    case "2":
                        MenuFarmManage(farm);
                        ending = false;
                        break;
                    case "3":
                        ChangeSeason(season);
                        ending = false;
                        break;
                    case "q":
                        ending = true;
                        Console.WriteLine($"Good bye...");
                        break;
                    default:
                        Console.WriteLine("Error. Press again...");
                        ending = false;
                        break;
                }
            }
            while (!ending);
        }

        public static void MenuUI()
        {
            Console.WriteLine("1. Reports");
            Console.WriteLine("2. Farm management");
            Console.WriteLine("3. Сhange of season");
            Console.WriteLine("Q. Quit ");
        }

        public static void MenuReport(Farm farm)
        {
            bool ending;
            do
            {
                MenuReportsUI();
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        FarmHelper.ReportFarm(farm);
                        ending = false;
                        break;
                    case "2":
                        FarmHelper.ReportGardenbed(farm);
                        ending = false;
                        break;
                    case "3":
                        FarmHelper.ReportBuilding(farm);
                        ending = false;
                        break;
                    case "b":
                        ending = true;
                        break;
                    default:
                        Console.WriteLine("Error. Press again...");
                        ending = false;
                        break;
                }
            }
            while (!ending);
        }
        public static void MenuReportsUI()
        {
            Console.WriteLine("1. Farm report");
            Console.WriteLine("2. Gardenbed report");
            Console.WriteLine("3. Building report");
            Console.WriteLine("4. Storage report");
            Console.WriteLine("b. Back ");
        }

        public static void MenuFarmManage(Farm farm)
        {
            bool ending;
            do
            {
                MenuFarmManageUI();
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        FarmHelper.AddGardenbed(farm);
                        ending = false;
                        break;
                    case "2":
                        FarmHelper.AddPlant(farm);
                        ending = false;
                        break;
                    case "3":
                        FarmHelper.AddBuilding(farm);
                        ending = false;
                        break;
                    case "b":
                        ending = true;
                        break;
                    default:
                        Console.WriteLine("Error. Press again...");
                        ending = false;
                        break;
                }
            }
            while (!ending);
        }

        public static void MenuFarmManageUI()
        {
            Console.WriteLine("1. Add gardenbed");
            Console.WriteLine("2. Add plant to gardenbed");
            Console.WriteLine("3. Add building");
            Console.WriteLine("b. Back ");
        }

        public static void ChangeSeason(Season season)
        {
            Console.WriteLine($"Current season is {season}");
            if (season == Season.Winter)
            {
                season = Season.Spring;
            }
            else if (season == Season.Spring)
            {
                season = Season.Summer;
            }
            else if (season == Season.Summer)
            {
                season = Season.Autumn;
            }
            else
            {
                season = Season.Winter;
            }
            Console.WriteLine($"Current season is {season}");

            //Harvest();
        }
    }
}