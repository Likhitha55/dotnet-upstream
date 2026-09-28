namespace MyApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from Upstream Pipeline!");
        Console.WriteLine($"Build Time: {DateTime.UtcNow}");
    }
}
