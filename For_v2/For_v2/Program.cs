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
            // For7. Даны два целых числа A и B (A < B). Найти сумму всех целых чисел
            // от A до B включительно.
            /*
            int a = 3, b = 10, summ = 0;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                summ += i;
            }
            Console.WriteLine($"сумма всех чисел от {a} до {b} будет: {summ}");
            */
            //For8. Даны два целых числа A и B (A < B). Найти произведение всех целых чисел от A до B включительно.
            /*
            int a = 2, b = 5, mult = 1;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                mult *= i;
            }
            Console.WriteLine($"произведение всех чисел от {a} до {b} будет: {mult}");
            */
            //For9. Даны два целых числа A и B (A < B). Найти сумму квадратов всех целых чисел от A до B включительно.
            /*
            int a = 2, b = 3, summ2 = 1;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                summ2 += i * i;
            }
            Console.WriteLine($"сумма квадратов чисел от {a} до {b} будет: {summ2}");
            */
            // For10. Дано целое число N (> 0). Найти сумму 1 + 1/2 + 1/3 + . . . + 1/N (вещественное число).
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            double summ = 0;
            for (double i = 1; i <= n; i++)
            {
                summ += 1 + 1 / i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"сумма делений будет: {summ}");
            */
            // For11. Дано целое число N (> 0). Найти сумму N2 +(N+1)2 +(N+2)2 +...+(2·N)2 (целое число)
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += (n + i) * (n + i);
            }
            Console.WriteLine($"результат будет: {result + (2*n*2*n)}");
            */
            //For12◦. Дано целое число N (> 0). Найти произведение 1.1·1.2·1.3·... (N сомножителей).
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            double result = 1;
            for (double i = 1; i <= n; i++)
            {
                result *= 1 + i/10;
            }
            Console.WriteLine($"результат перемножения будет: {result}");
            */
            // For13◦. Дано целое число N (> 0). Найти значение выражения 1.1 − 1.2 + 1.3 − . . .
            // (N слагаемых, знаки чередуются). Условный оператор не использовать.
            // Console.WriteLine("Введите число: ");
            /*
            int n = 5; //int.Parse(Console.ReadLine());
            double result = 0;
            for (double i = 1; i <= n; i++)
            {
                result += (1 + i / 10);
                result =- result;
            }
            Console.WriteLine($"результат перемножения будет: {result}");
            */
            // For14. Дано целое число N (> 0). Найти квадрат данного числа, используя для его вычисления следующую формулу:
            // N2 =1+3+5+...+(2·N−1).После добавления к сумме каждого слагаемого выводить текущее значение
            //     суммы (в результате будут выведены квадраты всех целых чисел от 1до N).
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 2 * i - 1;
                Console.WriteLine($"квадрат числа {i} будет: {result} ");
            }
            */
            // For15◦. Дано вещественное число A и целое число N (> 0). Найти A в степени N: A N = A·A· . . . ·A
            //     (числа A перемножаются N раз).
            /*
             double a = 4, result = 1;
             int n = 6;
             for (int i = 1; i <=n; i++)
             {
                 result *= a;
                 Console.WriteLine(result);
             }
             */
            // For16◦. Дано вещественное число A и целое число N (>0). Используя один цикл, вывести все 
            //     целые степени числа A от 1 до N.
            /*
            double a = 5, result = 1;
            int n = 6;
            for (double i = 1; i <= n; i++)
            {
                result *= a ;
                Console.WriteLine($" возводим число {a} в степень {a}, {i} раз = {result}  ");
            }
            */
        }
    }
}