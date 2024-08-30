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
    public void update()

    {
        _temperature = _weatherData.getTemperature();
        _humidity = _weatherData.getHumidity();
        display();
    }
    public void display()
    {
        WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }

}
