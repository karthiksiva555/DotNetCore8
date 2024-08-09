namespace RazorViews.Models;

public class CityWeather(string cityCode, string cityName, DateTime dateAndTime, int temparature)
{
    public string CityCode { get; set; } = cityCode;

    public string CityName { get; set; } = cityName;

    public DateTime DateAndTime { get; set; } = dateAndTime;

    public int Temparature { get; set; } = temparature;
}