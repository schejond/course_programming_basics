namespace Homework
{
    public class Lesson5
    {
        public static void Demo()
        {
            Console.Write("Testovanie bude pre pocet osob: ");

            int pocettestovani = int.Parse(Console.ReadLine());

            for (int t = 1; t <= pocettestovani; t++)

            {
                string name = GetInputAsString("Zadajte svoje meno a priezvisko: ");
                int age = GetInputAsInt("Zadajte svoj vek ");
                int height = GetInputAsInt2("Zadajte svoju vysku v cm: ");
                float weight = GetInputAsFloat("Zadajte svoju hmotnost v kg: ");

                float heightinmetres = height * 0.01f;

                double BMI = weight / (heightinmetres * heightinmetres);


                Console.WriteLine(name + " je stary(a) " + age + " rokov. Vazi " + weight + " kilogramov a je " + height + " centimetrov vysoky/a.");

                Console.WriteLine("Vysledne BMI po testovani je: " + Math.Round(BMI, 1));

                if (BMI < 17.9)
                {
                    Console.WriteLine("Respondent spada do kategorie: Ektomorf .", ConsoleColor.Yellow);
                }
                else if (BMI >= 18 && BMI <= 24.9)
                {
                    Console.WriteLine("Respondent spada do kategorie: Mezomorf", ConsoleColor.Blue);
                }
                else
                {
                    Console.WriteLine("Respondent spada do kategorie: Endormorf", ConsoleColor.Red);
                }
            }
        }

        public static string GetInputAsString(string name)
        {
            Console.Write(name);
            return Console.ReadLine();
        }

        public static int GetInputAsInt(string age)
        {
            Console.Write(age);
            return int.Parse(Console.ReadLine());
        }

        public static int GetInputAsInt2(string height)
        {
            Console.Write(height);
            return int.Parse(Console.ReadLine());
        }

        public static float GetInputAsFloat(string weight)
        {
            Console.Write(weight);
            return float.Parse(Console.ReadLine());
        }
    }
}
        
            
        
    

