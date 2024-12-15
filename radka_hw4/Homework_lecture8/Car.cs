namespace Homework_lecture8
{
    class Car : Vehicle, IDriveable
        {
            public int NumberOfDoors { get; set; }

            public Car(int id, string model, int year, int numberOfDoors) : base(id, model, year)
            {
                NumberOfDoors = numberOfDoors;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Car {Id}: {Model} ({Year}), {NumberOfDoors} doors.");
            }

            public virtual void Drive()
            {
                Console.WriteLine($"Car {Id} is driving.");
            }

            public override void Start()
            {
                Console.WriteLine($"Car {Id} ({Model}) is starting with a roar.");
            }
    }
    
}
