using System;
using System.Collections;
using System.Numerics;
using System.Text;

partial class PartialClassExampleEndSem
{
    public static void MethodInPartialClass()
    {
        Console.WriteLine("Hello From End Sem");
        String_ArrayList sa = new String_ArrayList();
        unchecked_checked s = new unchecked_checked();
        casting_implicit_explicit c = new casting_implicit_explicit();
        Enumeration e = new Enumeration();
        Boxing_Unboxing b = new Boxing_Unboxing();

    }
}

class String_ArrayList
{
    
    public String? a;
    public StringBuilder sb;
    public String_ArrayList()
    {
        
        Console.WriteLine("Enter a string :");
        a = Console.ReadLine();
        char[] ans = a.ToCharArray();
        Array.Sort(ans);
        Console.WriteLine(ans);
        Console.WriteLine(a.ToLower());
        Console.WriteLine(a.Substring(1,2));
        Console.WriteLine(a.Contains("a"));
        Console.WriteLine(a.Equals("Alpha"));
        Console.WriteLine(a.Count());
        Console.WriteLine(a.EndsWith("a"));
        Console.WriteLine(a.IndexOf("l"));
        Console.WriteLine("Comapre Method : "+a.CompareTo("Alp"));

        sb = new StringBuilder(a);
        Console.WriteLine(sb);
        Console.WriteLine(sb.Capacity);
        Console.WriteLine(sb.MaxCapacity);
        Console.WriteLine(sb.Length);
        Console.WriteLine(sb.Append("Randos"));
        Console.WriteLine(sb.AppendLine("Naya Line"));
        Console.WriteLine(sb.Remove(1, 5));
        Console.WriteLine(sb.Replace("n", "a"));
        Console.WriteLine(sb.Append("Hey !!"));
        Console.WriteLine();

        ArrayList list = new ArrayList();
        list.Add(123);
        list.Add(234);
        list.Add(1123);
        Console.WriteLine(list[0]);
        list.Sort();
        Console.WriteLine("ArrayList elements:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Dictionary<BigInteger , String> dictionary = new Dictionary<BigInteger, String>();
        dictionary.Add(123, "ab");
        dictionary.Add(1, "ab");
        dictionary.Add(23, "ac");
        dictionary.Add(2323, "eed");
        dictionary.Add(13, "e");
        Console.WriteLine(dictionary);
        Console.WriteLine("Dictionary elements:");
        foreach (KeyValuePair<BigInteger, String> kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        var sortedByValue = dictionary.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        // Print sorted Dictionary by values
        Console.WriteLine("\nSorted Dictionary by values:");
        foreach (var kvp in sortedByValue)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

    }
}
class unchecked_checked
{
    public unchecked_checked()
    {
        /*
        The checked and unchecked statements specify the overflow-checking context for integral-type arithmetic operations and conversions. 
        When integer arithmetic overflow occurs, the overflow-checking context defines what happens. In a checked context, a System.OverflowException is thrown; 
        if overflow happens in a constant expression, a compile-time error occurs. In an unchecked context, the operation result is truncated by 
        discarding any high-order bits that don't fit in the destination type.
        */
        uint a = uint.MaxValue;

        unchecked
        {
            Console.WriteLine(a + 3);  // output: 2
        }

        try
        {
            checked
            {
                Console.WriteLine(a + 3);
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
        }

        double aa = double.MaxValue;

        int b = unchecked((int)aa);
        Console.WriteLine(b);  // output: -2147483648

        try
        {
            b = checked((int)aa);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
        }
    }
}

class casting_implicit_explicit
{
    public casting_implicit_explicit()
    {
        /*
        Implicit casting happens automatically when the conversion is safe and does not require extra code. 
        Implicit casting works when the target type is larger than the source type. For example, an int can be implicitly cast to a long, float, or double.
        
        In this example, the integer variable num1 is implicitly cast to a long when it is assigned to the num2 variable.
        */
        int num1 = 10;
        long num2 = num1;
        Console.WriteLine(num1);
        Console.WriteLine(num2);

        /*
        Explicit Casting in C#
        Explicit casting works when the target type is smaller than the source type or when converting between incompatible types. 
        Explicit casting requires the programmer to define the conversion using the appropriate cast operator explicitly. 
        The syntax for explicit casting encloses the expression to be cast within parentheses, followed by the target type in square brackets.

        In this example, we are casting the double value num1 to an integer using the (int) cast operator. The resulting value is 10, 
        the integer part of the double number.
        */

        double num3 = 10.5;
        int num4 = (int)num1;
        Console.WriteLine(num3);
        Console.WriteLine(num4);


    }
}

class Enumeration
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public Enumeration()
    {
        Season a = Season.Autumn;
        Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

        var b = (Season)1;
        Console.WriteLine(b);  // output: Summer

        var c = (Season)4;
        Console.WriteLine(c);  // output: 4

    }

}

class Boxing_Unboxing
{
    public Boxing_Unboxing()
    {
        Boxing();
        Unboxing();
    }
    public void Boxing()
    {
        int i = 123;

        // Boxing copies the value of i into object o.
        object o = i;

        // Change the value of i.
        i = 456;

        // The change in i doesn't affect the value stored in o.
        System.Console.WriteLine("The value-type value = {0}", i);
        System.Console.WriteLine("The object-type value = {0}", o);

    }
    public void Unboxing()
    {
        int i = 123;
        object o = i;  // implicit boxing

        try
        {
            int j = (short)o;  // attempt to unbox

            System.Console.WriteLine("Unboxing OK.");
        }
        catch (System.InvalidCastException e)
        {
            System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
        }
    }
}

