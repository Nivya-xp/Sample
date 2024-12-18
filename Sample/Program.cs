class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
    public void Display()
    {
        Console.WriteLine($"Name is {Name}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person p = new Person("Unknown");
        p.Display();
        Console.ReadKey();
    }
}