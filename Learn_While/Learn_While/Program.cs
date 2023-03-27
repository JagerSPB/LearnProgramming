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
            //While4◦. Дано целое число N (>0). Если оно является степенью числа 3,
            //то вывести TRUE, если не является  вывести FALSE.
            /*
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            while (n%3 == 0)
            {
                Console.WriteLine($"{true}");
                break;
            }
            if (n%3 != 0) Console.WriteLine($"{false}");
            */
            /*

           Console.Write("Введите число N: ");
           int n = int.Parse(Console.ReadLine());
           Console.WriteLine(n % 3 == 0 ? "True" : "False");

           */
            // While5. Дано целое число N (> 0), являющееся некоторой степенью числа 2: N = 2K.
            // Найти целое число K — показатель этой степени.
            //     Console.Write("Введите число N: ");
            //     int n = int.Parse(Console.ReadLine());
            //     int count = n;
            //     while (count == 1)
            //     {
            //         n -= 2;
            //         count--;
            //     }
            //
            //     Console.Write(count);


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
                Console.Write($" К: {k}   ");
                Console.WriteLine($"сумма: {sum}");
                
            }
            Console.WriteLine($"наименьшее число К: {k}   ");
            Console.WriteLine($"сумма чисел (от 1 до К): {sum}");
           */
            // While12◦. Дано целое число N (> 1). Вывести наибольшее из целых чисел K, для которых 
            //     сумма 1 + 2 + ... + K будет меньше или равна N, и саму эту сумму.
          // /*
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
            //*/
        }
    }
}