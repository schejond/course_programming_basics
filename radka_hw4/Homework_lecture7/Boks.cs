namespace Homework_lecture7
{
    public class Book
    {
        public string Title;

        public string Author;

        public int Pages;

        public int CurrentPage;


        public Book(string title, string author, int pages)
        {
            Title = title;
            
            Author = author;
            
            Pages = pages;
            
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

                Console.WriteLine($"You have read {CurrentPage} pages.");
            }
            else
            {
                Console.WriteLine("The number of pages must be positive.");
            }
        } 

   
    public void DisplayProgress()
        {
            Console.WriteLine("Reading " + Title + " by " + Author + " " + CurrentPage + "/" + Pages + " pages read.");
        }
    }

}


     


