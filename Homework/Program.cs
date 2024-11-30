namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State your name.");
            string name = Console.ReadLine();

            Console.WriteLine("State your surname.");
            string surname = Console.ReadLine();

            Console.WriteLine("State your age.");
            string age_string = Console.ReadLine();
            Int32.TryParse(age_string, out int age);

            Console.WriteLine("State your weight.");
            string weight_string = Console.ReadLine();
            Int32.TryParse(weight_string, out int weight);

            Console.WriteLine("State your height.");
            string height_string = Console.ReadLine();
            Int32.TryParse(height_string, out int height);


            Console.WriteLine(name + " je starý(á) " + age_string + " let.Váží " + weight_string + " kilogramů a je " + height_string + " centimetrů vysoký / á.");







            Console.WriteLine("Your name is " + name);
        }
    }
}
