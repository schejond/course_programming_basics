namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cyklus pre lubovlny pocet osob
            Console.WriteLine("Zadaj počet osôb: ");
            int pocetOsob = int.Parse(Console.ReadLine());
            for (int osoba = 1; osoba <= pocetOsob; osoba++)
            {
                Console.WriteLine($"Zadaj meno osoby {osoba}");
                string Meno1 = Console.ReadLine();
                Console.WriteLine($"Zadaj priezvisko osoby {osoba}");
                string Priezvisko1 = Console.ReadLine();
                Console.WriteLine($"Zadaj vek osoby {osoba} v rokoch");
                int Vek1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Zadaj hmotnosť osoby {osoba} v kg");
                int Vaha1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Zadaj výšku osoby {osoba} v cm");
                int Vyska1 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} {1} je starý(á) {2} rokov. Váži {3} kg a je {4} cm vysoký(á).",
                   Meno1, Priezvisko1, Vek1, Vaha1, Vyska1);
                float BMI1;
                float Vyska1M = (float)(Vyska1 / 100.0);
                BMI1 = (float)(Vaha1 / (Vyska1M * Vyska1M));
                Console.WriteLine("Jeho/jej BMI je {0}", BMI1);
                Console.WriteLine("BMI kritéria platia pre európsku populáciu:");
                if (BMI1 < 18.5)
                {
                    Console.WriteLine("Tvoje BMI je do 18,5 čo znamená, že si podvýživený(á) musíš pribrať!");
                }
                else if (BMI1 < 25)
                {
                    Console.WriteLine("Tvoje BMI je od 18,5 do 25 čo znamená, že tvoja váha je ideálna drž sa jej.");
                }
                else if (BMI1 < 30)
                {
                    Console.WriteLine("Tvoje BMI je od 25 do 30 čo znamená, že máš miernu nadváhu mal(a) by si sa nad sebou zamyslieť!");
                }
                else if (BMI1 < 40)
                {
                    Console.WriteLine("Tvoje BMI je od 30 do 40 čo znamená, že máš už obezitu mal(a) by si prestať jesť toľko sladkostí!!");
                }
                else
                {
                    Console.WriteLine("Tvoje BMI je vačšie ako 40 čo znamená, že máš už ťažkú obezitu mal(a) prestať ťoľko jesť a začať cvičiť!!!!!!!!");
                }
            }
        }
    }
}
