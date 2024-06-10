namespace LibraryApp;

public class Book (string title, string author, int year)
{
  public string Title { get; set; } = title;
  public string Author { get; set; } = author;
  public int Year { get; set; } = year;
  public bool IsCheckedOut { get; set; } = false;

  public override string ToString()
  {
      return $"Title: {Title}, Author: {Author}, Year: {Year}, Available: {(IsCheckedOut ? "No" : "Yes")}";
  }
}