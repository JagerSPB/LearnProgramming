class Program
{
    static void Main()
    {
        Car myCar1 = new Car();
        Console.WriteLine(myCar1.color);
        myCar1.ChangeColor("Red");
        Console.WriteLine(myCar1.color);
        Car myCar2 = new Car();
        myCar2.speed = 100;
        myCar2.color = "Black";
        myCar2.isCrashed = true;
        myCar2.model = "BMW";
        Console.WriteLine($"Скорость:{myCar2.speed}, Color:{myCar2.color}, была в аварии {myCar2.isCrashed}");
        myCar1.CurrentSpeed();
        myCar2.CurrentSpeed();
        
        Console.ReadLine();
    }
}


class Car
{
    public int speed;
    public string color = "Green";
    public string model;
    public int age;
    public bool isCrashed;

    public void CurrentSpeed()
    {
        Console.WriteLine($"Текущая скорость: {speed}");
    }

    public void ChangeColor(string col)
    {
        color = col;
    }
}