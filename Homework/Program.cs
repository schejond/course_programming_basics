using System.Runtime.Intrinsics.X86;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej Jméno: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Zadej Přijmení: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Zade svůj věk: ");
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);

            Console.WriteLine("Zadej svoji výšku (cm): ");
            string height = Console.ReadLine();
            int heightInt = int.Parse(height);


            Console.WriteLine("Zadej svoji váhu (kg): ");
            string weight = Console.ReadLine();
            int weightInt = int.Parse(weight);

            //Console.WriteLine(firstName + "" + lastName + " je starý/á " + ageInt + "let. " + "Váží " + weightInt + "kg a je " + heightInt + " centimetrů vysoký/á. ");
            Console.WriteLine($"{firstName} {lastName} je starý/á {ageInt} let. Váží {weightInt} kg a je {heightInt} centimetrů vysoký/á.");
            
            // Převod výšky na metry
            float heightCm = heightInt / 100.0f;

            // výpočet BMI
            float bmi = weightInt / (heightCm * heightCm);

            // Výpis BMI
            //Console.WriteLine("BMI je: " + bmi);
            
            // Výpis BMI s jedním des. číslem
            Console.WriteLine($"BMI je: {bmi:F1}");





        }
    }
}
