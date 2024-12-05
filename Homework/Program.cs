using System.Runtime.Intrinsics.X86;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = UserInputWMessage_ToInt("Uvedte pocet uzivatelu");
            ConfusingCycle(people);

            
        }
        private static double CalculateBMI(int heightCM, int weight)
        {
            double height_meters = (double)heightCM / 100;
            double BMI = weight / Math.Pow(height_meters, 2);
            return BMI;
        }

        private static string UserInputWMessage(string message)
        {
            Console.WriteLine(message);
            string user_input = Console.ReadLine();
            return user_input;
        }

        private static int UserInputWMessage_ToInt (string message)
        {
            Int32.TryParse(UserInputWMessage(message), out int converted_int);
            return converted_int;
        }

        private static void ConfusingCycle(int number_of_cycles)
        {
            for (int i = 0; i < number_of_cycles; i++)
            {
                //Input and Output of NAME, SURNAME, AGE, WEIGHT, HEIGHT
                Console.WriteLine((i + 1) + ". osoba");

                string name = UserInputWMessage("\nJmeno:");

                string surname = UserInputWMessage("\nPrijmeni:");

                int age = UserInputWMessage_ToInt("\nVek:");


                int weight = UserInputWMessage_ToInt("\nVaha (kg):");


                int height = UserInputWMessage_ToInt("\nVaha (kg):");


                //Console.WriteLine("\n" + name + " je starý(á) " + age_string + " let. Váží " + weight_string + " kilogramů a je " + height_string + " centimetrů vysoký/á.\n");
                Console.WriteLine("\n" + name + " je starý(á) " + age + " let. Váží " + weight + " kilogramů a je " + height + " centimetrů vysoký/á.\n");


                Console.WriteLine("BMI = " + CalculateBMI(height, weight) + "\n");

            }

            
        }
    }
}
