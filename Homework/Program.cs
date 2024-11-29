namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cyklus pre dve osoby
            for (int osoba = 1; osoba <= 2; osoba++)
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

            }
        }
    }
}
