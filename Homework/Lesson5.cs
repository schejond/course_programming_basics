namespace Homework
{
    public class Lesson5
    {
        public static string vstupString(string vyzva)
        {
            Console.Write(vyzva);
            string vstup = Console.ReadLine();
            return vstup;
        }

        public static int vstupInt(string vyzva)
        {
            Console.Write(vyzva);
            int vstup = int.Parse(Console.ReadLine());
            return vstup;
        }

        public static float vstupFloat(string vyzva)
        {
            Console.Write(vyzva);
            float vstup = float.Parse(Console.ReadLine());
            return vstup;
        }

        public static double vypocetBMI(double vyska, double vaha)
        {
            double BMI = (vaha / (vyska * vyska)) * 10000;
            return BMI;
        }
        public static void Demo()
        {
            int vek = vstupInt("Věk první osoby: ");

            string jmeno = vstupString("Jméno první osoby: ");

            string prijmeni = vstupString("Příjmení první osoby: ");

            float vaha = vstupFloat("Váha první osoby: ");

            int vyska = vstupInt("Výška první osoby: ");

            int vekB = vstupInt("Věk druhé osoby: ");

            string jmenoB = vstupString("Jméno druhé osoby: ");

            string prijmeniB = vstupString("Příjmení druhé osoby: ");

            float vahaB = vstupFloat("Váha druhé osoby: ");

            int vyskaB = vstupInt("Výška druhé osoby: ");


            double BMI = vypocetBMI(vyska, vaha);
            double BMIB = vypocetBMI(vyskaB, vahaB);

            Console.WriteLine(jmeno + " " + prijmeni + " je starý(á) " + vek + " let. Váží " + vaha + " kilogramů a je " + vyska + " centimetrů vysoký/á.");

            Console.Write("Body mass index (BMI) je: " + BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine(" - Podváha.");
            }
            else if (BMI < 24.9)
            {
                Console.WriteLine(" - Norma.");
            }
            else
            {
                Console.WriteLine(" - Nadváha.");
            }

            Console.WriteLine(jmenoB + " " + prijmeniB + " je starý(á) " + vekB + " let. Váží " + vahaB + " kilogramů a je " + vyskaB + " centimetrů vysoký/á.");

            Console.Write("Body mass index (BMI) je: " + BMIB);

            if (BMIB < 18.5)
            {
                Console.WriteLine(" - Podváha.");
            }
            else if (BMIB < 24.9)
            {
                Console.WriteLine(" - Norma.");
            }
            else
            {
                Console.WriteLine(" - Nadváha.");
            }
        }

    }
}
