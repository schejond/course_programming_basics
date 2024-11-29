namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Prosím zadej svůj věk: ");
            string VekPrvnihoUzivatele = Console.ReadLine();
            int VekPrvnihoUzivateleINT = int.Parse(VekPrvnihoUzivatele);
            Console.Write("Prosím zadej své jméno:");  
            string jménoPrvnihoUzivatele = Console.ReadLine();
            Console.Write("Prosím zadej svoji váhu: ");
            string VahaPrvnihoUzivatele = Console.ReadLine();
            double VahaPrvnihoUzivateleDouble = double.Parse(VahaPrvnihoUzivatele);
            Console.Write("Prosím zadej svou výšku: ");         // Pro vahu a vysku uzivatele jsem zvolil double, kdyby náhodou chtel byt nejaky uzivatel presny :D
            string VyskaPrvnihoUzivatele = Console.ReadLine();
            double VyskaPrvnihoUzivateleDouble = double.Parse(VyskaPrvnihoUzivatele);
            double VyskaPrvnihoUzivateleDoubleConvert = double.Parse(VyskaPrvnihoUzivatele) / 100;

            Console.WriteLine(jménoPrvnihoUzivatele + " je starý(á) " + VekPrvnihoUzivatele + " let. Váží " + VahaPrvnihoUzivatele + " kilogramů a je " + VyskaPrvnihoUzivatele + " centimetrů vysoký(á).");

            Console.WriteLine("Super, pojďme si vypočítát tvé BMI");
            double BmiIndex1 = VahaPrvnihoUzivateleDouble / (VyskaPrvnihoUzivateleDoubleConvert * VyskaPrvnihoUzivateleDoubleConvert);
            double BmiIndexZaokrouhleno1 = Math.Round(BmiIndex1); //nasel jsem si jak zaokrouhlit cislo v C#
            Console.WriteLine("Tvé Bmi je: " + BmiIndexZaokrouhleno1);






            Console.WriteLine("Vypadá to, že se připojil druhý uřivatel. Pojdmě celý program zopakovat!");
            Console.Write("Prosím zadej svůj věk: ");
            string VekDruhehoUzivatele = Console.ReadLine();
            int VekDruhehoUzivateleINT = int.Parse(VekDruhehoUzivatele);
            Console.Write("Prosím zadej své jméno:");
            string jménoDruhehoUzivatele = Console.ReadLine();
            Console.Write("Prosím zadej svoji váhu: ");
            string VahaDruhehoUzivatele = Console.ReadLine();
            double VahaDruhehoUzivateleDouble = double.Parse(VahaPrvnihoUzivatele);
            Console.Write("Prosím zadej svou výšku: ");         // Pro vahu a vysku uzivatele jsem zvolil double, kdyby náhodou chtel byt nejaky uzivatel presny :D
            string VyskaDruhehoUzivatele = Console.ReadLine();
            double VyskaDruhehoUzivateleDouble = double.Parse(VyskaDruhehoUzivatele);
            double VyskaDruhehoUzivateleDoubleConvert = double.Parse(VyskaDruhehoUzivatele) / 100;
            
            Console.WriteLine(jménoDruhehoUzivatele + " je starý(á) " + VekDruhehoUzivatele + " let. Váží " + VahaDruhehoUzivatele + " kilogramů a je " + VyskaDruhehoUzivatele + " centimetrů vysoký(á).");
            double BmiIndex2 = VahaDruhehoUzivateleDouble / (VyskaDruhehoUzivateleDoubleConvert * VyskaDruhehoUzivateleDoubleConvert);
            double BmiIndex2Zaokrouhleno = Math.Round(BmiIndex2);
            Console.WriteLine("Tve BMI je: " + BmiIndex2Zaokrouhleno);
        }
    }
}
