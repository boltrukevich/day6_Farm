using System.Collections.Generic;

namespace day6_Farm
{
    public class Gardenbed
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();
    }
}