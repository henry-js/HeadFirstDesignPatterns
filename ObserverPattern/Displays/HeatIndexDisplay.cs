using WeatherStation;
using WeatherStation.Interfaces;

public class HeatIndexDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private float _heatIndex;

    private WeatherData _weatherData;

    public HeatIndexDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.registerObserver(this);
    }

    public void update()
    {
        _temperature = _weatherData.getTemperature();
        _humidity = _weatherData.getHumidity();
        _heatIndex = computeHeatIndex(_temperature, _humidity);
        display();
    }
    public void display()
    {
        WriteLine($"Heat index is {_heatIndex}");
    }

    private float computeHeatIndex(float t, float rh)
    {
        float index = (float)(16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
            (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
            (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
            (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
            (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
            (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
            0.000000000843296 * (t * t * rh * rh * rh) -
            (0.0000000000481975 * (t * t * t * rh * rh * rh)));
        return index;
    }

}
