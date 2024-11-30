using System.Runtime.Intrinsics.X86;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 2; i++)
            {
                //Input and Output of NAME, SURNAME, AGE, WEIGHT, HEIGHT
                Console.WriteLine((i+1) + ". osoba");
                Console.WriteLine("\nJmeno:");
                string name = Console.ReadLine();

                Console.WriteLine("\nPrijmeni:");
                string surname = Console.ReadLine();

                Console.WriteLine("\nVek:");
                string age_string = Console.ReadLine();
                Int32.TryParse(age_string, out int age);

                Console.WriteLine("\nVaha (kg):");
                string weight_string = Console.ReadLine();
                Int32.TryParse(weight_string, out int weight);

                Console.WriteLine("\nVyska (cm):");
                string height_string = Console.ReadLine();
                Int32.TryParse(height_string, out int height);


                Console.WriteLine("\n" + name + " je starý(á) " + age_string + " let. Váží " + weight_string + " kilogramů a je " + height_string + " centimetrů vysoký/á.\n");


                //BMI part

                double height_meters = (double)height / 100;
                double BMI = weight / Math.Pow(height_meters, 2);

                Console.WriteLine("BMI = " + BMI + "\n");

            }

            







            
        }
    }
}
