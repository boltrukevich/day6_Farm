using System.Collections.Generic;

namespace day6_Farm
{
    public class Building
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int AnimalsCapacity { get; set; }
        public List<Animal> Animals { get; set; }
    }
}                                                   