namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Zadání
            Napište program (konzolovou aplikaci), která přečte ze vstupu (od uživatele) jeho
            věk, jméno, příjmení, váhu a výšku. (Poznámka: hodnoty nepište přímo do kódu,
            naprogramujte aplikaci tak, aby je stroj četl. Nechceme žádné údaje uživatelů mít v
            kódu)
            */
            Console.Write("Zadej svuj vek a potvrd enterem: ");
            int vekUzivatele2 = int.Parse(Console.ReadLine());

            Console.Write("Zadej sve jmeno a potvrd enterem: ");
            string jmenoUzivatele2 = Console.ReadLine();

            Console.Write("Zadej sve prijmeni a potvrd enterem: ");
            string prijmeniUzivatele2 = Console.ReadLine();

            Console.Write("Zadej svoji vahu v kg a potvrd enterem: ");
            float vahaUzivatele2 = float.Parse(Console.ReadLine());

            Console.Write("Zadej svoji vysku v cm a potvrd enterem: ");
            float vyskaUzivatele2 = float.Parse(Console.ReadLine());




            /*
            1. Zobrazte na výstupu konzole tuto zprávu doplněnou s údaji, které uživatel
            zadal:
            Jan Novák je starý(á) 18 let. Váží 66 kilogramů a je 142 centimetrů vysoký/á.
            */

            Console.WriteLine(jmenoUzivatele2 + " " + prijmeniUzivatele2 + " je starý(á) " + vekUzivatele2 + " let. Váží " + vahaUzivatele2 + "  kilogramů a je " + vyskaUzivatele2 + " centimetrů vysoký/á.");

            /*
            2. Vypočtěte do proměnné jeho body mass index (BMI) a zobrazte na výstupu
            konzole*/

            float bmi2 = vahaUzivatele2 / ((vyskaUzivatele2 / 100f) * (vyskaUzivatele2 / 100f));
            Console.WriteLine("Vase BMI je " + bmi2);

            /*
            3. Naprogramujte program, aby body 1 a 2 udělal pro 2 osoby (provedl kroky
            dvakrát během jednoho běhu aplikace)*/

            Console.Write("Zadej svuj vek a potvrd enterem: ");
            int vekUzivatele = int.Parse(Console.ReadLine());

            Console.Write("Zadej sve jmeno a potvrd enterem: ");
            string jmenoUzivatele = Console.ReadLine();

            Console.Write("Zadej sve prijmeni a potvrd enterem: ");
            string prijmeniUzivatele = Console.ReadLine();

            Console.Write("Zadej svoji vahu v kg a potvrd enterem: ");
            float vahaUzivatele = float.Parse(Console.ReadLine());

            Console.Write("Zadej svoji vysku v cm a potvrd enterem: ");
            float vyskaUzivatele = float.Parse(Console.ReadLine());

            Console.WriteLine(jmenoUzivatele + " " + prijmeniUzivatele + " je starý(á) " + vekUzivatele + " let. Váží " + vahaUzivatele + "  kilogramů a je " + vyskaUzivatele + " centimetrů vysoký/á.");

            float bmi = vahaUzivatele / ((vyskaUzivatele / 100f) * (vyskaUzivatele / 100f));
            Console.WriteLine("Vase BMI je " + bmi);
        }
    }
}
