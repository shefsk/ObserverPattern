using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private ISubject _weatherData;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            if (_temperature > 78.0 && _temperature < 85)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_temperature <= 78 && _humidity > 10.0)
            {
                Console.WriteLine("Watch for cooler, rainy weather.");
            }
            else if (_temperature > 85)
            {
                Console.WriteLine("Watch out!! The next few days are going to be scorchers! ");
            }

        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;

            Display();            
        }
    }
}
