namespace For_v2
{
    internal class Program
    {
        public static void Main()
        {
            //For1. Даны целые числа K и N (N > 0). Вывести N раз число K.
            /*
            int k = 3, n = 5;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"[{i}] -> {k}");
            }
            */
            // For2. Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа, 
            //     расположенные между A и B (включая сами числа A и B), а также количество N этих чисел.
            /*
             int a = 2, b = 8, countN = 0;
             for (int i = a; i <= b; i++)
             {
                 Console.WriteLine($"[{i}]");
                 countN++;
             }
             Console.WriteLine($"Всего: {countN} ");
            */
            // For3. Даны два целых числа A и B (A < B). Вывести в порядке убывания все
            //     целые числа, расположенные между A и B (не включая числа A и B), а
            //     также количество N этих чисел.
            /*
            int a = 4, b = 10, countN = 0;
            for (int i = b; i >= a; i--)
            {
                Console.WriteLine($"[{i}]");
                countN++;
            }
            Console.WriteLine($"всего: {countN}");
            */
            // For4. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1,
            // 2, ..., 10 кг конфет.
            /*
            Console.WriteLine("Введите цену за 1 кг. : ");
            double price = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"цена за {i} кг: {i * price}");
            }
            */
            // For5◦. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1,
            // 0.2, ..., 1 кг конфет.
            /*
            Console.WriteLine("Введите цену за 1 кг. : ");
            double price = double.Parse(Console.ReadLine());
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine($"цена за {i/10} кг: {(i/10) * price}");
            }
            */
            // For6. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2,
            // 1.4, ..., 2 кг конфет.
            /*
            Console.WriteLine("Введите цену за 1 кг. : ");
            double price = Double.Parse(Console.ReadLine());
            for (double i = 1; i <= 5; i++)
            {
                Console.WriteLine($"стоимость {1 + i / 5} кг. = {(1 + i / 5) * price}");
            }
            */
            
        }
    }
}