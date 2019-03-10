using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern_WeatherStation.Subject
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();    
        }
        
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }

        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (_observers != null && _observers.Count() > 0)
            {
                _observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }
}
