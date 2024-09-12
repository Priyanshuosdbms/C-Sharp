using System;
using System.Numerics;
partial class PartialClassExample3
{
    public static void MethodInPartialClass()
    {
        Console.WriteLine("Enter the 2 strings");
        String? input1  = Console.ReadLine();
        String? input2 = Console.ReadLine();
        User user1 = new User();
        User user2 = new User(input1);
        User user3 = new User(input1, input2);
        Getter_setter single_input = new Getter_setter();
        single_input.Name = "dd";
        String output = single_input.Name;
        Console.WriteLine(output);
    }

}


public class User
{
    //String? alpha,beta;

    public User()
    {
        Console.WriteLine("This needs no parameters");
    }

    public User(String? alpha) :this()
    {
        Console.WriteLine("This needs one paramter and that is" + alpha);
    }

    public User(String? alpha, String? beta) : this("alpha: " + alpha + " beta: " + beta)
    {
        Console.WriteLine("This needs two parameters and those are" + alpha + " beta: " + beta);
    }

}

public class Getter_setter
{
    private String name;
    
    public String Name
    {
        get
        {
            if(name != null)
            return name;
            
            else throw new IndexOutOfRangeException("Name cannot be null");
        }
        set
        {
            name = value;
        }
    }
}
























/*

public class student
{
    private string[] Name;

    public string this [int index]
    {
        get
        {
            return Name[index];

        }

        set
        {
            Name[index] = value;

        }
    }
}


class User // cap name for class
{
    public String name, location;

    public User(User user)
    {
        name = user.name;
        location = user.location;

    }

    static User()
    {
        Console.WriteLine("I am in static cnostructor");

    }

    public User(){
        Console.WriteLine("I am in default constructor");
    }

    /*
    public User()
    {
        Console.WriteLine("moshi moshi");
                 
    }

    public User(string a) : this()
    {
        Console.Write(a);
    }

    public User(string a, string b) : this("Welcome")
    {
        Console.WriteLine(a + " " + b);
    }
    */
/*
public User(string name, string location)
{
    this.name = name;
    this.location = location;
}

public User(string a, string b, string locationi)
{
    name = a;
    location = b;

}

*/
/*


        User user1 = new User("nalla" , "alan", "CHn"); // Instansiate the method
        User user2 = new User(user1); // Formal and actual parameter
        Console.WriteLine(user1.name);
        Console.WriteLine(user2.name);
        

        Console.WriteLine(user1.location);
        Console.WriteLine(user1.location);

*/