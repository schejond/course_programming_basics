namespace Homework_lecture8
{
    abstract class Vehicle
    {
        
            public int Id;
            public string Model;
            public int Year;

            protected Vehicle(int id, string model, int year)
            {
                Id = id;
                Model = model;
                Year = year;
            }


            public abstract void DisplayInfo();

            
            public virtual void Start()
            {
                Console.WriteLine($"Vehicle {Id} ({Model}) is starting.");
            }
        }

       
        interface IDriveable
        {
            void Drive();
        }
    
}
