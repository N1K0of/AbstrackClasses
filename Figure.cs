using System;

abstract class Figure
{
    private string name;

    public Figure(string name)
    {
        this.name = name;
    }

    public string Name
    { 
        get { return name;}
        set {name = value;}
    }

    public abstract double Area();

    public virtual void Print()
    {
        
    }
}
