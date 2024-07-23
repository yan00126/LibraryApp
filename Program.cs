using LibraryApp;

internal class Program
{
    private static void Main(string[] args)
    {
      var library = new Library(Helper.GetAvailableBooks());
      while (true)
      {
        Console.WriteLine("Library Menu: \n1. View All Books. \n2. Add a Book: \n3. Check Out a Book. \n4. Return a Book. \n5. Exit");

        string choice = GetResponse("Enter your choice: ");

        switch (choice)
        {
          case "1":
            // view books
            ViewBooks(library);
            break;
          case "2":
            // add a book
            AddBook(library);
            break;
          case "3":
            // checkout book
            CheckOutBook(library);
            break;
          case "4":
            //return book
            ReturnBook(library);
            break;
          case "5":
            Console.WriteLine("Thanks, Goodbye.");
            return;
            
          default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }
      }
    }

    static string GetResponse (string request) 
    {
      string? response = null;

      while (string.IsNullOrWhiteSpace(response))
      {
        Console.Write(request);
        response = Console.ReadLine();
      }

      return response;
    }

    static void ViewBooks (Library library)
    {
      library.ListBooks();
    }

    static void AddBook (Library library)
    {
      string title = GetResponse("Enter title: ");
      string author = GetResponse("Enter Author: ");

      bool isValid = false;
      int year = 0;

      while (!isValid)
      {
        isValid = int.TryParse(GetResponse("Enter year: "), out year);

      }

      var book = new Book(title, author, year);

      try
      {
        library.AddBook(book);
        Console.WriteLine("Book added successfully.");

      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

    }

    static void CheckOutBook (Library library)
    {
      string title = GetResponse("Enter title to check out: ");

      try
      {

        library.CheckOutBook(title);
        Console.WriteLine($"{title} has been checked out.");


      }
      catch (NullReferenceException e)
      {
        //book not found
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {
        // book is checked out
        Console.WriteLine(e.Message);
      }


    }


    static void ReturnBook(Library library)
    {
      string title = GetResponse("Enter title to return: ");

      try
      {

        library.ReturnBook(title);
        Console.WriteLine($"{title} has been returned.");


      }
      catch (NullReferenceException e)
      {
        //book not found
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {
        // book is not checked out
        Console.WriteLine(e.Message);
      }



    }
}