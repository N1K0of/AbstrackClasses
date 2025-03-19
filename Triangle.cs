using System;

class Triangle : Figure
{
    private double a, b, c;

    public Triangle(string name,double a, double b, double c) : base(name)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Area()
    {
        double p = (a + b + c) / 2;
        return p;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
        Console.WriteLine($"Площадь треугольника = {Area()}");
    }
}
