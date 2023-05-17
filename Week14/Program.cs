Dog goodBoy = new Dog("Good Boy");
Console.WriteLine($"Name:{goodBoy.Name}; level of happinnes:{goodBoy.LevelOfHappines}");
while (goodBoy.LevelOfHappines < 5)
{
    goodBoy.Bark();
}
goodBoy.Wag();

class Dog
{
    public string Name;
    public int LevelOfHappines;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappines = 0;
        Console.WriteLine($"{Name} is your friend now");
    }
    public void Bark()
    {
        LevelOfHappines++;
        Console.WriteLine("woof-woof");


    }
    public void Wag()
    {
        Console.WriteLine($"{Name} stars wagging its tail.");
        Console.WriteLine("Whoosh-whoosh");


    }



}