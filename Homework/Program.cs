using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cyklus pre lubovlny pocet osob
            int pocetOsob = ZadanieVyskaVekOsoby("Zadaj počet osôb: ");
            //Console.WriteLine("Zadaj počet osôb: ");
            //int pocetOsob = int.Parse(Console.ReadLine());
            for (int osoba = 1; osoba <= pocetOsob; osoba++)
            {
                string Meno = ZadanieMenoPriezviskoOsoby($"Zadaj meno osoby {osoba}");
                string Priezvisko = ZadanieMenoPriezviskoOsoby($"Zadaj priezvisko osoby {osoba}");
                int Vek = ZadanieVyskaVekOsoby($"Zadaj vek osoby {osoba} v rokoch");
                float Vaha = ZadanieVahyOsoby($"Zadaj hmotnosť osoby {osoba} v kg");
                int Vyska = ZadanieVyskaVekOsoby($"Zadaj výšku osoby {osoba} v cm");

                Console.WriteLine("{0} {1} je starý(á) {2} rokov. Váži {3} kg a je {4} cm vysoký(á).",
                   Meno, Priezvisko, Vek, Vaha, Vyska);

                float BMI = vypocetBMI(Vaha,Vyska);
               
                Console.WriteLine("Jeho/jej BMI je {0}", BMI);
                ZmenaFarby("BMI kritéria sú platné pre európsku populáciu:", ConsoleColor.DarkYellow);
                if (BMI < 18.5)
                {
                    ZmenaFarby("Tvoje BMI je do 18,5 čo znamená, že si podvýživený(á) musíš pribrať!", ConsoleColor.Red);
                }
                else if (BMI < 25)
                {
                    ZmenaFarby("Tvoje BMI je od 18,5 do 25 čo znamená, že tvoja váha je ideálna drž sa jej.", ConsoleColor.Green);
                }
                else if (BMI < 30)
                {
                    ZmenaFarby("Tvoje BMI je od 25 do 30 čo znamená, že máš miernu nadváhu mal(a) by si sa nad sebou zamyslieť!", ConsoleColor.Yellow);
                }
                else if (BMI < 40)
                {
                    ZmenaFarby("Tvoje BMI je od 30 do 40 čo znamená, že máš už obezitu mal(a) by si prestať jesť toľko sladkostí!!", ConsoleColor.Red);
                }
                else
                {
                    ZmenaFarby("Tvoje BMI je vačšie ako 40 čo znamená, že máš už ťažkú obezitu mal(a) prestať ťoľko jesť a začať cvičiť!!!!!!!!", ConsoleColor.DarkRed);
                }
            }
        }
        public static string ZadanieMenoPriezviskoOsoby(string vyzvaString)
        {

            while (true)
            {
                Console.WriteLine(vyzvaString);
                string MenoPriezvisko = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(MenoPriezvisko) || double.TryParse(MenoPriezvisko, out _))
                {
                    ZmenaFarby("Zadal si neplatné znaky zadaj text! Skús to znova.", ConsoleColor.Red);
                }
                else
                {
                    return MenoPriezvisko;
                }
            }
        }

        public static int ZadanieVyskaVekOsoby(string vyzvaString)
        {
            while (true) 
            {
                Console.WriteLine(vyzvaString);
                string zadanaHodnota = Console.ReadLine();
                if (int.TryParse(zadanaHodnota, out int intHodnota))
                {
                    return intHodnota;
                }
                else
                {
                    ZmenaFarby("Zadal si neplatnú hodnotu! Skús to znova a zadaj celé číslo.", ConsoleColor.Red);
                }
            }
        }


        public static float ZadanieVahyOsoby(string vyzvaString)
        {
            while (true)
            {
                Console.WriteLine(vyzvaString);
                string zadanaHodnota = Console.ReadLine();
                if (float.TryParse(zadanaHodnota, out float floatHodnota))
                {
                    return floatHodnota;
                }

                else
                {
                    ZmenaFarby("Zadal si neplatnú hodnotu! Skús to znova a zadaj číslo.", ConsoleColor.Red);
                }
            }

        }

        public static float vypocetBMI(float vaha, float vyska)
        {
            float vyskaVMetroch = (float)(vyska / 100.0f);
            float BMI = vaha / (vyskaVMetroch * vyskaVMetroch);
            return BMI;
        }

        public static void ZmenaFarby(string text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }
    }
}
