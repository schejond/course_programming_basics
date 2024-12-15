namespace Homework_lecture8
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] carModels = { "Toyota Corolla", "Ford Focus", "Honda Civic", "Mazda 3", "Volkswagen Golf" };
            string[] bikeModels = { "Yamaha MT-07", "Kawasaki Ninja", "Harley Davidson Sportster", "Ducati Monster", "Suzuki GSX-R" };
            string[] truckModels = { "Volvo FH16", "Scania R500", "MAN TGX", "Mercedes-Benz Actros", "DAF XF" };


            var driveables = new IDriveable[150];
            var vehicles = new Vehicle[60];

            var random = new Random();


            for (int i = 0; i < 150; i++)
            {

                if (i < 50)
                    driveables[i] = new Car(i + 1, carModels[random.Next(carModels.Length)], 2000 + random.Next(23), random.Next(2, 5));

                else if (i < 100)
                    driveables[i] = new Motorcycle(i + 1, bikeModels[random.Next(bikeModels.Length)], 2000 + random.Next(23), random.Next(2) == 1);

                else
                    driveables[i] = new Truck(i + 1, truckModels[random.Next(truckModels.Length)], 2000 + random.Next(23), Math.Round(random.NextDouble() * 20, 2));
            }


            for (int i = 0; i < 60; i++)
            {
                if (i < 30)
                    vehicles[i] = new Car(i + 1, carModels[random.Next(carModels.Length)], 2000 + random.Next(23), random.Next(2, 5));

                else if (i < 50)
                    vehicles[i] = new Motorcycle(i + 1, bikeModels[random.Next(bikeModels.Length)], 2000 + random.Next(23), random.Next(2) == 1);

                else
                    vehicles[i] = new Truck(i + 1, truckModels[random.Next(truckModels.Length)], 2000 + random.Next(23), Math.Round(random.NextDouble() * 20, 2));

            }


            foreach (var driveable in driveables)
            {
                driveable.Drive();
            }


            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                vehicle.Start();


                if (vehicle is Truck truck)
                {
                    truck.Haul();
                }
            }
        }
    }
}


















