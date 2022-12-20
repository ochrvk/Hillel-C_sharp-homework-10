using Homework_10;

class Program
{
    static Car findCar(Car[] cars)
    {
        Console.WriteLine("______Find car by year____________");

        Car car = new Car();

        for (int i = 0; i < cars.Length; i++)
        {
            if (i == 0)
            {
                car.year = cars[i].year;
                car.name = cars[i].name;
            }
            else if (cars[i].year > car.year)
            {
                car.year = cars[i].year;
                car.name = cars[i].name;
            }
        }

        return car;
    }

    static void inputCar(Car[] cars, int arraySize)
    {
        Console.WriteLine("______Input Car____________");

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car();

            Console.Write($"Enter {i + 1} car name: ");
            cars[i].name = Console.ReadLine();

            Console.Write($"Enter {i + 1} car year: ");
            cars[i].year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

    }

    static void outputCar(Car[] cars)
    {
        Console.WriteLine("_________Output Car________");

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"[{i + 1}] Car: ");
            Console.WriteLine(cars[i] + "\n");
        }

        Console.WriteLine("");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());

        Car[] cars = new Car[arraySize];

        inputCar(cars, arraySize);
        outputCar(cars);
        Console.WriteLine(findCar(cars));
    }
}