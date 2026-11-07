
using System;

// Lớp cha
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Ve hinh hoc");
    }
}

// Lớp Circle
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Ve hinh tron");
    }
}

// Lớp Rectangle
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Ve hinh chu nhat");
    }
}

// Lớp Triangle
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Ve hinh tam giac");
    }
}

class Program
{
    static void Main()
    {
        // Tao mang Shape chua nhieu loai hinh
        Shape[] shapes = new Shape[]
        {
            new Circle(),
            new Rectangle(),
            new Triangle(),
            new Circle()
        };

        // Duyet mang va goi Draw()
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
