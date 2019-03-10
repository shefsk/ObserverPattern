using ObserverPattern_WeatherStation.Observers;
using ObserverPattern_WeatherStation.Subject;
using System;

/// <summary>
/// The Observer Pattern defines one-to-many dependency between objects so that when one
/// object changes state, all of its dependents are notified and updated automatically.
/// </summary>
namespace ObserverPattern
{
    public class WeatherStation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station");
            Console.WriteLine();

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine();
            weatherData.SetMeasurements(87, 70, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.WriteLine();
        }
    }
}
