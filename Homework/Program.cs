namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)

        {//Jan Novák je starý 18 let. Váží 66 kilogramů a je 142 centimetrů vysoký
         //Viggo Trabalik je starý 24 let. Váží 70 kilogramů a je 190 centimetrů vysoký 

            int vekJ = 18;
            int vekV = 24;

            int mJ = 66;
            int mV = 70;

            int lJ = 142;
            int lV = 190;

            double cmj = 1.42;
            double cmv = 1.9;

            double cmmj = 1.42 * 1.42;
            double cmmv = 1.9 * 1.9;

            string InfoJ = "Jan Novak je stary " + vekJ + " let. Vazi " + mJ + " kilogramu a je " + lJ + " centimetru vysoky.";
            string InfoV = "Viggo Trabalik je stary " + vekV + " let. Vazi " + mV + " kilogramu a je " + lV + " centimetru vysoky.";

            double BMIJ = mJ / cmmj;
            double BMIV = mV / cmmv;

            string BMIJt = "Janove BMI je " + BMIJ + ".";
            string BMIVt = "Viggove BMI je " + BMIV + ".";

            Console.WriteLine(InfoJ);
            Console.WriteLine(BMIJt);
            Console.WriteLine(" ");
            Console.WriteLine(InfoV);
            Console.WriteLine(BMIVt);



        }
    }
}
