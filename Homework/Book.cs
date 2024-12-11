namespace Homework
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _pages;
        private int _currentpages;

        // konstruktor
        internal Book(string title, string author, int pages)
        {
            _title = title;
            _author = author;
            _pages = pages;
            _currentpages = 0;
        }

        // metoda
        public int Read(int readPages)
        {
            if (_currentpages + readPages <= _pages)
            {
                _currentpages = _currentpages + readPages;
                return _currentpages;
            }
            else
            {
                _currentpages = _pages;
                return _pages;
            }
        }

        public void DisplayProgress()
        {
            Console.WriteLine("Reading " + _title + " by " + _author + ": " + _currentpages + "/" + _pages + "pages read.");
        }
    }
}
