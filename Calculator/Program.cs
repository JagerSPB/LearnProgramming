class Program
{
    public static double GetUserInput()
    {
        double number;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("принимаем только цифры, попробуйте еще раз");
            }
        }
    }
    public static void Calculator()
    {
        double result = 0;
        Console.WriteLine("Введите первое число: ");
        double num1 = GetUserInput();

        Console.WriteLine("Введите второе число: ");
        double num2 = GetUserInput();

        Console.WriteLine("Введите 1 для суммирования");
        Console.WriteLine("Введите 2 для вычитания");
        Console.WriteLine("Введите 3 для умножения");
        Console.WriteLine("Введите 4 для деления");
        int action = int.Parse(Console.ReadLine()!);
        switch (action)
        {
            case 1: result = num1 + num2; break;
            case 2: result = num1 - num2; break;
            case 3: result = num1 * num2; break;
            case 4: result = num1 / num2; break;
        }

        Console.WriteLine($"результат вычисления: {result}");
    }

    public static void CalculatorV2()
    {
        Console.WriteLine("Введите первое число: ");
        double num1 = GetUserInput();

        Console.WriteLine("Введите второе число: ");
        double num2 = GetUserInput();

        Console.WriteLine("Введите цифру \"+\" для суммирования");
        Console.WriteLine("Введите цифру \"-\" для вычитания");
        Console.WriteLine("Введите цифру \"*\" для умножения");
        Console.WriteLine("Введите цифру \"/\" для деления");
        char action = char.Parse(Console.ReadLine()!);
        switch (action)
        {
            case '+':
                Console.WriteLine("замечательно, вы выбрали операцию суммирования? ");
                Thread.Sleep(2000);
                Console.WriteLine("занимаюсь вычислением, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат сложения {num1} и {num2} будет: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine("замечательно, вы собрались вычесть из одного числа другое?");
                Thread.Sleep(2000);
                Console.WriteLine("занимаюсь вычислением, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат вычитания из {num1} числа {num2} будет: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine("хотите, умножить одно число на другое?");
                Thread.Sleep(2000);
                Console.WriteLine("занимаюсь вычислением, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат множения {num1} на {num2} будет: {num1 * num2}");
                break;
            case '/':
                Console.WriteLine("Деление одного числа на другое? Легко");
                Thread.Sleep(2000);
                Console.WriteLine("хотя нет, это будет тяжелое вычисление, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат деления {num1} на {num2} будет: {num1 / num2}");
                break;
            default:
                Console.WriteLine("я вами разачарован, вы не попали в нужную клавишу");
                Thread.Sleep(2000);
                Console.WriteLine("вычислительный центр закрывается. До новых и плодотворных встреч!");
                break;
        }
    }

    public static void Main()
    {
        CalculatorV2();
        Console.ReadLine();
    }
}