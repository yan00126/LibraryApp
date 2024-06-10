namespace LibraryApp;

public class Library (List<Book> books)
{
  private List<Book> books = books;

  private Book? FindBookByTitle (string title)
  {
    return books.FirstOrDefault(book => book.Title.ToLower() == title.ToLower());
  }

  public void ListBooks () 
  {
    if (books.Count == 0) {
      Console.WriteLine("\nNo books found\n");
      return;
    }

    Console.WriteLine("\n## BOOKS ##");
    foreach (var book in books) 
    {
      Console.WriteLine(book);
    }

    Console.WriteLine();
  }

  public void AddBook (Book book)
  {
    if (books.Exists(b => b.Title == book.Title))
    {
      throw new Exception("This book is already in the library.");
    }

    books.Add(book);
  }
    
  public bool CheckOutBook (string title) 
  {
    var book = FindBookByTitle(title);
    
    if (book == null) 
    {
      throw new NullReferenceException("No book with that title was found");
    }

    if (book.IsCheckedOut)
    {
      throw new Exception("The book is already checked out.");
    }

    book.IsCheckedOut = true;
    return true;
  }

  public bool ReturnBook (string title)
  {
    var book = FindBookByTitle(title);
    
    if (book == null) 
    {
      throw new NullReferenceException("No book with that title was found");
    }

    if (!book.IsCheckedOut)
    {
      throw new Exception("The book is not checked out.");
    }

    book.IsCheckedOut = false;
    return true;
  }
}