using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking");
    }
}

// Sử dụng override
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog: Gau gau");
    }
}

// Sử dụng new
class Cat : Animal
{
    public new void Speak()
    {
        Console.WriteLine("Cat: Meo meo");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== OVERRIDE ===");

        Animal a1 = new Dog();
        Dog d = new Dog();

        a1.Speak();
        d.Speak();

        Console.WriteLine("\n=== NEW ===");

        Animal a2 = new Cat();
        Cat c = new Cat();

        a2.Speak();
        c.Speak();
    }
}