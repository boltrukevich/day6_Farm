using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_Farm
{
    public class Farm
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Gardenbed> Gardenbeds { get; set; } = new List<Gardenbed>();
        public List<Building> Buildings { get; set; } = new List<Building>();
        public List<AnimalProduct> AnimalProducts{ get; set; } = new List<AnimalProduct>();

        public void FarmReport()
        {
            Console.WriteLine($"This is {Name} farm, it has area of {Area}, with {Gardenbeds.Count} gardenbeds and {Buildings.Count} buildings");
        }

        public void GardenbedReport()
        {
            Console.WriteLine($"{Name} Farm has {Gardenbeds.Count} gardenbeds:");
            foreach (var gardenbed in Gardenbeds)
            {
                Console.WriteLine($" - Gardenbed '{gardenbed.Name}' plants are:");
                var consumedArea = 0;
                foreach (var plant in gardenbed.Plants)
                {
                    Console.WriteLine($"\t - {plant.Name}, area consumed {plant.AreaConsumed}");
                    consumedArea += plant.AreaConsumed;
                }
                Console.WriteLine($" Area is {consumedArea}/{gardenbed.Area}, gardenbed usage: {(consumedArea / (double)gardenbed.Area) * 100}%");
            }
        }

        public void BuildingReport()
        {
            Console.WriteLine($"{Name} Farm has {Buildings.Count} building:");
            int totalCapacity = 0;
            foreach (var building in Buildings)
            {
                totalCapacity = totalCapacity + building.AnimalsCapacity; 
                Console.WriteLine($" - Building '{building.Name}' are {building.AnimalsCapacity} capacity:");
            }
            Console.WriteLine($" Buildings are total capacity {totalCapacity}:");
        }

        public void AddGardenbed(Gardenbed gardenbed)
        {
            if (Area - AreaConsumed() < gardenbed.Area)
            {
                Console.WriteLine("Not enough area");
                return;
            }   
           
            Console.WriteLine("Adding gardenbed");
            
            Gardenbeds.Add(gardenbed);
        }
        public void AddBuilding(Building building)
        {
            if (Area - AreaConsumed() < building.Area)
            {
                Console.WriteLine("Not enough area");
                return;
            }
            
            Console.WriteLine("Adding building");

            Buildings.Add(building);
        }
        public void Harvest(Gardenbed gardenbed)
        {

            Console.WriteLine($"{Name} Farm has {Gardenbeds.Count} gardenbeds:");
            foreach (var gardenbeds in Gardenbeds)
            {
                foreach (var plant in gardenbed.Plants)
                {
                }
            }
        }

        private int AreaConsumed()
        {
            var areaConsumed = 0;
            foreach (var gardenbed in Gardenbeds)
            {
                areaConsumed += gardenbed.Area;
            }
            foreach (var building in Buildings)
            {
                areaConsumed += building.Area;
            }
            return areaConsumed;
        }
    }
}
