using ObserverPattern_WeatherStation.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation.Observers
{
    public class DisplayBase : IObserver, IDisplayElement
    {
        protected IObservable _weatherData;

        public DisplayBase(IObservable weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public virtual void Display()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            Display();
        }
    }
}
