class Program
{
    public static void Calculator()
    {
        double result = 0;
        Console.WriteLine("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
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

        Console.WriteLine("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите ифру \"1\" для суммирования");
        Console.WriteLine("Введите ифру \"2\" для вычитания");
        Console.WriteLine("Введите ифру \"3\" для умножения");
        Console.WriteLine("Введите ифру \"4\" для деления");
        int action = int.Parse(Console.ReadLine());
        switch (action)
        {
            case 1:
                Console.WriteLine("замечательно, вы выбрали операцию суммирования? ");
                Thread.Sleep(2000);
                Console.WriteLine("занимаюсь вычислением, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат сложения {num1} и {num2} будет: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine("замечательно, вы собрались вычесть из одного числа другое?");
                Thread.Sleep(2000);
                Console.WriteLine("занимаюсь вычислением, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат вычитания из {num1} цифры {num2} будет: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine("хотите, умножить одно число на другое?");
                Thread.Sleep(2000);
                Console.WriteLine("занимаюсь вычислением, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат множения {num1} на {num2} будет: {num1 * num2}");
                break;
            case 4:
                Console.WriteLine("Деление одного числа на другое? Легко");
                Thread.Sleep(2000);
                Console.WriteLine("хотя нет, это будет тяжелое вычисление, можете пока попить кофейку....");
                Thread.Sleep(4000);
                Console.WriteLine("шутка всё уже готово!");
                Thread.Sleep(1000);
                Console.WriteLine($"результат деления {num1} на {num2} будет: {num1 / num2}");
                break;
            default: Console.WriteLine("я вами разачарован, вы не попали в нужную клавишу");
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