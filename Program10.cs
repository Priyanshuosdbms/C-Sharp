using System.Numerics;

public class PartialClassExample9
{
    public static void MethodInPartialClass()
    {
        Complex c1 = new Complex(10, 20);
        c1.show();
        Complex c2 = new Complex();
        c2.show();
        c2 = -c1;// Function call
        // Operator '-' cannot be applied to operand of type 'Complex'
        // Operator 'operator' cannot be applied to operand of type 'type'
        // _ = -c1;
        //Discards are placeholder variables that are intentionally unused in application code. 
        //Discards are equivalent to unassigned variables; they don't have a value. 
        //A discard communicates intent to the compiler and others that read your code: 
        //You intended to ignore the result of an expression. 
        c2.show();
        c1.show();
        Complex c3 = new Complex();
        c3 = c1 + c2;
        c3.show();

    }
}

class Complex
{

    private int x;
    private int y;
    public Complex() { }

    public Complex(int i, int j)
    {
        x = i;
        y = j;
    }

    public void show()
    {
        Console.WriteLine("{0}i + {1}j", x, y);
    }

    public static Complex operator -(Complex c)// c1 is an object as an argument, - is func name , retval COmplex type
    {
        // call by value hence seperate memory
        Complex temp = new Complex();
        temp.x = -c.x;
        temp.y = -c.y;
        return temp;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.x = c1.x+c2.x;
        temp.y = c1.y+c2.y;
        return temp;
    }

}
/*


In C#, your variables are never altered by callees without you explicitly passing them as references (e.g. int.TryParse(s, out i) where you explicitly specify the out keyword). This feature would make things complicated by allowing the overloaded operator alter the contents of the operands without your explicit permission.

For instance,

public static MyStruct operator + (ref MyStruct left, ref MyStruct right) {
    left = new MyStruct(); // !!!!
    return something(left, right);
}
When you reference such an operator in C#:

MyStruct x = new MyStruct();
MyStruct y = new MyStruct();
MyStruct z = x + y; // in C#, you never expect `x` to be changed.



*/