using Homework_lecture7;

namespace Homework_lecture7
{
    public class Car
    {
        public string Brand;

        public string Model;

        public int Year;

        public int Mileage;


        public Car(string brand, string model, int year, int mileage = 0)
        {
            Brand = brand;

            Model = model;

            Year = year;

            Mileage = mileage;
        }
        public void Drive(int kilometers)
        {
            if (kilometers > 0)
            {
                Mileage += kilometers; 

                Console.WriteLine($"The car has been driven {Mileage} kilometers.");
            }

            else
            {
                Console.WriteLine("The number of kilometers must be positive.");
                
            }
        }

        
             public void DisplayCarInfo()
             {

                 Console.WriteLine("Reading" + Brand + ",  " + Model + ", " + Year + ", " + Mileage + " km ");

                

             }

    }
}


