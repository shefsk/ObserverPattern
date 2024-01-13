using ObserverPattern_WeatherStation.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation.Observers
{
    public class CurrentConditionsDisplay : DisplayBase
    {
        public CurrentConditionsDisplay(IObservable weatherData) : base(weatherData) {}
        public override void Display() => 
            Console.WriteLine("Current conditions : " + _weatherData.GetTemperature() + "F degrees and  " + _weatherData.GetHumidity() + "% humidity.");
    }
}
