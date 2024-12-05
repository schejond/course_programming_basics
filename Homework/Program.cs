namespace ConsoleApp6
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

            
            static void DisplayPersonInfo(string firstName, string lastName, int age, float weight, float height)
            {
                float bmi = CalculateBMI(weight, height);
                Console.WriteLine($"{firstName} {lastName} je starý(á) {age} let. Váží {weight} kilogramů a je {height * 100} centimetrů vysoký/á.");
                Console.WriteLine($"BMI této osoby je: {bmi:F2}\n");
            }

            static void Main(string[] args)
            {
                
                string firstName1 = GetStringInput("Zadejte jméno první osoby:");
                string lastName1 = GetStringInput("Zadejte příjmení první osoby:");
                int age1 = GetIntInput("Zadejte věk první osoby:");
                float weight1 = GetFloatInput("Zadejte váhu první osoby (v kg):");
                float height1 = GetFloatInput("Zadejte výšku první osoby (v metrech):");

                
                DisplayPersonInfo(firstName1, lastName1, age1, weight1, height1);

                
                string firstName2 = GetStringInput("Zadejte jméno druhé osoby:");
                string lastName2 = GetStringInput("Zadejte příjmení druhé osoby:");
                int age2 = GetIntInput("Zadejte věk druhé osoby:");
                float weight2 = GetFloatInput("Zadejte váhu druhé osoby (v kg):");
                float height2 = GetFloatInput("Zadejte výšku druhé osoby (v metrech):");

               
                DisplayPersonInfo(firstName2, lastName2, age2, weight2, height2);
            }
        }
    }
}
