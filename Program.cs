// List Example
/*
List<double> grades = new List<double>() {12.0,13.1,9.0 };
grades.Add(14.5);

foreach (var grade in grades)
{
    Console.WriteLine(grade);
};

Console.WriteLine("----------");
Console.WriteLine(grades[0]);
*/

//Find the maximum number from list

/*List<int> number = new List<int> { 11, 90, 45, 60, 14 };

int max = number[0];

foreach (int i in number)
{
    if (i > max)
    { max = i; }
}

Console.WriteLine("The maximum number in the list is :" + max);
*/

//LINQ

List<Car> Cars = new List<Car>();
Car car1 = new Car("Volvo", "V60", 2020, 100);
//Car car2 = new Car("")
Cars.Add(car1);
Cars.Add(new Car("Nissan", "Quasqui", 2022, 120));

List<Car> extraCars = new List<Car>
{
    new Car("opel","Hero", 2023, 140),
    new Car("Volvo","V40", 2023, 110)
};

Cars.AddRange(extraCars);
Cars.AddRange(new List<Car> 
{
    new Car("Mercedes","XL", 2020, 140),
    new Car("Fiat","Hey", 2000, 170)
});

int HighestSpeed = Cars.Max(Car => Car.Speed);

Console.WriteLine("The highest speed is : " + HighestSpeed);

double average = Cars.Average(Car => Car.Speed);

int sumofallspeeds = Cars.Sum(Car => Car.Speed);
int CountCars = Cars.Count();
int CountVolvo = Cars.Where(Car => Car.Brand == "Volvo").Count();

Console.WriteLine("My Cars List (Unsorted)");
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
foreach (Car car in Cars)
{
    Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
}

//Sorted List By Brand
Console.WriteLine("-------------------------------");
Console.WriteLine("My Cars List (Sorted by Brand)");
List<Car> SortedCars = Cars.OrderBy(Car => Car.Brand).ToList();
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
foreach (Car car in SortedCars)
{
    Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
}

//Show Cars from 2000 and 2020
//Do it by using where clause
Console.WriteLine("-------------------------------");
Console.WriteLine("Find Cars");
List<Car> filteredCars = Cars.Where(Car => Car.Year >= 2000 && Car.Year <= 2020).ToList();
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
foreach (Car car in filteredCars)
{
    Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
}

class Car
{
    public Car(string brand, string model, int year, int speed)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Speed = speed;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Speed { get; set; }
}
