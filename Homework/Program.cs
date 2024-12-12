using System;

namespace Program.cs
{
    // Třída reprezentující auto
    public class Car
    {
        // Vlastnosti (properties)
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Konstruktor, který inicializuje všechny vlastnosti
        public Car(string brand, string model, int year, int mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        // Metoda pro přidání kilometrů
        public void Drive(int kilometers)
        {
            Mileage += kilometers;
        }

        // Metoda pro zobrazení informací o autě
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km");
        }
    }

    // Třída reprezentující knihu
    public class Book
    {
        // Vlastnosti (properties)
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }

        // Konstruktor, který inicializuje všechny vlastnosti
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
            CurrentPage = 0; // Výchozí hodnota pro aktuální stránku
        }

        // Metoda pro přidání přečtených stran
        public void Read(int pages)
        {
            CurrentPage += pages;
            if (CurrentPage > Pages)
            {
                CurrentPage = Pages; // Pokud přečteme více než je počet stran, nastavíme na maximum
            }
        }

        // Metoda pro zobrazení pokroku v knize
        public void DisplayProgress()
        {
            Console.WriteLine($"Reading '{Title}' by {Author}: {CurrentPage}/{Pages} pages read");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření objektu třídy Car
            Car car1 = new Car("Porsche", "GT3-911", 2009, 25340);
            Car car2 = new Car("Ferrari", "Monza SP1", 2018, 10356);

            // Použití metod třídy Car
            car1.DisplayCarInfo();
            car2.DisplayCarInfo();
            car1.Drive(100);
            car2.Drive(200);
            car1.DisplayCarInfo();
            car2.DisplayCarInfo();

            Console.WriteLine();

            // Vytvoření objektu třídy Book
            Book book1 = new Book("Harry Potter And The Phillosophers Stone", "J.K. Rowling", 320;
            Book book2 = new Book("1984", "George Orwell", 328);

            // Použití metod třídy Book
            book1.DisplayProgress();
            book2.DisplayProgress();
            book1.Read(50);
            book2.Read(100);
            book1.DisplayProgress();
            book2.DisplayProgress();
        }
    }
}
