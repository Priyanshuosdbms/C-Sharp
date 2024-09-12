
public class PartialClassExample8
{
    public static void MethodInPartialClass(/*String[] args*/)
    {
        /*
        Access2 onj = new Access2();
        onj.calculate();
        Alpha a1 = new Alpha();
        a1.func1();
        a1.func1(1034);
        a1.func1(1034,"abc");*/
        Engineering std = new Engineering();
        std.initialize();
        std.printr();
        UG std1 = new UG();
    }

}

public interface Base
{
    void calculate();
}

public class Access1
{
    List<String> st = new List<string>();
    public void name_list()
    {
        st.Add("Alpha");
        st.Add("Beta");
        st.Add("Gamma");
        st.Add("GammaBeta");
        st.Add("Charlie");
    }

    public void print()
    {
        st.Add("Gamma");
        st.Add("GammaBeta");
        st.Add("Charlie");
        Console.WriteLine(st);
    }


}

public class Access2 : Access1,Base
{
    public void calculate()
    {
        int count=0;
        //print();
        Console.WriteLine(++count);
        print();
    }
    
}

public class Alpha
{
    String? name1;
    String? name2;
    int regno;

    public void func1()
    {
        Console.WriteLine("Inside func1 with no arguments");
    }

    public void func1(int regno)
    {
        Console.WriteLine("Inside func1 with regno " + regno);
    }

    public void func1(int regno, String name1)
    {
        Console.WriteLine("Inside func1 with regno " + regno + " with name " + name1);

    }
}

public class  Engineering
{
    private
    static int int_marks;
    String? name;
    String? regno;

    public void initialize()
    {
        int_marks = 40;
        name = "llll";
        regno = "21csop90";
    }

    public void printr()
    {
        Console.WriteLine(int_marks);
        Console.WriteLine(name);
        Console.WriteLine(regno);
    }

    public class UG
    {
        int attendance;
        int ext_marks;

       /* public UG()
        {
            ext_marks = 55;
            attendance = 4;
            Console.WriteLine(attendance+ext_marks+int_marks);
        }
        */

    }

    public class PG
    {
       int ext_marks = 52;
        public void total()
        {
            Console.WriteLine(int_marks+ext_marks);
        } 

    }
}
