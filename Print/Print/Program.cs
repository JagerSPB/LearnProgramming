class Program

{
    public static int GetUserInput()
    {
        int number;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                if (number <= 50)
                {
                    return number; 
                }
                else if (number > 50)
                {
                    Console.WriteLine("вяглядит слишком много, начните с тиража < 50 ");
                }
            }
       
            else
            {
                Console.WriteLine("принимаем только цифры, попробуйте еще раз");
            }
        }
    }

    public static void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет текста в красный

        Console.WriteLine("Пожалуйста, внимательно прочитайте лицензионное соглашение!\n");
        Console.ResetColor(); // сбрасываем цвет на стандартный
        Thread.Sleep(2000);
        Console.WriteLine("Программа разработана специалистами NASA, для выполнения очень сложной задачи \n" +
                          "используя эту программу вы даёте согласие на то, что она не будет использована \n" +
                          "в коммерческих целях, так же вы даёте согласие на использование вашего движимого и \n" +
                          "не очень имущества с целью обогащения создателя этой программы. ");
        Thread.Sleep(5000);
        Console.WriteLine("\nВы принимаете условия использования этой программы?");
        // Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет текста в красный
        // Console.WriteLine("Yes/NO");
        // Console.ResetColor(); // сбрасываем цвет на стандартный
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет текста в зелёный
        Console.Write("Yes /");
        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет текста в красный
        Console.WriteLine(" No");
        Console.ResetColor(); // сбрасываем цвет на стандартный
        

        string yesOrNo = Console.ReadLine();
        if (yesOrNo.ToLower() == "yes")
        {
            Console.WriteLine("Спасибо за доверие, Вы очень смелый и состоятельный человек, начнём...");
        }
        else
        {
            Console.WriteLine("Извините связь прерывалась вы напечатали Yes ?");
            Thread.Sleep(1500);
            Console.WriteLine("Ок \nСпасибо за доверие начнём...");
        }

        Console.WriteLine("Введите текст который необходимо размножить: ");
        string text = Console.ReadLine();

        Console.WriteLine($"Ха ха ха, вы хотите размножить \"{text}\" ?");
        Thread.Sleep(500);
        Console.WriteLine($"Ок, сколько раз необходимо напечатать этот ваш \"{text}\" ?");
        int count = GetUserInput();
        Console.WriteLine($"Отправляю в тираж \"{text}\", {count} раз, ожидайте ...");
        int half = count / 2;
        while (count != half)
        {
            Console.WriteLine($" \"{text}\"   (осталось ещё строк {count-1})");
            Thread.Sleep(500);
            count--;
        }
        Console.WriteLine($"секунду необходимо заправить чернила в картридж ...");
        Thread.Sleep(3000);
        Console.WriteLine($"Печатаю \"{text}\", дальше {count} раз, ожидайте ...");
        while (count != 1)
        {
            Console.WriteLine($" \"{text}\"   (осталось ещё строк {count-1})");
            Thread.Sleep(500);
            count--;
        }
        
        Thread.Sleep(1500);
        Console.WriteLine($"\"{text}\"... это была последняя строчка  ");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет текста в красный
        Console.WriteLine($"Заказ выполнен!");
        Console.ResetColor(); // сбрасываем цвет на стандартный
        Thread.Sleep(2000);
        Console.WriteLine($"Спасибо, что воспользовались нашей программой, оставайтесь на месте,\n" +
                          $"группа мобильных нотариусов уже выехала!");
    }


    // public static void Main()
    // {
    //     Print();
    //     Console.ReadLine();
    // }
    public static void Main()
    {
        bool exit = false; // флаг для определения, когда нужно выйти из цикла
        while (!exit)
        {
            Print();
            Console.WriteLine("Введите 'exit', чтобы выйти:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "exit")
            {
                exit = true; // устанавливаем флаг выхода из цикла
            }
        }
    }
}