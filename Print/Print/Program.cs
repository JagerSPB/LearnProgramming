class Program

{
    public static int GetUserInput()
    {
        int number;
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

    public static void Print()
    {
        Console.WriteLine("Программа разработана специалистами NASA, для выполнения очень сложной задачи \n" +
                          "используя эту программу вы даёте согласие на то, что она не будет использована \n" +
                          "в коммерческих целях, так же вы даёте согласие на использование вашего движимого \n" +
                          " не очень движимого имущества с целью обогащения создателя этой программы. ");
        
        Console.WriteLine("Вы принимаете условия использования этой программы?");

        Console.WriteLine($"Сколько раз необходимо напечатать {}");
        int countOfPrint = GetUserInput();
        
        char action = char.Parse(Console.ReadLine()!);
        Thread.Sleep(2000);
    }
    

    public static void Main()
    {
        Print();
        Console.ReadLine();
    }