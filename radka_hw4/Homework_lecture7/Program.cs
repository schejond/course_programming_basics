using System.Reflection.Metadata.Ecma335;
using Homework_lecture7;

internal class Program
{ 
    static void Main(string[] args)
    {

        Car car = new Car("Skodovka", "Octavia_Combi", 2006, 75000);
       
        car.DisplayCarInfo(); 
       
        car.Drive(500);
        
        car.DisplayCarInfo();


        Book book = new Book("Mikeš", "Josef Lada", 335);

        book.DisplayProgress();

        book.Read(200);

        book.DisplayProgress();




    }

    
}   
        
    

