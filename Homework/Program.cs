namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj údaje prvej osoby:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("meno: ");
            string menoPrvejOsoby = Console.ReadLine();

            Console.Write("priezvisko: ");
            string priezviskoPrvejOsoby = Console.ReadLine();

            Console.Write("vek: ");
            string vekPrvejOsoby = Console.ReadLine();

            Console.Write("váha v kg: ");
            string vahaPrvejOsoby = Console.ReadLine();

            Console.Write("výška v cm: ");
            string vyskaPrvejOsoby = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine(menoPrvejOsoby + " " + priezviskoPrvejOsoby + " je starý/á " + vekPrvejOsoby + " rokov. Váži " + vahaPrvejOsoby + " kilogramov a je " + vyskaPrvejOsoby + " centimetrov vysoký/á.");

            // Výpočet BMI prvej osoby
            int vahaPrvejOsobyCislo = int.Parse(vahaPrvejOsoby);
            int vyskaPrvejOsobyCislo = int.Parse(vyskaPrvejOsoby);
            double vyskaPrvejOsobyvMetroch = vyskaPrvejOsobyCislo * 0.01;
            double bmiPrvejOsoby = vahaPrvejOsobyCislo / (vyskaPrvejOsobyvMetroch * vyskaPrvejOsobyvMetroch);

            Console.WriteLine("Jeho/Jej index telesnej hmotnosti BMI je: " + bmiPrvejOsoby);
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Zadaj údaje druhej osoby:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("meno: ");
            string menoDruhejOsoby = Console.ReadLine();

            Console.Write("priezvisko: ");
            string priezviskoDruhejOsoby = Console.ReadLine();

            Console.Write("vek: ");
            string vekDruhejOsoby = Console.ReadLine();

            Console.Write("váha v kg: ");
            string vahaDruhejOsoby = Console.ReadLine();

            Console.Write("výška v cm: ");
            string vyskaDruhejOsoby = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine(menoDruhejOsoby + " " + priezviskoDruhejOsoby + " je starý/á " + vekDruhejOsoby + " rokov. Váži " + vahaDruhejOsoby + " kilogramov a je " + vyskaDruhejOsoby + " centimetrov vysoký/á.");

            // Výpočet BMI druhej osoby
            int vahaDruhejOsobyCislo = int.Parse(vahaDruhejOsoby);
            int vyskaDruhejOsobyCislo = int.Parse(vyskaDruhejOsoby);
            double vyskaDruhejOsobyvMetroch = vyskaDruhejOsobyCislo * 0.01;
            double bmiDruhejOsoby = vahaDruhejOsobyCislo / (vyskaDruhejOsobyvMetroch * vyskaDruhejOsobyvMetroch);

            Console.WriteLine("Jeho/Jej index telesnej hmotnosti BMI je: " + bmiDruhejOsoby);



        }
    }
}
