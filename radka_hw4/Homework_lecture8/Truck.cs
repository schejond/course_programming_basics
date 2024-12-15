namespace Homework_lecture8
{
    class Truck : Vehicle, IDriveable
        {
            public double LoadCapacity { get; set; }

            public Truck(int id, string model, int year, double loadCapacity) : base(id, model, year)
            {
                LoadCapacity = loadCapacity;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Truck {Id}: {Model} ({Year}), Load Capacity: {LoadCapacity} tons.");
            }

            public void Drive()
            {
                Console.WriteLine($"Truck {Id} is driving.");
            }

            public void Haul()
            {
                Console.WriteLine($"Truck {Id} is hauling a load of {LoadCapacity} tons.");
            }
        
    }
}
