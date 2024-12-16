using System.Reflection.Metadata.Ecma335;
using Homework_lecture7;

internal class Program
{ 
    static void Main(string[] args)
    {

        Car car1 = new Car("Skodovka", "Octavia_Combi", 2006, 75000);
       
        
        car1.DisplayCarInfo(); 
       
        car1.Drive(500);
        
        car1.DisplayCarInfo();


       
        Car car2 = new Car("Fiat", "Doblo", 2004, 125000);

        
        car2.DisplayCarInfo();

        car2.Drive(300);

        car2.DisplayCarInfo();



        Book book1 = new Book("Mikeš", "Josef Lada", 335);

       
        book1.DisplayProgress();

        book1.Read(200);

        book1.DisplayProgress();

        
        
        Book book2 = new Book("Povídání o Pejskovi a Kočičce", "Karel Čapek", 115);

        
        book2.DisplayProgress();

        book2.Read(50);

        book2.DisplayProgress();



    }

    
}   
        
    

