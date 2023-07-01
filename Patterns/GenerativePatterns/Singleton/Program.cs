Singleton singleton1 = Singleton.GetInstance(); 
Singleton singleton2 = Singleton.GetInstance();

if(singleton1 == singleton2)
{
    Console.WriteLine("Singleton works!");
}
else
{
    Console.WriteLine("Singleton doesn't work");
}