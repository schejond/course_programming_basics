namespace Homework
using System;

class Program
{
    static void Main(string[] args)
    {
        // Pro dvě osoby budeme vykonávat stejný postup
        for (int i = 1; i <= 2; i++)
        {
            // Načítání údajů pro osobu
            Console.WriteLine($"Zadejte údaje pro osobu {i}:");

            // Získání údajů od uživatele
            Console.Write("Jméno: ");
            string firstName = Console.ReadLine();

            Console.Write("Příjmení: ");
            string lastName = Console.ReadLine();

            Console.Write("Věk: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Váha (kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Výška (cm): ");
            double height = double.Parse(Console.ReadLine());

            // Zobrazit uživatelské informace
            Console.WriteLine($"{firstName} {lastName} je starý(á) {age} let. Váží {weight} kilogramů a je {height} centimetrů vysoký/á.");

            // Výpočet BMI
            double heightInMeters = height / 100; // Převod výšky na metry
            double bmi = weight / (heightInMeters * heightInMeters); // Vzorec pro BMI

            // Zobrazení BMI
            Console.WriteLine($"BMI: {bmi:F2}");
            Console.WriteLine(); // Prázdný řádek mezi jednotlivými uživatelskými vstupy
        }
    }
}
