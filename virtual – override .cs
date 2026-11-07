using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog: Gau gau");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat: Meo meo");
    }
}

class Program
{
    static void Main()
    {
        Animal a1 = new Dog();
        Animal a2 = new Cat();

        a1.Speak();
        a2.Speak();
    }
}