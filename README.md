# Design Patterns - Observer
C# Implementation of the Observer Pattern from the Book  Head First Designs 

This solution is an implementation of the Observer Pattern using the Weather Station example from the book Head First Design Patterns.

The Observer Pattern defines a one-to-many relationship between objects, such that when one object changes state, all of its dependents 
are notified and updated automatically.

Here the ISubject interface is the Subject and the WeatherData class is the Concrete Subject.
The IObserver interface is the Observer and the Display classes (CurrentConditionsDisplay, ForecastDisplay, etc.) are Concrete Observers.

The Observers use the Subject Interface to register and remove themselves from being observers. 
The COncrete Subject implements the Subject interface and also handles notifying the Observers of any state changes.

Each Concrete Observer registers with a Concrete Subject to receive updates. 
