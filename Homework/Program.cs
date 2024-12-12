namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vstupnePole = new int[5];

            // Verzia a.
            //vstupnePole = null;

            // Verzia b.
            //vstupnePole[0] = 0;
            //vstupnePole[1] = 0;
            //vstupnePole[2] = 0;
            //vstupnePole[3] = 0;
            //vstupnePole[4] = 0;

            // Verzia c.
            vstupnePole[0] = 1;
            vstupnePole[1] = 2;
            vstupnePole[2] = 3;
            vstupnePole[3] = 5;
            vstupnePole[4] = 4;

            // Verzia d.
            //vstupnePole[0] = 5;
            //vstupnePole[1] = 4;
            //vstupnePole[2] = 3;
            //vstupnePole[3] = 2;
            //vstupnePole[4] = 1;

            var pracovnePole = new int[5];
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            var vyslednePole = new int[5];
            var mensieVyslednePole = new int[4];
            var vacsieVyslednePole = new int[6];

            Console.WriteLine("1.Zoradené pole:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            vyslednePole = zoradeniePola(pracovnePole);
            vypisaniePola(vyslednePole);
            Console.WriteLine("");

            Console.WriteLine("2.Obrátené poradie poľa:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            vyslednePole = obratPoradiePola(pracovnePole);
            vypisaniePola(vyslednePole);
            Console.WriteLine("");

            Console.WriteLine("3.Odobratie prvého elementu poľa:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            mensieVyslednePole = odobranyPrvyElement(pracovnePole);
            vypisaniePola(mensieVyslednePole);
            Console.WriteLine("");

            Console.WriteLine("4.Odobratie posledného elementu poľa:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            mensieVyslednePole = odobranyPoslednyElement(pracovnePole);
            vypisaniePola(mensieVyslednePole);
            Console.WriteLine("");

            int odoberElement = 3;
            Console.WriteLine("5.Odobratie " + odoberElement + " elementu z poľa:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            mensieVyslednePole = odobranyDanyElement(pracovnePole, odoberElement);
            vypisaniePola(mensieVyslednePole);
            Console.WriteLine("");

            Console.WriteLine("6.Vloženie elementu na začiatok poľa:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            vacsieVyslednePole = pridanyPrvyElement(pracovnePole);
            vypisaniePola(vacsieVyslednePole);
            Console.WriteLine("");

            Console.WriteLine("7.Vloženie elementu na koniec poľa:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            vacsieVyslednePole = pridanyPoslednyElement(pracovnePole);
            vypisaniePola(vacsieVyslednePole);
            Console.WriteLine("");

            int pridajNaElement = 4;
            Console.WriteLine("8.Vloženie elementu na " + pridajNaElement + " index poľa:");
            doplnenieHodnotDoPracovnehoPola(vstupnePole, pracovnePole);
            vypisaniePola(vstupnePole);
            vacsieVyslednePole = pridanyDanyElement(pracovnePole, pridajNaElement);
            vypisaniePola(vacsieVyslednePole);
            Console.WriteLine("");
        }

         //  FUNKCIE

         // Doplnenie hodnot do pracovneho pola
         static void doplnenieHodnotDoPracovnehoPola(int[] vstupnePole, int[] pracovnePole)
         {
             if (vstupnePole == null)
             {
                 pracovnePole = null;
             }
             else
             {
                 for (int i = 0; i < vstupnePole.Length; i++)
                 {
                     pracovnePole[i] = vstupnePole[i];
                 }
             }
         }

                  //  Vypisanie pola
         static void vypisaniePola(int[] vypisanePole)
         {
             if (vypisanePole == null)
             {
                 Console.Write("null");
             }
             else
             {
                 foreach (int prvokPola in vypisanePole)
                 {
                     Console.Write(prvokPola + " ");
                 }
             }
             Console.WriteLine("");
         }

                  // 1.Zoradenie pola
         static int[] zoradeniePola(int[] zoradenePole)
         {
             if (zoradenePole == null)
             {
                 zoradenePole = null;
             }
             else
             {
                 Array.Sort(zoradenePole);
             } 
             return zoradenePole;
         }

                  // 2.Obratenie poradia pola
         static int[] obratPoradiePola(int[] obratenePole)
         {
             if (obratenePole == null)
             {
                obratenePole = null;
             }
             else
             {
                 Array.Reverse(obratenePole);
             }
             return obratenePole;
         }

                  // 3.Odobratie prveho elemntu pola
         static int[] odobranyPrvyElement(int[] povodnePole)
         {
             var upravenePole = new int[povodnePole.Length - 1];
             if (povodnePole == null)
             {
                 upravenePole = null;
             }
             else
             {
                 for (int i = 0; i < povodnePole.Length; i++)
                 {
                     if (i != 0) { upravenePole[i - 1] = povodnePole[i]; }
                 }
             }
             return upravenePole;
         }

                  // 4.Odobratie posledneho elemntu pola
         static int[] odobranyPoslednyElement(int[] povodnePole)
         {
             var upravenePole = new int[povodnePole.Length - 1];
             if (povodnePole == null)
             {
                 upravenePole = null;
             }
             else
             {
                 for (int i = 0; i < povodnePole.Length; i++)
                 {
                     if (i != povodnePole.Length - 1)
                     {
                         upravenePole[i] = povodnePole[i];
                     }
                 }
             }
             return upravenePole;
         }

                  // 5.Odobratie elemntu z daneho indexu pola
         static int[] odobranyDanyElement(int[] povodnePole, int odoberElement)
         {
             var upravenePole = new int[povodnePole.Length - 1];
             if (povodnePole == null)
             {
                 upravenePole = null;
             }
             else
             {
                 int ii = 0;
                 for (int i = 0; i < povodnePole.Length; i++)
                 {
                     if (i != odoberElement - 1)
                     {
                         upravenePole[ii] = povodnePole[i];
                         ii++;
                     }
                 }
             }
             return upravenePole;
         }

                  // 6.Vlozenie elemntu na zaciatok pola
         static int[] pridanyPrvyElement(int[] povodnePole)
         {
             var upravenePole = new int[povodnePole.Length + 1];
             if (povodnePole == null)
             {
                 upravenePole = null;
             }
             else
             {
                 for (int i = 0; i <= povodnePole.Length; i++)
                 {
                     if (i != 0) { upravenePole[i] = povodnePole[i - 1]; }
                 }
             }
             return upravenePole;
         }

                  // 7.Vlozenie elemntu na koniec pola
         static int[] pridanyPoslednyElement(int[] povodnePole)
         {
             var upravenePole = new int[povodnePole.Length + 1];
             if (povodnePole == null)
             {
                 upravenePole = null;
             }
             else
             {
                 for (int i = 0; i < povodnePole.Length; i++)
                 {
                     if (i != povodnePole.Length)
                     { upravenePole[i] = povodnePole[i]; }
                 }
             }
             return upravenePole;
         }

                  // 8.Vlozenie elemntu na dany index pola
         static int[] pridanyDanyElement(int[] povodnePole, int pridajNaElement)
         {
             var upravenePole = new int[povodnePole.Length + 1];
             if (povodnePole == null)
             {
                 upravenePole = null;
             }
             else
             {
                 int ii = 0;
                 for (int i = 0; i <= povodnePole.Length; i++)
                 {
                     if (i != pridajNaElement)
                     {
                         upravenePole[i] = povodnePole[ii];
                         ii++;
                     }
                 }
             }
             return upravenePole;
         }
    }
}
