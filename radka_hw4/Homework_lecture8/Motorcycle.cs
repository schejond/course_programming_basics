namespace Homework_lecture8
{
     class Motorcycle : Vehicle, IDriveable
        {
            public bool HasSidecar { get; set; }

            public Motorcycle(int id, string model, int year, bool hasSidecar) : base(id, model, year)
            {
                HasSidecar = hasSidecar;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Motorcycle {Id}: {Model} ({Year}), Sidecar: {(HasSidecar ? "Yes" : "No")}.");
            }

            public void Drive()
            {
                Console.WriteLine($"Motorcycle {Id} is driving.");
            }

            public override void Start()
            {
                base.Start(); 
                Console.WriteLine($"Motorcycle {Id} has started with extra style.");
            }
        
     }
}
