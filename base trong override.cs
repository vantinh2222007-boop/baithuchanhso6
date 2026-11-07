using System;

class Person
{
    public virtual void Introduce()
    {
        Console.WriteLine("I am a person.");
    }
}

class Student : Person
{
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("I am also a student.");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Introduce();
    }
}