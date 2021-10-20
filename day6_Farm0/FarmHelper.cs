using System;
using System.Collections.Generic;

namespace day6_Farm
{
    public static class FarmHelper
    {
        public static Farm CreateBaseFarm()
        {

            var farm = new Farm() { Area = 1000, Name = "DefaultFarm" };

            var cow = new Animal()
            {
                Name = "Cow",
                Product = new AnimalProduct { Name = "Milk", Weight = 7 }
            };

            var sheep = new Animal()
            {
                Name = "Sheep",
                Product = new AnimalProduct { Name = "Wool", Weight = 12 }
            };

            var pig = new Animal()
            {
                Name = "Pig",
                Product = new AnimalProduct { Name = "Meat", Weight = 75 }
            };

            List<Animal> animals = new List<Animal>() { };
            animals.Add(cow);


            var stable = new Building() { Name = "Stable", Area = 100, AnimalsCapacity = 12 };
            farm.Buildings.Add(stable);

            var gardenbedOne = new Gardenbed() { Name = "Vegetables", Area = 100 };
            var cucumber = new Plant()
            {
                AreaConsumed = 27,
                Name = "Cucumber",
                PlantSeason = Season.Spring,
                HarvestSeason = Season.Summer
            };
            var potato = new Plant()
            {
                AreaConsumed = 50,
                Name = "Potato",
                PlantSeason = Season.Summer,
                HarvestSeason = Season.Autumn
            };
            gardenbedOne.Plants.Add(cucumber);
            gardenbedOne.Plants.Add(potato);
            farm.Gardenbeds.Add(gardenbedOne);
            //              farm.Buildings.Add();
            return farm;
        }

        public static void ReportFarm(Farm farm)
        {
            farm.FarmReport();
        }

        public static void ReportGardenbed(Farm farm)
        {
            farm.GardenbedReport();
        }

        public static void ReportBuilding(Farm farm)
        {
            farm.BuildingReport();
        }

        public static void AddGardenbed(Farm farm)
        {
            var gardenBedDefault = new Gardenbed();
            Console.WriteLine($"Enter the gardenbed name :");
            gardenBedDefault.Name = Console.ReadLine();
            Console.WriteLine($"Enter the gardenbed area:");
            gardenBedDefault.Area = Convert.ToInt32(Console.ReadLine());
            farm.AddGardenbed(gardenBedDefault);
        }
        public static void AddPlant(Farm farm)
        {
            var plantDefault = new Plant();
            Console.WriteLine($"Enter the plant name :");
            plantDefault.Name = Console.ReadLine();
            ChoosePlantSeason(plantDefault);
            ChooseHarvestSeason(plantDefault);
            Console.WriteLine($"{plantDefault.Name}");
            Console.WriteLine($"{plantDefault.PlantSeason}");
            Console.WriteLine($"{plantDefault.HarvestSeason}");
        }

        public static void AddBuilding(Farm farm)
        {
            var buildingDefault = new Building();
            Console.WriteLine($"Enter the building name:");
            buildingDefault.Name = Console.ReadLine();
            Console.WriteLine($"Enter the building area:");
            buildingDefault.Area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the building animals capacity:");
            buildingDefault.AnimalsCapacity = Convert.ToInt32(Console.ReadLine());
            farm.AddBuilding(buildingDefault);
        }


        public static void ChoosePlantSeason(Plant plantDefault)
        {
            Console.WriteLine($"Enter the plant season:");
            Console.WriteLine($"0 - Winter, 1 - Spring, 2 - Summer, 3 - Autumn.");
            int seasonInput = Convert.ToInt32(Console.ReadLine());
            if (seasonInput == 0)
            {
                plantDefault.PlantSeason = Season.Winter;
            }
            else if (seasonInput == 1)
            {
                plantDefault.PlantSeason = Season.Spring;
            }
            else if (seasonInput == 2)
            {
                plantDefault.PlantSeason = Season.Summer;
            }
            else if (seasonInput == 3)
            {
                plantDefault.PlantSeason = Season.Autumn;
            }
            //return plantDefault.PlantSeason;
        }

        public static void ChooseHarvestSeason(Plant plantDefault)
        {
            Console.WriteLine($"Enter the harvest season:");
            Console.WriteLine($"0 - Winter, 1 - Spring, 2 - Summer, 3 - Autumn.");
            int seasonInput = Convert.ToInt32(Console.ReadLine());
            if (seasonInput == 0)
            {
                plantDefault.HarvestSeason = Season.Winter;
            }
            else if (seasonInput == 1)
            {
                plantDefault.HarvestSeason = Season.Spring;
            }
            else if (seasonInput == 2)
            {
                plantDefault.HarvestSeason = Season.Summer;
            }
            else if (seasonInput == 3)
            {
                plantDefault.HarvestSeason = Season.Autumn;
            }

        }
    }
}