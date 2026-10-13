class Car
{
    public string Make;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;

    public void Drive(double miles)
    {
    if (Fuel >= miles)
     {
     Mileage = Mileage + miles;
     Fuel = Fuel - miles;
     System.Console.WriteLine("Car is driving");
     }
     else
     {
         System.Console.WriteLine("Not enough fuel");
     }
    }
}