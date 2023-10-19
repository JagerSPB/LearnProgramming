class Program
{
    public static void Calculator()
    {
        double result = 0;
        Console.WriteLine("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите первое число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите 1 для суммирования");
        Console.WriteLine("Введите 2 для вычитания");
        Console.WriteLine("Введите 3 для умножения");
        Console.WriteLine("Введите 4 для деления");
        int action = int.Parse(Console.ReadLine());
        switch (action)
        {
            case 1: result = num1 + num2; break;
            case 2: result = num1 - num2; break;
            case 3: result = num1 * num2; break;
            case 4: result = num1 / num2; break;
        }

        Console.WriteLine($"результат вычисления: {result}");
    }
    

    public static void Main()
    {
        Calculator();
        Console.ReadLine();
    }
}