using System;
using System.Reflection;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vek;

            string jmeno;

            string prijmeni;

            double vaha;

            int vyska;

            int vekB;

            string jmenoB;

            string prijmeniB;

            double vahaB;

            int vyskaB;


            Console.Write("Věk první osoby: ");

            vek = int.Parse(Console.ReadLine());

            Console.Write("Jméno první osoby: ");
            
            jmeno = Console.ReadLine();

            Console.Write("Příjmení první osoby: ");

            prijmeni = Console.ReadLine();

            Console.Write("Váha první osoby: ");

            vaha = double.Parse(Console.ReadLine());

            Console.Write("Výška první osoby: ");

            vyska = int.Parse(Console.ReadLine());

            Console.Write("Věk druhé osoby: ");

            vekB = int.Parse(Console.ReadLine());

            Console.Write("Jméno druhé osoby: ");

            jmenoB = Console.ReadLine();

            Console.Write("Příjmení druhé osoby: ");

            prijmeniB = Console.ReadLine();

            Console.Write("Váha druhé osoby: ");

            vahaB = double.Parse(Console.ReadLine());

            Console.Write("Výška druhé osoby: ");

            vyskaB = int.Parse(Console.ReadLine());

            double BMI = (vaha / (vyska * vyska)) * 10000;
            double BMIB = (vahaB / (vyskaB * vyskaB)) * 10000;

            Console.WriteLine(jmeno + " " + prijmeni + " je starý(á) " + vek + " let. Váží " + vaha + " kilogramů a je " + vyska + " centimetrů vysoký/á.");

            Console.WriteLine("Body mass index (BMI) je: " + BMI);

            Console.WriteLine(jmenoB + " " + prijmeniB + " je starý(á) " + vekB + " let. Váží " + vahaB + " kilogramů a je " + vyskaB + " centimetrů vysoký/á.");

            Console.WriteLine("Body mass index (BMI) je: " + BMI);










        }
    }
}
