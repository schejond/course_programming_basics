using Homework_lecture7;

namespace Homework_lecture7
{
    public class Car
    {
        public string Brand;

        public string Model;

        public int Year;

        public int Mileage;


        public Car(string Brand, string Model, int Year, int Mileage = 0)
        {
            Brand = Brand;

            Model = Model;

            Year = Year;

            Mileage = Mileage;
        }
        public void Drive(int kilometers)
        {
            if (kilometers > 0)
            {
                Mileage += kilometers; 

                Console.WriteLine($"The car has been driven {500} kilometers.");

                Console.WriteLine($"The car has been driven {300} kilometers.");
            }
            else
            {
                Console.WriteLine("The number of kilometers must be positive.");
            }
        }

        
             public void DisplayCarInfo()
             {

                 Console.WriteLine($"Brand: Škodovka, Model: Octavia_Combi, Year: 2006, Mileage: {75000} km");

                 Console.WriteLine($"Brand: Fiat, Model: Doblo, Year: 2004, Mileage: {125000} km");

        }

    }
}


