using IteratorPattern;

var waitress = new Waitress(new PancakeHouseMenu(), new DinerMenu(), new CafeMenu());
waitress.PrintMenu();

Console.ReadLine();
