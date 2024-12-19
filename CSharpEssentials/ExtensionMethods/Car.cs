namespace CSharpEssentials.ExtensionMethods;

public class Car (int year, string make, string model)
{
    private int Year { get; set; } = year;

    private string Make { get; set; } =make;

    private string Model { get; set; } = model;

    public void Drive()
    {
        Console.WriteLine($"Driving car: {this}");
    }

    public override string ToString()
    {
        return $"{Make} {Model} - {Year}";
    }
}