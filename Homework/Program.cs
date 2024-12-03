namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
<<<<<<< Updated upstream
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
=======
        {
            Console.WriteLine("Ahoj vítám tě v mém programu!");
            string name = JmenoUzivatele();
            int vek = Vek();
            double vyska = VyskaodUzivatele();
            double vaha = VahaUzivatele();
            //string zprava = Zprava();
            Console.WriteLine(name + " je starý(á) " + vek + " let. Váží " + vaha + " kilogramů a je " + vyska + " centimetrů vysoký(á).");

            double height = vyska / 100;
            double weight = vaha;
            double bmi = CalculateBmiIndex(height, weight);
            double BmiRounded = Math.Round(bmi);
            Console.WriteLine("Vaše bmi je " + BmiRounded);

            if (BmiRounded <= 15)
            {
                Console.WriteLine("Tohle není úplně zdravé, zkus přibrat");
            }
            else if (BmiRounded >= 15 && BmiRounded <= 45)
            {
                Console.WriteLine("Mas idealni BMI");
            }
            else
            {
                Console.WriteLine("Zkus zhubnout");
            }

>>>>>>> Stashed changes
        }
        public static int Vek()
        {
            Console.Write("Prosim zadej svuj vek");
            string VekUzivatele = Console.ReadLine();
            int VekUzivateleInt = int.Parse(VekUzivatele);
            return VekUzivateleInt;
        }
        public static double CalculateBmiIndex(double height, double weight)
        {
            var bmi = weight / (height * height);
            return bmi;

        }
        public static double VyskaodUzivatele()
        {
            Console.Write("Prosim zadej svou vysku v cm ");
            string vstupVyska = Console.ReadLine();
            double VyskaDouble = double.Parse(vstupVyska);
            return VyskaDouble;
        }
        public static string JmenoUzivatele()
        {
            Console.Write("Prosim zadej sve jmeno ");
            string JmenoUzivatele = Console.ReadLine();
            return JmenoUzivatele;
        }
        public static double VahaUzivatele()
        {
            Console.Write("Prosim zadej svou hmotnost ");
            string VahaUzivatele = Console.ReadLine();
            double VahaUzivateleDouble = double.Parse(VahaUzivatele);
            return VahaUzivateleDouble;
        }
        /*public static string Zprava()
        {
            string zpravaProUzivatele = (JmenoUzivatele() + " je starý(á) " + Vek() + " let. Váží " + VahaUzivatele() + " kilogramů a je " + VyskaodUzivatele() + " centimetrů vysoký(á).");
            Console.WriteLine(zpravaProUzivatele);
            return zpravaProUzivatele;
                }*/


    }
}
