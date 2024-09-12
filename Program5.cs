public class PartialClassExample4
{
    public static void MethodInPartialClass()
    {
        Car c = new Car();
        c.all_work();
                        
    }
}

class Vehicle
{
    public String? Brand;

    public void vehicle_input()
    {
        Console.WriteLine("Enter the brand ");
        Brand = Console.ReadLine();
    }

    public void vehicle_output()
    {
        Console.WriteLine("Brand of Vehicle is : " + Brand);
    }

}

class Car : Vehicle
{
    public int year;

    public void car_input_year()
    {
        Console.WriteLine("Enter year of manufacturing");
        year = Convert.ToInt32(Console.ReadLine());
    }

    public void car_ouput_year()
    {
        Console.WriteLine("Year of manufacturing is : " + year);
    }

    public void all_work()
    {
        vehicle_input();
        car_input_year();
        vehicle_output();
        car_ouput_year();
    }
    
}

