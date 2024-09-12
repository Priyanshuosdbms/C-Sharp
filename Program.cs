// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Linq;

class Program{
    static void Main(string[] args)
    {
        // Console.WriteLine("This is the main program.");
        // Console.WriteLine(args.Length);
        
        // You can call methods or use members of the partial class here.
        //PartialClassExample.MethodInPartialClass();
        //PartialClassExample1.MethodInPartialClass();
        //PartialClassExample2.MethodInPartialClass();
        //PartialClassExample3.MethodInPartialClass();
        //PartialClassExample4.MethodInPartialClass();
        //PartialClassExample5.MethodInPartialClass();
        //PartialClassExample6.MethodInPartialClass();
        //PartialClassExample7.MethodInPartialClass();
        //PartialClassExample8.MethodInPartialClass();
        //PartialClassExample9.MethodInPartialClass();
        //PartialClassExample10.MethodInPartialClass();
        Console.WriteLine("PartialClassExam\aple");
        PartialClassExampleEndSem.MethodInPartialClass();
        //PartialClassExampleEndSemUnitTwo.MethodInPartialClass();
    }
}


/*
class Program{
    public static void Main(String[] args)
    {
        //1.fact
        //2.sorting of n nos.
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nMenu\n 1.Factorial \n2.Sorting\n");
        switch(a)
        {
            case 1: factorial();  break;         
            case 2: sorting();break;                       
        }
    }

    private static void factorial()
    {
        int x = 1;
        int n;
        Console.WriteLine("Enter n value");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i=1 ; i<=n ; i++)
        {
            x = x*i;            
        }
        Console.WriteLine(x);
    }

    private static void sorting()
    {
        int[] array = new int[10];
        int n=5;
        array[0] = 1;
        array[1] = 5;
        array[2] = 3;
        array[3] = 2;
        array[4] = 4;
        for(int i=0 ; i<n ; i++)
        {
            for(int j = i+1 ; j<n ; j++)
            {
                if(array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        for(int i=0 ; i<n ; i++)
        {
            Console.WriteLine(array[i]);
        }
    
    }
}
*/
/*
// list1,list2
class Program
{
    public static void Main()
    {
        int i;
        int k,l;
        k = l = 0;
        int n,m;
        Console.WriteLine("Enter number of ele in list 1\n");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of ele in list 2\n");
        m = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[10];
        int[] array2 = new int[10];
        int[] Finalarr = new int[n+m];
        Console.WriteLine("List 1:\n");
        for(i=0 ; i<n ; i++)
        {
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("List 2\n");        
        for(i=0 ; i<m ; i++)
        {
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Sort1(array1,n);
        Sort1(array2,m);
        for(i=0 ; i<n ; i++)
        {
            Console.WriteLine(array1[i]);
        }
        for(i=0 ; i<m ; i++)
        {
            Console.WriteLine(array2[i]);
        }
        Console.WriteLine("Finale\n");
        for(i=0 ; i<n+m-1 ; i++)
        {
            if(array1[k] >= array2[l])
            {
                Finalarr[i] = array1[l];
                l++;
            }
            else
            {
                Finalarr[i] = array2[k];
                k++;
            }
        }
        Console.WriteLine("Final Array\n");
        for(i=0 ; i<n+m-1 ; i++)
        {
            Console.WriteLine(Finalarr[i]);
        }
    }
    private static void Sort1(int[] arr , int n)
    {
        for(int i=0 ; i<n ; i++)
        {
            for(int j=i+1 ; j<n ; j++)
            {
                if(arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[j] = arr[i];
                    arr[i] = temp; 
                }
            }
        }
    }
}
*/
/*
class Program
{
    static void Main()
    {
        // Example arrays with duplicates
        int[] array1 = { 1, 2, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 4, 5, 6, 7 };

        // Remove duplicates using Distinct()
        int[] distinctArray1 = array1.Distinct().ToArray();
        int[] distinctArray2 = array2.Distinct().ToArray();

        // Print the distinct arrays
        Console.WriteLine("Distinct Array 1: " + string.Join(", ", distinctArray1));
        Console.WriteLine("Distinct Array 2: " + string.Join(", ", distinctArray2));
        int[] combinedDistinctArray = array1.Union(array2).ToArray();
        Console.WriteLine("Array : \n"+ string.Join(",",combinedDistinctArray));
    }
}
*/