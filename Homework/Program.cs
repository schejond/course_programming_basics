namespace Homework5 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int GetIntInput(string prompt)
            {
                Console.WriteLine(prompt);
                return int.Parse(Console.ReadLine());
            }

            
            static float GetFloatInput(string prompt)
            {
                Console.WriteLine(prompt);
                return float.Parse(Console.ReadLine());
            }

           
            static string GetStringInput(string prompt)
            {
                Console.WriteLine(prompt);
                return Console.ReadLine();
            }

           
            static float CalculateBMI(float weight, float height)
            {
                return weight / (height * height);
            }

              // Funkce pro určení kategorie podle BMI
    public static string KategorizaceBMI(double bmi)
    {
        if (bmi < 18.5)
            return "Podváha";
        else if (bmi >= 18.5 && bmi < 24.9)
            return "Normální váha";
        else if (bmi >= 25 && bmi < 29.9)
            return "Nadváha";
    }

    static void Main(string[] args)
    {
        // Načítání údajů pro první osobu
        string jmeno1 = NactiVstupString("Zadejte jméno první osoby:");
        string prijmeni1 = NactiVstupString("Zadejte příjmení první osoby:");
        int vek1 = NactiVstupInt("Zadejte věk první osoby:");
        float vaha1 = NactiVstupFloat("Zadejte váhu první osoby (kg):");
        float vyska1 = NactiVstupFloat("Zadejte výšku první osoby (cm):") / 100; // převod na metry

        // Výpočet BMI pro první osobu
        double bmi1 = VypocetBMI(vaha1, vyska1);
        string kategorie1 = KategorizaceBMI(bmi1);

        // Zobrazení informací pro první osobu
        Console.WriteLine($"{jmeno1} {prijmeni1} je starý(á) {vek1} let. Váží {vaha1} kilogramů a je {vyska1 * 100} centimetrů vysoký/á.");
        Console.WriteLine($"BMI: {bmi1:F1} (Kategorie: {kategorie1})\n");

        // Načítání údajů pro druhou osobu
        string jmeno2 = NactiVstupString("Zadejte jméno druhé osoby:");
        string prijmeni2 = NactiVstupString("Zadejte příjmení druhé osoby:");
        int vek2 = NactiVstupInt("Zadejte věk druhé osoby:");
        float vaha2 = NactiVstupFloat("Zadejte váhu druhé osoby (kg):");
        float vyska2 = NactiVstupFloat("Zadejte výšku druhé osoby (cm):") / 100; // převod na metry

        // Výpočet BMI pro druhou osobu
        double bmi2 = VypocetBMI(vaha2, vyska2);
        string kategorie2 = KategorizaceBMI(bmi2);

        // Zobrazení informací pro druhou osobu
        Console.WriteLine($"{jmeno2} {prijmeni2} je starý(á) {vek2} let. Váží {vaha2} kilogramů a je {vyska2 * 100} centimetrů vysoký/á.");
        Console.WriteLine($"BMI: {bmi2:F1} (Kategorie: {kategorie2})");
        }
        }
    }
}
