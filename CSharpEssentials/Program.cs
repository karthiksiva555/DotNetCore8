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
channel2.PublishVideo("Friendly Dogs","https://youtube.com/id/1");
// -------------------------------------------------------------