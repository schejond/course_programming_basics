namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string JN = "Jan Novak";
        
            string RNJ = "Zadejte vek Jana Novaka: ";
            Console.WriteLine(RNJ);
            string uzivatelzadalvekJN = Console.ReadLine();
            Console.WriteLine("Vek Jana Novaka je: " + uzivatelzadalvekJN + " " + "let");

            string cmNJ = "Zadejte vysku Jana Novaka (cm): ";
            Console.WriteLine(cmNJ);
            string uzivatelzadalvyskuJN = Console.ReadLine();
            Console.WriteLine("Vyska Jana Novaka je: " + uzivatelzadalvyskuJN + "cm");

            string kgNJ = "Zadejte vahu Jana Novaka (kg): ";
            Console.WriteLine(kgNJ);
            string uzivatelzadalvahuJN = Console.ReadLine();
            Console.WriteLine("Vaha Jana Novaka je: " + uzivatelzadalvahuJN + "kg");

            int BMIkgJN = int.Parse(uzivatelzadalvahuJN);
            double BMIcmJN = int.Parse(uzivatelzadalvyskuJN);

            double jmenovatelJN = BMIcmJN / 100;

            double BMI = BMIkgJN / (jmenovatelJN * jmenovatelJN);
                            
            string BMIJN = "BMI index Jana Novaka je: ";
            Console.WriteLine(BMIJN + BMI);

            Console.WriteLine(JN + " " + "je starý " + uzivatelzadalvekJN + " " + "let. Vazi " 
                + BMIkgJN + " " + "kilogramu a je " + BMIcmJN + " " + "centimetru vysoky.");



            string osoba2 = "Napiste sve jmeno: ";
            Console.WriteLine(osoba2);
            string osoba2jm = Console.ReadLine();
            Console.WriteLine("Jmenujes se: " + osoba2jm);

            string Ros2 = "Zadej svuj vek: ";
            Console.WriteLine(Ros2);
            string Ros2zadalvek = Console.ReadLine();
            Console.WriteLine("Tvuj vek je: " + Ros2zadalvek + " " + "let");

            string cmos2 = "Zadej svoji vysku (cm): ";
            Console.WriteLine(cmos2);
            string cmos2zadalvysku = Console.ReadLine();
            Console.WriteLine("Tvoje vyska je: " + cmos2zadalvysku + "cm");

            string kgos2 = "Zadej svoji vahu (kg): ";
            Console.WriteLine(kgos2);
            string kgos2zadalvahu = Console.ReadLine();
            Console.WriteLine("Tvoje vaha je: " + kgos2zadalvahu + "kg");

            int BMIkgOs2 = int.Parse(kgos2zadalvahu);
            double BMIcmOs2 = int.Parse(cmos2zadalvysku);

            double jmenovatelOs2 = BMIcmOs2 / 100;

            double BMI_2 = BMIkgOs2 / (jmenovatelOs2 * jmenovatelOs2);

            string BMIOs2 = "BMI index" + " " + osoba2jm + " " + "je: ";
            Console.WriteLine(BMIOs2 + BMI_2);

            Console.WriteLine(osoba2jm + " " + "je stary/a " + Ros2zadalvek + " " + "let. Vazi " 
                + BMIkgOs2 + " " + "kilogramu a je " + BMIcmOs2 + " " + "centimetru vysoky/a."); 
            
            
          
        }
    }
}
