namespace CSharpEssentials.ExtensionMethods;

public static class CarExtensions
{
    public static void Reverse(this Car car)
    {
        Console.WriteLine($"Reverse Car: {car}");
    }
}