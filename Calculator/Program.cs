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
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                result = num1 / num2;
                break;
        }

        Console.WriteLine($"результат вычисления: {result}");
    }

    public static void CalculatorV2()
    {
        Console.WriteLine("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите первое число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите ифру \"1\" для суммирования");
        Console.WriteLine("Введите ифру \"2\" для вычитания");
        Console.WriteLine("Введите ифру \"3\" для умножения");
        Console.WriteLine("Введите ифру \"4\" для деления");
        int action = int.Parse(Console.ReadLine());
        switch (action)
        {
            case 1:
                Console.WriteLine($"результат сложения {num1} и {num2} будет: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"результат вычитания из {num1} цифры {num2} будет: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"результат множения {num1} на {num2} будет: {num1 * num2}");
                break;
            case 4:
                Console.WriteLine($"результат деления {num1} на {num2} будет: {num1 / num2}");
                break;
        }
    }

    public static void Main()
    {
        CalculatorV2();
        Console.ReadLine();
    }
}