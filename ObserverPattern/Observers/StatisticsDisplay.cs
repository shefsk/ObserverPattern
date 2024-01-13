using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation.Observers
{
    public class StatisticsDisplay : DisplayBase
    {
        public StatisticsDisplay(IObservable weatherData) : base(weatherData) { }

        public override void Display()
        {
            Console.WriteLine(String.Format("Avg/Min/Max temperature = {0}/{1}/{2}", _weatherData.GetTemperature() - 1, _weatherData.GetTemperature(), _weatherData.GetTemperature() + 1));
        }
    }
}
