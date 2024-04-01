namespace HomeSolution.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("oRxan  ", "GurBANLI", "132");
            Console.WriteLine(user.Name);
        }
    }
}