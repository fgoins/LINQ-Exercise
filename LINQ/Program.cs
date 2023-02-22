namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> games = new List<string>() { "sk23", "mario", "pacman", "candy crush", "GTA" };

            games.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
