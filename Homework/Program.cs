using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)

        {//Jan Novák je starý(á) 18 let. Váží 66 kilogramů a je 142 centimetrů vysoký/á.

            Console.WriteLine("Prvni osoba");

            Console.Write("Zadejte sve jmeno: ");

            string me = Console.ReadLine();

            Console.WriteLine("Zadejte sve prijmeni: ");

            string pr = Console.ReadLine();

            Console.Write("Zadejte svuj vek: ");

            string ve = Console.ReadLine();

            Console.Write("Zadejte svou hmotnost v kg: ");

            string hm = Console.ReadLine();

            int hmo = int.Parse(hm);

            Console.Write("Zadejte svou vysku v cm: ");

            string vy = Console.ReadLine();

            int vys = int.Parse(vy);

            double cm = 0.01;

            double vk = vys * cm;

            double vkk = vk * vk;

            double BMI = hmo / vkk;


            Console.WriteLine("Druha osoba");

            Console.Write("Zadejte sve jmeno: ");

            string me2 = Console.ReadLine();

            Console.WriteLine("Zadejte sve prijmeni: ");

            string pr2 = Console.ReadLine();

            Console.Write("Zadejte svuj vek: ");

            string ve2 = Console.ReadLine();

            Console.Write("Zadejte svou hmotnost v kg: ");

            string hm2 = Console.ReadLine();

            int hmo2 = int.Parse(hm);

            Console.Write("Zadejte svou vysku v cm: ");

            string vy2 = Console.ReadLine();

            int vys2 = int.Parse(vy);

            double cm2 = 0.01;

            double vk2 = vys2 * cm2;

            double vkk2 = vk2 * vk2;

            double BMI2 = hmo2 / vkk2;

            Console.WriteLine(me + " " + pr + " je starý(á) " + ve + " let. Váží " + hm + " kilogramů a je " + vy + " centimetrů vysoký/á.");
            
            Console.WriteLine(" ");

            Console.WriteLine(" Vysledni BMI je: " + Math.Round(BMI, 1));
            
            Console.WriteLine(" ");
            
            Console.WriteLine(me2 + " " + pr2 + " je starý(á) " + ve2 + " let. Váží " + hm2 + " kilogramů a je " + vy2 + " centimetrů vysoký/á.");

            Console.WriteLine(" ");

            Console.WriteLine(" Vysledni BMI je: " + Math.Round(BMI2, 1));





        }
    }
}
