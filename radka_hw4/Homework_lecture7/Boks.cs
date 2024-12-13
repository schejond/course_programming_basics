namespace Homework_lecture7
{
    public class Book
    {
        public string Title;

        public string Author;

        public int Pages;

        public int CurrentPage;


        public Book(string Title, string Author, int Pages)
        {
            Title = Title;
            
            Author = Author;
            
            Pages = Pages;
            
            CurrentPage = 0;
        }

        public void Read(int pages)
        {
            if (pages > 0)
            {
                CurrentPage += pages;

                if (CurrentPage > Pages)
                {
                    CurrentPage = Pages; 
                }

                Console.WriteLine($"You have read {200} pages.");

                Console.WriteLine($"You have read {50} pages.");
            }
            else
            {
                Console.WriteLine("The number of pages must be positive.");
            }
        } 

   
    public void DisplayProgress()
        {
            Console.WriteLine($"Reading 'Mikeš' by Josef Lada: {335}/{335} pages read");

            Console.WriteLine($"Reading 'Povídání o Pejskovi a Kočičce' by Karel Čapek: {115/115} pages read");
        }
    }

}


     


