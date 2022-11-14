using DuckBehaviour.Ducks;
using Starbuzz.Beverages;
using Starbuzz.Condiments;
using WeatherStation;
using WeatherStation.Displays;

// //Duck Behaviours

// var line = """
// ----------------------------
// """;

// Console.WriteLine(line);

// Duck mallard = new MallardDuck();
// mallard.PerformQuack();
// mallard.PerformFly();
// mallard.Display();

// Console.WriteLine(line);

// Duck model = new ModelDuck();
// model.PerformFly();
// model.SetFlyBehaviour(new FlyRocketPowered());
// model.PerformFly();

// Console.WriteLine(line);

// // Observer Pattern

// WeatherData weatherData = new();

// CurrentConditionsDisplay currentDisplay = new(weatherData);
// ForecastDisplay forecastDisplay = new(weatherData);
// HeatIndexDisplay heatDisplay = new(weatherData);

// weatherData.setMeasurements(80, 65, 30.4f);
// weatherData.setMeasurements(82, 70, 29.2f);
// weatherData.setMeasurements(78, 90, 29.2f);

// Decorator Pattern

ForegroundColor = ConsoleColor.Blue;
Beverage beverage = new DarkRoast();
WriteLine(beverage);
beverage = new Mocha(beverage);
WriteLine(beverage);
beverage = new Soy(beverage);
WriteLine(beverage);
beverage = new Whip(beverage);
WriteLine(beverage);
