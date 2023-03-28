namespace Learn_While
{
    internal class Program
    {
        public static void Main()
        {
            // While1◦. Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное
            //     количество отрезков длины B (без наложений). Не используя операции умножения и деления, найти длину
            //     незанятой части отрезка A.
            /*
             int a = 18, b = 5;
             while (b <= a)
             {
                 a -= b;
             }
 
             Console.WriteLine(a);
            */
            // While2◦. Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное 
            // количество отрезков длины B (без наложений). Не используя операции умножения и деления,
            //     найти количество отрезков B, размещенных на отрезке A.
            /*
            int a = 29, b = 5, count = 0;
            while (b <= a)
            {
                a -= b;
                count++;
            }
            Console.WriteLine(count);
            */
            // While3. Даны целые положительные числа N и K. Используя только операции сложения и вычитания,
            //     найти частное от деления нацело N на K, а также остаток от этого деления.
            /*
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число K: ");
            int k = int.Parse(Console.ReadLine());
            int count = 0;
            if (n >= k)
            {
                while (n >= k)
                {
                    n -= k;
                    count++;
                }
            }
            else
            {
                n = 0;
            }
            Console.WriteLine($"частное: {count} остаток от деления: {n}");
            */
            //While4◦. Дано целое число N (>0). Если оно является степенью числа
            //   то вывести TRUE, если не является  вывести FALSE.
            /*
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            double oldNum = n;
            while (oldNum >= 3)
            {
                oldNum /= 3;
            }
            Console.WriteLine(oldNum == 1);
            Console.WriteLine(oldNum);
            */
            // While5. Дано целое число N (> 0), являющееся некоторой степенью числа 2: N = 2K.
            // Найти целое число K — показатель этой степени.
            /*
            int n = 64, oldNum = n, degree = 0;
            while (n >= 2) 
            {
                n /= 2;
                degree++;
            }
            Console.WriteLine($"{oldNum} = 2^{degree}");
            */
            // While7◦. Дано целое число N (>0). Найти наименьшее целое положительное число K, квадрат которого
            // превосходит N: K2 > N. Функцию извлечения квадратного корня не использовать.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int pow = 1, k = 0;
            while (n >= pow)
            {
                k++;
                pow = k*k;
                Console.WriteLine($" К: {k} \t {pow} ");
            }
            Console.WriteLine($"наименьшее число К: {k}");
            */
            // While8. Дано целое число N (> 0). Найти наибольшее целое число K, квадрат которого не превосходит
            // N: K2 ≤ N. Функцию извлечения квадратного корня не использовать.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int pow = 1, k = 0;
            while (pow <= n)
            {
                k++;
                pow = k*k;
                Console.WriteLine($" К: {k} \t {pow} ");
            }
            Console.WriteLine($"наименьшее число К: {k-1}");
            */
            // While9. Дано целое число N (>1). Найти наименьшее целое число K, при котором выполняется неравенство 3K > N.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int pow3 = 1, k = 0;
            while (n > pow3)
            {
                k++;
                pow3 = k * k * k;
                Console.WriteLine($" К: {k} \t {pow3} ");
            }
            Console.WriteLine($"наименьшее число К: {k}");
            */
            // While10. Дано целое число N (>1). Найти наибольшее целое число K, при котором выполняется неравенство 3K < N.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int pow3 = 1, k = 0;
            while (n > pow3)
            {
                pow3 = k * k * k;
                k++;
                Console.WriteLine($" К: {k} \t {pow3} ");
            }
            Console.WriteLine($"наименьшее число К: {k-1}");
            */
            // While11◦. Дано целое число N (> 1). Вывести наименьшее из целых чисел K, для которых 
            //     сумма 1 + 2 + ... + K будет больше или равна N, и саму эту сумму.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, k = 0;
            while (n >= sum)
            {
                k++;
                sum = k + sum;
                Console.WriteLine($" К: {k} \t {sum} ");               
            }
            Console.WriteLine($"наименьшее число К: {k}  сумма чисел (от 1 до К): {sum} ");
           */
            // While12◦. Дано целое число N (> 1). Вывести наибольшее из целых чисел K, для которых 
            //     сумма 1 + 2 + ... + K будет меньше или равна N, и саму эту сумму.
            /*
             Console.WriteLine("Введите число: ");
             int n = int.Parse(Console.ReadLine());
             int sum = 0, k = 0;
             while (n >= sum+k)
             {
                 k++;
                 sum = k + sum;
                 Console.Write($" К: {k}   ");
                 Console.WriteLine($"сумма: {sum}");
             }
             Console.WriteLine($"наибольшее число К: {k}  ");
             Console.WriteLine($"сумма чисел (от 1 до К): {sum }");
             */
            // While17. Дано целое число N (>0). Используя операции деления нацело и взятия остатка от деления,
            //     вывести все его цифры, начиная с самой правой (разряда единиц).
            /*
             Console.WriteLine("Введите число: ");
             int n = int.Parse(Console.ReadLine());
             int oldNum = n;
             while (n > 0)
             {
                 oldNum = n % 10;
                 Console.Write($"{oldNum}");
                 n = n / 10;
             }
              */
            // While18. Дано целое число N (>0). Используя операции деления нацело и взятия остатка от деления,
            //     найти количество и сумму его цифр.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int oldNum = n, count = 0, sum = 0;
            while (n > 0)
            {
                count++;
                oldNum = n % 10;
                sum += oldNum;
                n = n / 10;
                Console.WriteLine($"{count} Сумма: {sum}");     
            }
            */
            // While19. Дано целое число N (> 0). Используя операции деления нацело и взятия остатка от деления,
            //     найти число, полученное при прочтении числа N справа налево.
            ///*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int oldNum = n;
            while (n > 0)
            {
                oldNum = n % 10;
                Console.Write($"{oldNum}");
                n = n / 10;
            }
            //*/
            // While20. Дано целое число N (>0). С помощью операций деления нацело и взятия остатка от деления определить, 
            //     имеется ли в записи числа N цифра «2». Если имеется, то вывести TRUE, если нет  вывести FALSE.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int oldNum = n, checkNum = 0;
            while (n > 0)
            {
                oldNum = n % 10;
                n = n / 10;
                if (oldNum == 2) checkNum = 2;
            }
            Console.WriteLine(checkNum == 2);
            */
            // While21. Дано целое число N (>0). С помощью операций деления нацело и взятия остатка от деления определить,
            //     имеются ли в записи числа N нечетные цифры. Если имеются, то вывести TRUE, если нет вывести FALSE.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int oldNum = n, checkNum = 0;
            while (n > 0)
            {
                oldNum = n % 10;
                n = n / 10;
                if (oldNum %2==0) checkNum = 2;
            }
            Console.WriteLine(checkNum == 2);
            */
            // While24. Дано целое число N (> 1). Последовательность чисел Фибоначчи FK определяется следующим образом:
            //     F1 =1, F2 =1, FK =FK−2 +FK−1, K =3,4,.... Проверить, является ли число N числом Фибоначчи. 
            //     Если является, то вывести TRUE, если нет — вывести FALSE.
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, tempNum = 0;
            while (n > b)
            {
                tempNum = b;
                b = a + b;
                a = tempNum;
            }
            Console.WriteLine(n == b);
            */
            // While25. Дано целое число N (>1). Найти первое число Фибоначчи, большее N. 
            //     (определение чисел Фибоначчи дано в задании While24).
            /*
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, tempNum = 0;
            while (n >= b)
            {
                tempNum = b;
                b = a + b;
                a = tempNum;
            }
           Console.WriteLine($"первое число Фибаначчи больше числа {n} будет: {b}");
           */

            // While26. Дано целое число N (>1), являющееся числом Фибоначчи: 
            //     N = FK (определение чисел Фибоначчи дано в задании While24). 
            //     Найти целые числа FK−1 и FK+1 — предыдущее и последующее числа Фибоначчи.
            /*
            int n = 55, a = 0, b = 1, tempNum = 0;
            while (n+1 > b)
            {
                tempNum = b;
                b = a + b;
                a = tempNum;
            }
            Console.WriteLine($"Фибаначчи -: {b-n} заданное число Ф: {n}  Фибаначчи +: {b}");
            */
            // While27. Дано целое число N (>1), являющееся числом Фибоначчи: N = FK(определение чисел Фибоначчи дано 
            // в задании While24). Найти целое число K — порядковый номер числа Фибоначчи N.
            /*
            int n = 55, k = 2, a = 0, b = 1, tempNum = 0;
            Console.WriteLine($"1 число Фибаначчи : {a} \n2 число Фибаначчи : {b} ");
            while (n > b)
            {
                k++;
                tempNum = b;
                b = a + b;
                a = tempNum;
                Console.WriteLine($"{k} число Фибаначчи : {b} ");
            }
            */
            
        }
    }
}