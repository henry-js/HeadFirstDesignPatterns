using WeatherStation.Interfaces;

namespace WeatherStation.Displays;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.registerObserver(this);
    }
    public void display()
    {

        switch (_humidity)
        {
            case <= 65.0f:
                WriteLine("Forecast: Improving weather on the way!");
                break;
            case >= 90f:
                WriteLine("Forecast: More of the same");
                break;
            default:
                WriteLine("Watch of for cooler, rainy weather");
                break;
        }
    }

    public void update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        display();
    }
}
