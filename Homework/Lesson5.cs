namespace Homework
{
    internal class Lesson5.cs
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

            // Výpočet BMI
            static float CalculateBMI(float weight, float height)
            {
                return weight / (height * height);
            }

            //funkce pro kategorizace BMI
            public static string KategorizaceBMI(double bmi)
            {
                if (bmi < 18.5)
                    return "Podváha";
                else if (bmi >= 18.5 && bmi < 24.9)
                    return "Normální váha";
                else if (bmi >= 25 && bmi < 29.9)
                    return "Nadváha";
                return "Obezita";
            }

           // Funkce aby dalo informace obě osobám
            static void HandlePerson(string label)
            {
                string name = GetStringInput($"Zadejte jméno {label}:");
                string surname = GetStringInput($"Zadejte příjmení {label}:");
                int age = GetIntInput($"Zadejte věk {label}:");
                float weight = GetFloatInput($"Zadejte váhu {label} (kg):");
                float height = GetFloatInput($"Zadejte výšku {label} (cm):") / 100; // Convert to meters

                // spočítání bmi a kategorizace
                double bmi = CalculateBMI(weight, height);
                string category = KategorizaceBMI(bmi);

                // informace
                Console.WriteLine($"{name} {surname} je starý(á) {age} let. Váží {weight} kilogramů a je {height * 100} centimetrů vysoký/á.");
                Console.WriteLine($"BMI: {bmi:F1} (Kategorie: {category})\n");
            }


            HandlePerson("první osoby");
            HandlePerson("druhé osoby");
        }
    }
} 
 
