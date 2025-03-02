
public sealed class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Modyfikacja pierwsza.");
        Console.WriteLine("Modyfikacja druga.");
        Console.WriteLine("Modyfikacja trzecia.");

        int[] numbers = [12, 12, 23, 232];

        Console.WriteLine(Average(numbers));
    }

    public static int Average(int[] ints)
    {
        return (int)ints.Average();
    }
}