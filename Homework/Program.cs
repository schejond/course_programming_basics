namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prvy objekt car1
            var car1 = new Car("Skoda", "Felicia", 1999, 300000);
            car1.DisplayCarInfo();
            Console.WriteLine("Počet kilometrov zvýšený o 123: " + car1.Drive(123) + " km");
            Console.WriteLine("");

            // Druhy objekt car2
            var car2 = new Car("Volkswagen", "Golf", 2004, 170000);
            car2.DisplayCarInfo();
            Console.WriteLine("Počet kilometrov zvýšený o 55000: " + car2.Drive(55000) + " km");

            Console.WriteLine("");
            Console.WriteLine("");

            // Prvy objekt book1
            var book1 = new Book("Nová Zem", "Eckhart Tolle", 303);
            book1.Read(123);   //Nastavený počet prečítaných strán
            book1.DisplayProgress();
            Console.WriteLine("");

            // Druhy objekt book2
            var book2 = new Book("malá kuchárka", "Anna Marienková", 283);
            book2.Read(500);   //Nastavený počet prečítaných strán
            book2.DisplayProgress();
        }
    }
}
