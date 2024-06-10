namespace LibraryApp;

public class Helper
{
  public static List<Book> GetAvailableBooks ()
  {
    return [
      new Book("Pride and Prejudice", "Jane Austen", 1813),
      new Book("Moby-Dick", "Herman Melville", 1851),
      new Book("To Kill a Mockingbird", "Harper Lee", 1960),
      new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925),
      new Book("1984", "George Orwell", 1949),
      new Book("Jane Eyre", "Charlotte Brontë", 1847),
      new Book("The Catcher in the Rye", "J.D. Salinger", 1951),
      new Book("The Adventures of Huckleberry Finn", "Mark Twain", 1884),
      new Book("War and Peace", "Leo Tolstoy", 1869),
      new Book("Don Quixote", "Miguel de Cervantes", 1605)
    ];
  }
}
