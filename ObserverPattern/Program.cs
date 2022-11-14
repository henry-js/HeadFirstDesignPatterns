using WeatherStation;
using WeatherStation.Displays;

WeatherData weatherData = new();

CurrentConditionsDisplay currentDisplay = new(weatherData);
ForecastDisplay forecastDisplay = new(weatherData);
HeatIndexDisplay heatDisplay = new(weatherData);

weatherData.setMeasurements(80, 65, 30.4f);
weatherData.setMeasurements(82, 70, 29.2f);
weatherData.setMeasurements(78, 90, 29.2f);
