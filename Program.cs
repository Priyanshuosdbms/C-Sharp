// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2 strings: 
	length
	merge them and find combined len
	find whether the string contains dupli letters and print its posn.
	sort the letters in lexical order

ip array:
	greater than a given no. using linq methods
 
 
*/
/*
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice_switch;
            Console.WriteLine("Enter choice\n 1. string op\n 2. array op\n");
            choice_switch =  Convert.ToInt32(Console.ReadLine());
            switch(choice_switch) 
            {
                case 1: 
                    Console.WriteLine("Inside string operation\n");
                    String ops1,ops2;
                    Console.WriteLine("Enter string one : \n");
                    ops1 = Console.ReadLine();
                    Console.WriteLine("Enter string two : \n");
                    ops2 = Console.ReadLine();
                    stringops(ops1, ops2);
                    break;

                case 2:
                    Console.WriteLine("Inside Array operation\n");
                    int[] array = new int[10];
                    for(int i=0;  i<array.Length; i++)
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    arrayops(array);
                    break;

                default:
                    Console.WriteLine("Try again!!");
                    break;

                        
            }
        }

        static void stringops(String ops1 , String ops2)
        {
            Console.WriteLine("Given string one: " + ops1);
            Console.WriteLine("String length one is : " + ops1.Length);
            Console.WriteLine("Given string two: " + ops2);
            Console.WriteLine("String length two is : " + ops2.Length);
            String merger;
            int[] posn = new int[ops1.Length];
            merger = ops1 + ops2;
            Console.WriteLine("Merged String : " + merger);
            // dupliactes , sort
            char[] ch_ops1 = ops1.ToCharArray();
            char[] ch_ops2 = ops2.ToCharArray();
            Console.WriteLine(ops1.Distinct());
            Console.WriteLine(ops2.Distinct());
            Console.WriteLine("Sorted Strings:\n");
            var letters = new SortedSet<char>(ops1);
            foreach (char c in letters) Console.Write(c);

            var letters1 = new SortedSet<char>(ops2);
            foreach (char c in letters1) Console.Write(c);

        }

        static void arrayops(int[] array)
        {
            Console.WriteLine("Given array is : " + array);
            int num_user;
            Console.WriteLine("Enter your desired number\n");
            num_user = Convert.ToInt32(Console.ReadLine());
            Array.Sort(array);
            for(int i = 0;i<array.Length;i++) 
            {
               if(num_user  <= array[i])
                {
                    Console.Write(array[i]);
                }
            }
        }
    }
}
*/
/*
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Auser user1 = new Auser();
            Buser buser = new Buser();
            //user1.retval();
            buser.retval();
            user1.printr();
        }
    }

    class Auser
    {
        private String a, b;
        public void printr()
        {
            Console.WriteLine("Strngs are : " + a+b);
        }
        public void retval()
        {
            Console.WriteLine("Enter two strings: ");
            a = Console.ReadLine();
            b = Console.ReadLine();
            Console.WriteLine("The concotonated strings are : " + (a+b));
        }

    }

    class Buser : Auser
    {
        public String a, b;
        public void retval()
        {
            a = Console.ReadLine();
            b = Console.ReadLine();
            Console.WriteLine("The concotonated strings are : " + (a + b));
        }


    }
}
*/

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size 
            //        using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //Console.WriteLine(food[0]);
            //Console.WriteLine(food[1]);
            //Console.WriteLine(food[2]);
            //Console.WriteLine(food[3]);

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
