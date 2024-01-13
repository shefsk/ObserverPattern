using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern_WeatherStation.Subject
{
    public class WeatherData : IObservable
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();    
        }

        public float GetTemperature() { return _temperature; }
        public float GetHumidity() { return _humidity; }
        public float GetPressure() { return _pressure; }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
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
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
