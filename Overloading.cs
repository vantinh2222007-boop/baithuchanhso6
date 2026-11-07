using System;

class Calculator
{
    // Cộng 2 số nguyên
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Cộng 2 số thực
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Cộng 3 số nguyên
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Tong 2 so nguyen: " + calc.Add(5, 3));
        Console.WriteLine("Tong 2 so thuc: " + calc.Add(2.5, 3.5));
        Console.WriteLine("Tong 3 so nguyen: " + calc.Add(1, 2, 3));
    }
}