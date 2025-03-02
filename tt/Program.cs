
public sealed class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Modyfikacja pierwsza.");
        Console.WriteLine("Modyfikacja druga.");
        Console.WriteLine("Modyfikacja trzecia.");
    }

    public int Average(int[] ints)
    {
        return (int)ints.Average();
    }
}