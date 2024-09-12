using System.Dynamic;

public class PartialClassExample6
{
     public static void MethodInPartialClass()
     {
        // Static Binding Example
        /*
        Testdata dataclass = new Testdata();
        int add2 = dataclass.Add(23,23,34);
        int add1 = dataclass.Add(90,9);
        Console.WriteLine(add1 +" "+add2);
        */
        Drawing circle = new Circle();
        Console.WriteLine("Area of circle :"+circle.Area());
        Shape s;
        s = new Rect();
        s.draw();
        s = new Cir();
        s.draw();

        Drawable obj;
        obj = new Rectan();
        obj.draw();
        obj = new Circ();
        obj.draw();

        

     }

}

public class Testdata
{
    public int Add(int a , int b)
    {
        return a+b;
    }

    public int Add(int a, int b , int c)
    {
        return a+b+c;
    }
}

public class Drawing
{
    public virtual double Area()
    {
        return 0;
    }
}
public class Circle:Drawing
{
    public double Radius{get;set;}
    public Circle()
    {
        Radius = 5;
    }

    public override double Area()
    {
        return Math.Round((Math.PI)*Math.Pow(Radius,2),2);
    }
}
// Errors !!
/*
public class Square:Drawing
{
    public double Length(get;set;)
    public Square()
    {
        Length = 9;
    }
    public override double Area()
    {
        return Math.Pow(Length,2);
    }
}
public class Rectangle:Drawing
{
    public double Height(get;set;)
    public double Width(get;set;)
    public Rectangle()
    {
        Height = 9.9;
        Width = 4.5;
    }

}


// Sealed Template
public class X{
    public virtual void A()
    {

    }
}
    public Y:X
    {
        public override void A()
        {

        }
    }


public Y:x
{
    public sealed override void A()
    {

    }
}
*/
public abstract class Shape
{
    public abstract void draw();
}
public class Rect:Shape
{
    public override void draw()
    {
        Console.WriteLine("In side drawing rectangle");
    }

}
public class Cir:Shape
{
    public override void draw()
    {
        Console.WriteLine("Circle in side drawing circle");
    }
}

public interface Drawable
{
    void draw();
}

public class Rectan:Drawable
{
    public void draw()
    {
        Console.WriteLine("Inside Interface Rectangle");
    }
}
public class Circ:Drawable
{
    public void draw()
    {
        Console.WriteLine("Drawing circle...");
    }
}
