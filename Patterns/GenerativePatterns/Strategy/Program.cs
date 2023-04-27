using Strategy.Behavioral.Comfort;
using Strategy.Cars;

class Program
{
    static void Main(string[] args)
    {
        List<BaseCar> cars = new List<BaseCar>();
        cars.Add(new SportCar());
        cars.Add(new Truck());
        cars.Add(new MegaCar());

        foreach (var car in cars)
        {
            car.Display();
            car.Ride();
            car.RidesFast();
            car.HavePower();
            car.HaveComfort();
            Console.WriteLine();
        }

        SportCar sportCar = new SportCar();
        sportCar.Display();
        sportCar.Ride();
        sportCar.RidesFast();
        sportCar.HavePower();
        sportCar.HaveComfort();

        Console.WriteLine();
        Console.WriteLine("Sportcar after update:");
        sportCar.SetComfortable(new ComfortableAndMore());
        sportCar.HaveComfort();
    }
}