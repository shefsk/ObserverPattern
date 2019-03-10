using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation
{
    public interface IObserver
    {
        /// <summary>
        /// This is used to update all the registered Observers. The parameters are the state values
        /// the Observers get from the Subject when a weather measurement changes.
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void Update(float temp, float humidity, float pressure);

    }
}
