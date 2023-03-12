using WeatherStation.Interfaces;

namespace WeatherStation;

public class WeatherData : ISubject
{
    private List<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherData()
    {
        _observers = new();
    }
    public void notifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.update();
        }
    }

    public void registerObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void removeObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void measurementsChanged() => notifyObservers();

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        measurementsChanged();
    }

    internal float getTemperature()
    {
        return _temperature;
    }

    internal float getHumidity()
    {
        return _humidity;
    }

    internal float getPressure()
    {
        return _pressure;
    }
}
