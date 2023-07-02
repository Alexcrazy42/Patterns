using Prototype;

Person p1 = new Person()
{
    Id = new IdInfo(1),
    Name = "Alex"
};

Person p2 = p1.ShallowCopy();
Person p3 = p1.DeepCopy();

DisplayPersonValues(p1, "p1");
DisplayPersonValues(p2, "p2");
DisplayPersonValues(p3, "p3");

Console.WriteLine("--------------------------");

p1.Id.IdNumber = 2;
p1.Name = "Alex Copy";

DisplayPersonValues(p1, "p1 after changes");
DisplayPersonValues(p2, "p2 after changes");
DisplayPersonValues(p3, "p3 after changes");

void DisplayPersonValues(Person p, string label)
{
    Console.WriteLine($"{label}:");
    Console.WriteLine($"Id: {p.Id.IdNumber}");
    Console.WriteLine($"Name: {p.Name}");
}

