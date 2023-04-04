using System;

namespace Method
{
    internal static class Program
    {
        static void Main()
        {
            // int sum = Sum(a,b,c,d);
            // int pr = Product(a,b,c);
            // int srArif = SAR(a,b,c,d,e);
            //=============================================
            /*
            static int Sum(int value1, int value2, int value3, int value4)
            {
                return (value1 + value2 + value3 + value4);
            }

            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите число D: ");
            int d = int.Parse(Console.ReadLine());

            int sum = Sum(a, b, c, d);
            Console.WriteLine(sum);
            */
            /*
            static int Product(int value1, int value2, int value3)
            {
                return (value1 * value2 * value3);
            }
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            int c = int.Parse(Console.ReadLine());

            int pr = Product(a, b, c);
            Console.WriteLine(pr);
            */
            /*
            static int SAR(int value1, int value2, int value3, int value4)
            {
                return (value1 + value2 + value3 + value4)/4;
            }

            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите число D: ");
            int d = int.Parse(Console.ReadLine());

            int srArif = SAR(a, b, c, d);
            Console.WriteLine(srArif);
            */
            // Описать процедуру PowerA3(A, B), вычисляющую третью степень числа A и возвращающую ее в переменной 
            // B (A — входной, B — выходной параметр; оба параметра являются вещественными).
            // С помощью этой процедуры найти третьи степени пяти данных чисел.
            /*
            static double PowerA3(double value1)
            {
                return (value1 * value1 * value1);
            }
            
            Console.WriteLine("Ведите количество подсчитываемых чисел: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите число: ");
                double a = double.Parse(Console.ReadLine());
                double b = PowerA3(a);
                Console.WriteLine($"число {a} ^ 3 = {b}");
            }
            */
            // Proc2. Описать процедуру PowerA234(A, B, C, D), вычисляющую вторую, третью и четвертую степень числа A 
            //     и возвращающую эти степени соответственно в переменных B, C и D (A — входной, B, C, D — выходные
            //     параметры; все параметры являются вещественными). С помощью этой процедуры найти вторую, 
            //     третью и четвертую степень пяти данных чисел.
            /*
            static void PowerA234(double value1)
            {
                double pow2 = value1 * value1;
                double pow3 = value1 * value1 * value1;
                double pow4 = value1 * value1 * value1 * value1;
                Console.WriteLine($"Квадрат числа [{pow2}], Куб числа [{pow3}], четвертая степень числа [{pow4}]");
            }
            
            Console.WriteLine("Ведите количество подсчитываемых чисел: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Введите {i} число: ");
                double a = double.Parse(Console.ReadLine());
                PowerA234(a);
            }
            */
            // Proc3. Описать процедуру Mean(X, Y, AMean, GMean), вычисляющую среднее арифметическое 
            //     AMean = (X+Y)/2 и среднее геометрическое GMean = √X·Y двух положительных чисел X и Y (X и Y — входные, 
            //     AMean и GMean — выходные параметры вещественного типа). С помощью этой процедуры найти среднее
            //     арифметическое и среднее геометрическое для пар (A, B), (A, C), (A, D), если даны A, B, C, D
            
        }
    }
}