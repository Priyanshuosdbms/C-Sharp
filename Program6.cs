/*
create a base class: with private,public and protected property
	create derived class 1 which inherits base class property
	create dervived class2 which inherits base class and derived  class property
*/

using System;

public class PartialClassExample5
{
    public static void MethodInPartialClass()
    {
        Console.WriteLine("Inside implementation_public PartialClassExample\n");
        derived_class_2 obj = new derived_class_2();
        obj.all_work();
        
    }
}
class Base_class
{
    public
    int x;
    private
    int y;

    protected
    int z;

}

class derived_class_1 : Base_class // use private data type
{
    public
    int a;
    private
    int b;
    protected
    int c;

    public void representation()
    {
        x = 9;
        z = 2;    
    }

}

class derived_class_2 : derived_class_1 // error encounterd when we do multiple inheritances ?
{
    public void all_work()
    {

        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
        //b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(c);
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x);
        //y = Convert.ToInt32(Console.ReadLine());
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(z);
    }

}
