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
        Animal[] animals = { new Dog(), new Cat(), new Animal() };

        foreach (Animal animal in animals)
        {
            animal.Speak();
        }
    }
}