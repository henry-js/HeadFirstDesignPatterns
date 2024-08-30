using WeatherStation.Interfaces;

namespace WeatherStation.Displays;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float _currentPressure = 29.92f;
    private float _lastPressure;
    private WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.registerObserver(this);
    }
    public void display()
    {
        Write("Forecast: ");
        if (_currentPressure > _lastPressure)
        {
            WriteLine("Improving weather on the way!");
            return;
        }
        if (_currentPressure < _lastPressure)
        {
            WriteLine("Watch out for cooler, rainy weather");
            return;
        }
        WriteLine("More of the same");
    }

    public void update()
    {
        _lastPressure = _currentPressure;
        _currentPressure = _weatherData.getPressure();
        display();
    }
}
