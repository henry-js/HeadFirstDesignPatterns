using IteratorPattern;

var waitress = new Waitress(new PancakeHouseMenu(), new DinerMenu());
waitress.PrintMenu();
