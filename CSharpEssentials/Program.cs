using System.Runtime.CompilerServices;
using CSharpEssentials.AnonymousMethods;
using CSharpEssentials.ExtensionMethods;

// -------------------------------------------------------------
// Extension Methods
// -------------------------------------------------------------
Car audi = new(2020, "Audi", "A4");
audi.Drive();
// Reverse is an extension method not part of Car class
audi.Reverse();

IEnumerable<Car?> cars = [ audi, null];
var nonNullCars = cars.WhereNotNull();
Console.WriteLine(string.Join(';', nonNullCars));

// -------------------------------------------------------------

// -------------------------------------------------------------
// Anonymous Methods
// -------------------------------------------------------------
YouTubeChannel channel1 = new("Tech Guru", "123456");
Subscriber subscriber1 = new("Karthik");
channel1.NewVideoPublishedEvent += subscriber1.NewVideoPublished;
channel1.NewVideoPublishedEvent += delegate (string videoName, string videoUrl)
{
    Console.WriteLine($"NewVideoPublishedEvent called for {videoName} at {videoUrl}");
};
channel1.PublishVideo("10 Best Coding Books", "https://youtube.com/id/1");

// -------------------------------------------------------------

// -------------------------------------------------------------
// Lambda Expression
// -------------------------------------------------------------
YouTubeChannel channel2 = new("Tech Guru", "123456");
Subscriber subscriber2 = new("Karthik");
channel2.NewVideoPublishedEvent += subscriber2.NewVideoPublished;
channel2.NewVideoPublishedEvent += (videoName, videoUrl) =>
{
    Console.WriteLine($"NewVideoPublishedEvent called for {videoName} at {videoUrl}");
};
channel2.NewVideoPublishedEvent += (videoName, videoUrl) => Console.WriteLine($"{videoName} has been published at {videoUrl}");

channel2.PublishVideo("Friendly Dogs","https://youtube.com/id/1");

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(5,6));

// -------------------------------------------------------------

// -------------------------------------------------------------
// Top Level Statements
// -------------------------------------------------------------

// All the statements in this file are top-level because they are not written within main() method
// Only one file in the project can contain top-level statements; in this case Program.cs
const int a = 5;
var b = a + 10;
Console.WriteLine(a);

// args are available to the top-level statements by default
if (args.Length > 0)
{
    Console.WriteLine($"Arguments: {args[0]}");
}
// -------------------------------------------------------------

// Not allowed, because Program class is reserved for auto-generated main method
// class Program
// {
//     
// }