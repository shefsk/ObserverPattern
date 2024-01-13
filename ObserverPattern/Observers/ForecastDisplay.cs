using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation.Observers
{
    public class ForecastDisplay : DisplayBase
    {
        public ForecastDisplay(IObservable weatherData) : base(weatherData) { }

        public override void Display()
        {
            if (_weatherData.GetTemperature() > 78.0 && _weatherData.GetTemperature() < 85)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_weatherData.GetTemperature() <= 78 && _weatherData.GetHumidity() > 10.0)
            {
                Console.WriteLine("Watch for cooler, rainy weather.");
            }
            else if (_weatherData.GetTemperature() > 85)
            {
                Console.WriteLine("Watch out!! The next few days are going to be scorchers! ");
            }

        }
    }
}
