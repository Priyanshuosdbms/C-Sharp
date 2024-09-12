public class PartialClassExample7
{
    public static void MethodInPartialClass()
    {
        Student s;
        s = new UG();
        s = new PG();

    }
}

public interface IMarks
{
    int calculate();
}
public class Student
{
    private
    int marks_int;
    int marks_ext;
    
    public int calculate()
    {
        Console.WriteLine("Enter the internal and external marks\n");
        marks_int = Convert.ToInt32(Console.ReadLine());
        marks_ext = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Total: " + 
        (marks_ext+marks_int));
        return (marks_ext+marks_int);
    }

}

public class UG : Student,IMarks
{
    private
    String? name;
    String? dept;
    String? regno;
    int attendance;

    public UG()
    {
        Console.WriteLine("Enter the name");
        name = Console.ReadLine();
        Console.WriteLine("Enter department");
        dept = Console.ReadLine();
        Console.WriteLine("Enter regno");
        regno = Console.ReadLine();
        Console.WriteLine("Enter Attendance");
        attendance = Convert.ToInt32(Console.ReadLine());
        attendance += calculate();        
        Console.WriteLine("Total : " + attendance);
    }

}

public class PG : Student,IMarks
{
    public 
    String? name;
    String? specialization;
    String? regno;

    public PG()
    {
        Console.WriteLine("Enter the name");
        name = Console.ReadLine();
        Console.WriteLine("Enter department");
        specialization = Console.ReadLine();
        Console.WriteLine("Enter regno");
        regno = Console.ReadLine();
        Console.WriteLine(calculate());
    }

}