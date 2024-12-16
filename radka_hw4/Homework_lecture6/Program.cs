using System;
using System.Linq;

namespace Homework_lecture6
{
    internal class Program
    {
        static int[] SeraditVzestupne(int[] vstup)
        {
            if (vstup == null)
                return null;
            return vstup.Order().ToArray();
        }
        static int[] ObratitPoradi(int[] vstup)
        {
            if (vstup == null)
                return null;
           return vstup.Reverse().ToArray();
        }
        static int[] OdebratPrvni(int[] vstup)
        {
            if (vstup == null)
                return null;
            return vstup.Skip(1).ToArray();
        }
        static int[] OdebratPosledni(int[] vstup)
        {
            if (vstup == null)
                return null;
            return vstup.SkipLast(1).ToArray();


        }
        static int[] OdebratPrvek(int[] vstup, int index)
        {
            if (vstup == null)
                return null;
            if (vstup.Length == 0)
                return vstup;
            if (index < 0 || index >= vstup.Length)
                return vstup;
            int[] vystup = new int[vstup.Length-1];

            int vystpniIndex = 0;
            for (int i = 0; i < vstup.Length; i++) 
            {
                if (i == index)
                    continue;
                vystup[vystpniIndex++] = vstup[i];

            }
            return vystup;
        }

        static int[] PridejNaZacatek(int[] vstup, int hodnota)
        {
            if (vstup == null)
                return null;
            return [hodnota, ..vstup];
        }

        static int[] PridejNaKonec(int[] vstup, int hodnota)
        {
            if (vstup == null)
                return null;
            return [.. vstup, hodnota];
        }

        static int[] PridejNaIndex(int[] vstup, int hodnota, int index)
        {
            if (vstup == null)
                return null;
            return [.. vstup.Take(index), hodnota, ..vstup.Skip(index)];
        }

        static void Vypis(int[] vstup) 
        {
            if (vstup == null)
            {
                Console.Write("null");
                return;
            }
            Console.Write("{ ");
            for (int i = 0; i < vstup.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(vstup[i]);
            }
            Console.Write(" }");
        }

        static void Main(string[] args)
        {
            int[] cisla = { 1, 5, 8, 3, 10, -5};

            Console.Write("Počáteční čísla: ");
            Vypis(cisla);
            Console.WriteLine();

            Console.Write("Seřazená čísla: ");
            Vypis(SeraditVzestupne(cisla));
            Console.WriteLine();

            Console.Write("Obrácené pořadí: ");
            Vypis(ObratitPoradi(cisla));
            Console.WriteLine();

            Console.Write("Odebrat první ");
            Vypis(OdebratPrvni(cisla));
            Console.WriteLine();

            Console.Write("Odebrat Poslední");
            Vypis(OdebratPosledni(cisla));
            Console.WriteLine();

            Console.Write("Odebraný třetí prvek: ");
            Vypis(OdebratPrvek(cisla,2));
            Console.WriteLine();

            Console.Write("Přidání na začátek: ");
            Vypis(PridejNaZacatek(cisla,4));
            Console.WriteLine();

            Console.Write("Přidání na konec: ");
            Vypis(PridejNaKonec(cisla, -8));
            Console.WriteLine();

           Console.Write("Přidaný prvek: ");
            Vypis(PridejNaIndex(cisla, 99, 2));
            Console.WriteLine();











            

        }
    }
}
