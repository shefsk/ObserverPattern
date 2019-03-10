using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherStation
{
    public interface IDisplayElement
    {
        /// <summary>
        /// Displays the measured values
        /// </summary>
        void Display();
    }
}
