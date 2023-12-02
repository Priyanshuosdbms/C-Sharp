using System;
using System.Linq.Expressions;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Inside main");
            List<Employee> users = new List<Employee>();
            Console.WriteLine("Enter total entries");
            count = Convert.ToInt32(Console.ReadLine());
            citizen ciz = new citizen();
            
        }
    }

    public class Employee
    {
        List<string> name = new List<string>();
        List<int> salary = new List<int>();

        public void getdata()
        {
            String? user;
            int sal;
            Console.WriteLine("Enter name:");
            user = Console.ReadLine();
            Console.WriteLine("Enter salary");
            sal = Convert.ToInt32(Console.ReadLine());
            name.Append(user);
            salary.Append(sal);        
        }

        public void display()
        {
            foreach (string num in name)
            {
                Console.WriteLine(num);
            }
        }

        public void displayhighest(int count)
        {
            name.Sort();
            Console.WriteLine("Highest Salary : " + name.ElementAt(count - 1));
        }

    }

    public class citizen
    {
        public string name;
        public int age;
        public int mobile_number;

        public citizen()
        {
            Console.WriteLine("Enter name, age, phone no.");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            mobile_number = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (mobile_number.ToString().Length != 10)
                {
                    throw new InvalidMn("Error");
                }

                catch (InvalidMn ex)
            {
                Console.WriteLine(ex.Message);
            }
            } 
        }
    }
        
}