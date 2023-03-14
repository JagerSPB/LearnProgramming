namespace FOR
{
    internal class Program
    {
        public static void Main()
        {
            // Тернарный оператор: 
            // int a = 5;
            // int b;
            // b = (a > 0) ? a : -a;
            // Console.WriteLine(a > 0 ? "Пол" : "Отриц");

            // Тернарный оператор: 
            // int a = 5;
            // int b;
            // char s = 'e';
            // char t;
            // t = char.IsLower(s) ? char.ToUpper(s) : s;
            // b = (a > 0) ? a : -a;
            // Console.WriteLine(a > 0 ? "Пол" : "Отриц");

            // If1. Дано целое число. Если оно является положительным, то прибавить к нему 1;
            // в противном случае не изменять его. Вывести полученное число.
            /*
            int a = 8;
            a = a > 0 ? ++a : a;
            Console.WriteLine(a);
            */
            // If2. Дано целое число. Если оно является положительным, то прибавить к нему 1;
            // в противном случае вычесть из него 2. Вывести полученное число.
            /*
            int a = -48;
            a = a > 0 ? ++a : a -2;
            Console.WriteLine(a);
            */
            //If6◦. Даны два числа. Вывести большее из них.
            /*
            int a = 100, b = 20;
            Console.WriteLine(a > b ? a : b);
            */
            // For1. Даны целые числа K и N (N > 0). Вывести N раз число K.
            /*
            int n = 5, k = 10;
            for (int i = 0; i < n; i++) // цикл с параметром
            {
                Console.WriteLine(k);
            }
            */
            // For2. Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа,
            //     расположенные между A и B (включая сами числа A и B), а также количество N этих чисел.
            /*
            int a = 10, b = 21, count =0;
            for (int i = a; i <= b; i++)
            {
                count++;
                Console.Write($"{i} ");
            }
            Console.WriteLine($"всего: {count}");
            */
            // For3. Даны два целых числа A и B (A < B). Вывести в порядке убывания все
            // целые числа, расположенные между A и B (не включая числа A и B), а также количество N этих чисел.
            /*
            int a = 14, b = 25, count =0;
            for (int i = b; i >= a; i--)
            {
                count++;
                Console.Write($"{i} ");
            }
            Console.WriteLine($"всего: {count}");
            */
            // For4. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1, 2, ..., 10 кг конфет.
            /*
            Console.WriteLine("Введите стоимость конфет за 1 кг ");
            double price = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} кг - {price * i} руб ");
            }
            */
            // For5◦. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1,
            // 0.2, ..., 1 кг конфет.
            /*
            Console.WriteLine("Введите стоимость конфет за 1 кг ");
            double price = double.Parse(Console.ReadLine());
            for (double i = 0.1; i < 1; i += 0.1)
            {
                Console.WriteLine($"{Math.Round(i, 2)} кг - {Math.Round(i*price, 2)} руб ");
            }
            */
            // For6. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2,
            // 1.4, ..., 2 кг конфет.
            /*
            Console.WriteLine("Введите стоимость конфет за 1 кг ");
            double price = double.Parse(Console.ReadLine());
            for (double i = 1.2; i < 2; i += 0.2)
            {
                Console.WriteLine($"{Math.Round(i, 2)} кг - {Math.Round(i*price, 2)} руб ");
            }
            */
            // For7. Даны два целых числа A и B (A < B). Найти сумму всех целых чисел
            // от A до B включительно.
            /*
            int a = 2, b = 4, result = 0;
            for (int i = a; i <= b; i++)
            {
              result += i;
            }
            Console.WriteLine(result);
            */
            //For8. Даны два целых числа A и B (A < B). Найти произведение всех целых чисел от A до B включительно.
            /*
            int a = 2, b = 3, result = 1;
            for (int i = a; i <= b; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
            */

            // For9. Даны два целых числа A и B (A < B). Найти сумму квадратов всех целых чисел от A до B включительно.
            /*
            int a = 2, b = 5, result = 0;
            for (int i = a; i <= b; i++)
            {
                result += i * i;
            }
            Console.WriteLine(result);
            */
            // For10. Дано целое число N (> 0). Найти сумму
            // 1 + 1/2 + 1/3 + . . . + 1/N (вещественное число).
            /*
            double a = 10, result = 0;
            for (double i = 1; i <= a; i++)
            {
                result += 1/i;
                Console.WriteLine(result);
            }
            */
            // For11. Дано целое число N (> 0). Найти сумму
            // N2 +(N+1)2 +(N+2)2 +...+(2·N)2 (целое число)
            /*
            int n = 2, result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += (n + i) * (n + i);
                Console.WriteLine(result);
            }
            Console.WriteLine($"{ result + Math.Pow(2*n,2)} ");
            */
            // For12◦. Дано целое число N (> 0). Найти произведение
            // 1.1·1.2·1.3·... (N сомножителей).   
            /*
             int n = 3;
             double result = 1;
             for (double i = 1; i <= n; i++)
             {
                 result *= 1 + (i / 10);
                 Console.WriteLine(result);
             }
             */
            // For13◦. Дано целое число N (> 0). Найти значение выражения
            // 1.1 − 1.2 + 1.3 − . . .
            // (N слагаемых, знаки чередуются). Условный оператор не использовать.
            int n = 12;
            double result = 1;
            for (double i = 1; i <= n; i++)
            {
                result =- (i / 10);
                Console.WriteLine($"{result} ");
                result =+ (i / 10);
                Console.WriteLine($"{result} ");
                
            }
        }
    }
}