using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation
{
    public interface ISubject
    {
        /// <summary>
        /// Registers an observer
        /// </summary>
        /// <param name="o"></param>
        void RegisterObserver(IObserver o);

        /// <summary>
        /// Removes an observer so it is no longer notified of any change.
        /// </summary>
        /// <param name="o"></param>
        void RemoveObserver(IObserver o);

        /// <summary>
        /// This is called to notify all observers when the subject's state has changed
        /// </summary>
        void NotifyObservers();
    }
}
