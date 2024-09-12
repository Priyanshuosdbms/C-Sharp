using System;
public class PartialClassExampleEndSemUnitTwo
{
    public static void MethodInPartialClass()
    {
        /*
        OperatorOverloading op1 = new OperatorOverloading();
        OperatorOverloading op2 = new OperatorOverloading();
        OperatorOverloading op3 = new OperatorOverloading();
        op3.display();
        op3 = op1 + op2;
        op3.display();

        OperatorOverloading op4 = new OperatorOverloading();
        op4 = -op2;
        op4.display();
        */
        // A_interfacer ai = new A_interfacer();
        ExceptionHandling eh = new ExceptionHandling();
    }
}

class OperatorOverloading
{
    int a, b;
    public OperatorOverloading()
    {
        Console.WriteLine("Enter a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b:");
        b = Convert.ToInt32(Console.ReadLine());
    }
    public OperatorOverloading(int n)
    {
        a = b = n;
    }

    public static OperatorOverloading operator +(OperatorOverloading c1, OperatorOverloading c2)
    {
        OperatorOverloading c3 = new OperatorOverloading(0);
        c3.a = c1.a + c2.b;
        c3.b = c1.b + c2.a;
        return c3;
    }
    public static OperatorOverloading operator -(OperatorOverloading c1)
    {
        OperatorOverloading c3 = new OperatorOverloading(0);
        c3.a = -c1.a;
        c3.b = -c1.b;
        return c3;

    }
    public void display()
    {
        Console.WriteLine("A is" + a);
        Console.WriteLine("B is" + b);
    }
}

interface Polish
{
    public void add(int a, int b);
    public void sub(int a, int b);
}

class A_interfacer : Polish
{
    int a, b;

    public A_interfacer()
    {
        Console.WriteLine("Enter the values for a and b:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        sub(a, b);
        add(a, b);
    }

    public void sub(int a, int b)
    {
        Console.WriteLine($"Subtraction result: {a - b}");
    }

    public void add(int a, int b)
    {
        Console.WriteLine($"Addition result: {a + b}");
    }
}

class ExceptionHandling
{
    int a, b;
    public ExceptionHandling()
    {        
        Console.WriteLine("Enter the values for a and b:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (b == 0)
            {
                throw new DivisionByZeroException();
            }

            Console.WriteLine($"Divison result: {a / b}");
        }
        catch (Exception ex)
        {
            //ex.Message = "Divsion by Zero failed";
            Console.WriteLine($"Exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally!");
        }
    }
}
class DivisionByZeroException : Exception
{
    public DivisionByZeroException() : base("Division by Zero failed")
    {
    }
}