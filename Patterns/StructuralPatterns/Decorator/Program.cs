using Decorator.Cars;
using Decorator.Decorators;

Audi simpleAudi = new Audi();

BaseCar audiWithAutopilotAndBedInCarAndAutoParking = new AutoParking(new BedInCar(new Autopilot(simpleAudi)));

Console.WriteLine(audiWithAutopilotAndBedInCarAndAutoParking.GetDescription());
Console.WriteLine(audiWithAutopilotAndBedInCarAndAutoParking.GetCost());

Console.WriteLine("---------------------------");

Volvo simpleVolvo = new Volvo();
BaseCar volvoWithAutoParking = new AutoParking(simpleVolvo);

Console.WriteLine(volvoWithAutoParking.GetDescription());
Console.WriteLine(volvoWithAutoParking.GetCost());

Console.WriteLine("---------------------------");

Tesla simpleTesla = new Tesla();
BaseCar teslaWithAutoPilotAndBedInCar = new BedInCar(new AutoParking(simpleTesla));

Console.WriteLine(teslaWithAutoPilotAndBedInCar.GetDescription());
Console.WriteLine(teslaWithAutoPilotAndBedInCar.GetCost());