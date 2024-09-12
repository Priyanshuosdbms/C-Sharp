using static Rectangle;

public class PartialClassExample10
{
    public static void MethodInPartialClass()
    {
        Rectangle rec = new Rectangle();
        rectDelegate  dele = new rectDelegate(rec.area);
        dele += rec.perimeter;

        dele.Invoke(5.4,4.5);
        Console.WriteLine();

        dele.Invoke(1.2,4.5);
    }
}

class Rectangle
{
    public delegate void rectDelegate(double height, double width);

    // Area
    public void area(double height, double width)
    {
        Console.WriteLine("Area is {0}",width*height);
    }

    public void perimeter(double height, double width)
    {
        Console.WriteLine("Perimeter is {0}",2*(width+height));
    }
}