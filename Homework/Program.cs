using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prvni osoba");


            Console.Write("Zadejte sve jmeno a prijmeni: ");

            string name = Console.ReadLine();
            
            Console.Write("Zadejte svuj vek: ");

            string age = Console.ReadLine();

            Console.Write("Zadejte svou hmotnost v kg: ");

            string weight = Console.ReadLine();

            float weight2 = float.Parse(weight);

            Console.Write("Zadejte svou vysku v cm: ");

            string height = Console.ReadLine();

            int height2 = int.Parse(height);


            float heightinmetres = height2 * 0.01f;

            double BMI = weight2 / (heightinmetres * heightinmetres);


            Console.WriteLine(name + " je starý(á) " + age + " let. Váží " + weight2 + " kilogramů a je " + height2 + " centimetrů vysoký/á.");
            
            Console.WriteLine("Vysledni BMI je: " + Math.Round(BMI, 1));


            if (BMI < 17.9)
            {
                Console.WriteLine("Kategorie Ektomorf.");
            }
            else if (BMI >= 18 && BMI <= 24.9)
            {
                Console.WriteLine("Kategorie Mezomorf");
            }
            else
            {
                Console.WriteLine("Kategorie Endormorf");
            }    

        }
    }
}
