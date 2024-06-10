internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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
}