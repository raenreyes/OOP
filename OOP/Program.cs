namespace OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Book newBook = new Book();
            newBook.Title = "The Hunger Games";
            newBook.Pages = 456;
            newBook.Details();
          

        }
    }
}