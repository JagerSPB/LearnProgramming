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
            double a = 3, result = 0;
            for (double i = 1; i <= a; i++)
            {
                result += 1 + 1/i;
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
            /*
            int n = 6;
            double result = 1;
            for (double i = 1; i <= n; i++)
            {
                result =- (i / 10);
                Console.WriteLine($"{result} ");
                result =+ (i / 10);
                Console.WriteLine($"{result} ");
            }
            */
            // For14. Дано целое число N (> 0). Найти квадрат данного числа, используя для его вычисления следующую формулу:
            // N2 =1+3+5+...+(2·N−1).  После добавления к сумме каждого слагаемого выводить текущее значение суммы
            //     (в результате будут выведены квадраты всех целых чисел от 1 до N).
            /*
            int n = 10;
            double result = 0;
            for (double i = 1; i <= n; i ++)
            {
                result += (2 * i - 1);
                Console.WriteLine($"{i} ->  {result} ");
            }
            */
            // For15◦. Дано вещественное число A и целое число N (> 0). Найти A в степени N: A N = A·A· . . . ·A
            //     (числа A перемножаются N раз).
            /*
            double a = 4, result = 1;
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                result *= a;
            }
             Console.WriteLine(result);
            */
            // For16◦. Дано вещественное число A и целое число N (> 0). Используя один цикл,
            //     вывести все целые степени числа A от 1 до N.
            /*
            double a = 5, result = 1;
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                result *= a;
                Console.WriteLine(result);
            }
            */
            // For17. Дано вещественное число A и целое число N (>0). Используя один цикл, найти сумму
            // 1+A+A2 +A3 +...+AN.
            /*
            double a = 5, result = 1;
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                result += i*a;
                Console.WriteLine(result);
            }
            */
            // For18. Дано вещественное число A и целое число N (>0). Используя один цикл, 
            //     найти значение выражения  1−A+A2 −A3 +...+(−1)N·AN. Условный оператор не использовать.
            //==========================================================
            //
            // double a = 5, result = 1;
            // int n = 5;
            // for (int i = 1; i <= n; i++)
            // {
            //     // result =+ Math.Pow(1-a, i);
            //     // result =- Math.Pow(a, i);
            //     Console.WriteLine(result);
            // }
            //Console.WriteLine($"{result + (Math.Pow(-1,n) * Math.Pow(a,n))}");
            //==========================================================
            // For19◦. Дано целое число N (> 0). Найти произведение (N–факториал). Чтобы избежать целочисленного
            //     переполнения, вычислять это произведение с помощью вещественной переменной и вывести
            //       его как вещественное число
            /*
            int n = 5;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Console.WriteLine( result);
            }
            */
            // For20◦. Дано целое число N (> 0). Используя один цикл, найти сумму 1! + 2! + 3! + ... + N! 
            //     (выражение N! — N–факториал — обозначает произведение всех целых чисел от 1 до N: N! = 1·2·...·N).
            //     Чтобы избежать целочисленного пере- полнения, проводить вычисления с помощью
            //     вещественных переменных и вывести результат как вещественное число.
            /*
            int n = 5;
            double result = 1, summF = 0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Console.Write($"factorial {i}: {result}  ");
                summF += result;
                Console.WriteLine($" summ: {summF} ");
            }
            */
            // For21. Дано целое число N (> 0). Используя один цикл, найти сумму 1 + 1/(1!) + 1/(2!) + 1/(3!) + ... + 1/(N!)
            //     (выражение N! — N–факториал — обозначает произведение всех целых чисел от 1 до N: N! = 1·2·...·N).
            //      Полученное число является прибли- женным значением константы e = exp(1).
            /*
            int n = 5;
            double result = 1, summF = 0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Console.Write($"factorial {i}: {result}  ");
                summF += result;
                Console.WriteLine($" summ: {1/summF} ");
            }
            */
            // For31. Дано целое число N (> 0). Последовательность вещественных чисел AK определяется следующим образом:
            //       A0 =2, AK =2+1/AK−1, K=1,2,.... Вывести элементы A1, A2, . . . , AN .


            //     For32. Дано целое число N (> 0). Последовательность вещественных чисел AK определяется следующим образом:
            //     A0 = 1, AK = (AK−1 + 1)/K, K = 1,2,... . Вывести элементы A1, A2, . . . , AN .

            // For33◦. Дано целое число N (>1). Последовательность чисел Фибоначчи FK(целого типа) определяется 
            //     следующим образом: F1 =1, F2 =1, FK =FK−2 +FK−1, K =3,4,.... Вывести элементы F1, F2, ..., FN .
            /*
            int f = 20, num1 = 0, num2 = 1, num3 = 0;
            for (int i = 3; i <= f; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
            */
            // ================Вложенные циклы===================
            // For36◦. Даны целые положительные числа N и K. Найти сумму 1K +2K +...+NK. Чтобы избежать целочисленного 
            //     переполнения, вычислять слагаемые этой суммы с помощью вещественной переменной
            //     и выводить результат как вещественное число.
            ///*
            int n = 5, k = 3;
            double result = 1, sum = 0;
            for (int i = 1; i <= n; i++)
            {
               
                for (int j = 1; j <= k; j++)
                {
                    result *= i;
                }
                sum += result;
                Console.WriteLine(result);
                result = 1;
            }
            Console.WriteLine($" сумма {sum}");
            //*/

            // For37. Дано целое число N (> 0). Найти сумму 11 +22 +...+NN. Чтобы избежать целочисленного переполнения, 
            //     вычислять слагаемые этой суммы с помощью вещественной переменной и выводить результат как вещественное число.
            /*
            int n = 3, sum = 0, pow = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    pow *= i;
                }
                sum += pow;
                Console.WriteLine(pow);
                pow = 1;
            }
            Console.WriteLine($"сумма {sum}");
            */
        }
    }
}