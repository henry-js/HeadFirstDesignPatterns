using WeatherStation.Interfaces;
using static System.Console;

namespace WeatherStation.Displays;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private WeatherData _weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.registerObserver(this);
    }
    public void update(float temp, float humidity, float pressure)

    {
        _temperature = temp;
        _humidity = humidity;
        display();
    }
    public void display()
    {
        WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }

}
