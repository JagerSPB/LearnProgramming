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
            /*
             static void Mean(double x, double y)
             {
                 double aMean = (x + y) / 2;
                 double gMean = Math.Sqrt(x * y);
                 Console.WriteLine($"среднее арифметическое [{aMean}], среднее геометрическое [{gMean}]");
             }
 
             Console.Write("Введите число X: ");
             double x = double.Parse(Console.ReadLine());
             Console.Write("Введите число Y: ");
             double y = double.Parse(Console.ReadLine());
             double a = 4, b = 5, c = 6.7, d = 8.4;
 
             Mean(x, y);
             Mean(a, b);
             Mean(a, c);
             Mean(a, d);
             */
            // Proc4◦. Описать процедуру TrianglePS(a, P, S), вычисляющую по стороне a равностороннего треугольника 
            // его периметр P = 3·a и площадь S = a2·√3/4 (a — входной, P и S — выходные параметры; все параметры 
            // являются вещественными). С помощью этой процедуры найти периметры и площади трех равносторонних 
            // треугольников с данными сторонами.
            /*
            static void TrianglePS(double a)
            {
                double p = a * 3;
                double s = (a * a * Math.Sqrt(3)) / 4;
                Console.WriteLine($"Сторона: {a}  Площадь: {s}");
            }
            
            Console.Write("Введите размер стороны треугольника: ");
            double a = double.Parse(Console.ReadLine());
            double b = 5.8, c = 8, d = 5.3;
            TrianglePS(a);
            TrianglePS(b);
            TrianglePS(c);
            TrianglePS(d);
            */

            //
            // Console.Write("Введите число: ");
            // int num = Int32.Parse(Console.ReadLine());
            // int pow = 5;
            // int degree = MathPow(num, pow);
            // Console.WriteLine(degree);

            //Proc2
            /*
             Console.WriteLine("Ведите число: ");
             double a = double.Parse(Console.ReadLine()), b, c, d;
             Proc2PowerA234(a, out b, out c, out d);
             Console.WriteLine($" {a}^2 = {b}, {a}^3 = {c}, {a}^4 = {d}");
             */
            //Proc3
            /*
            Console.Write("Введите число X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double y = double.Parse(Console.ReadLine());
            double aMean, gMean, a = 4, b = 5, c = 6.7, d = 8.4;

            Mean(x, y, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое X Y  [{aMean}], среднее геометрическое X Y [{gMean}]");
            Mean(a, b, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое A B  [{aMean}], среднее геометрическое A B [{gMean}]");
            Mean(a, c, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое A C  [{aMean}], среднее геометрическое A C [{gMean}]");
            Mean(a, d, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое A D [{aMean}], среднее геометрическое A D [{gMean}]");
            */
        }

        /// <summary>
        /// Proc2.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        // static void Proc2PowerA234(double a, out double b, out double c, out double d)
        // {
        //     b = Math.Pow(a, 2);
        //     c = Math.Pow(a, 3);
        //     d = Math.Pow(a, 4);
        // }
        static void Mean(double value1, double value2, out double aMean, out double gMean)
        {
            aMean = (value1 + value2) / 2;
            gMean = Math.Sqrt(value1 * value2);
        }
    }
}