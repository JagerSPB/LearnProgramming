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

            Proc3Mean(x, y, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое X Y  [{aMean}], среднее геометрическое X Y [{gMean}]");
            Proc3Mean(a, b, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое A B  [{aMean}], среднее геометрическое A B [{gMean}]");
            Proc3Mean(a, c, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое A C  [{aMean}], среднее геометрическое A C [{gMean}]");
            Proc3Mean(a, d, out aMean, out gMean);
            Console.WriteLine($"среднее арифметическое A D [{aMean}], среднее геометрическое A D [{gMean}]");
            */
            /*
            Console.Write("Введите размер стороны треугольника: ");
            double a = double.Parse(Console.ReadLine());
            double p, s, b = 5.8, c = 8, d = 5.3;
            Proc4TrianglePS(a, out p, out s);
            Console.WriteLine($"Треугольник А Периметр: {p}  Площадь: {s} ");
            Proc4TrianglePS(b, out p, out s);
            Console.WriteLine($"Треугольник B Периметр: {p}  Площадь: {s} ");
            Proc4TrianglePS(c, out p, out s);
            Console.WriteLine($"Треугольник C Периметр: {p}  Площадь: {s} ");
            Proc4TrianglePS(d, out p, out s);
            Console.WriteLine($"Треугольник D Периметр: {p}  Площадь: {s} ");
            */
            // Proc6. 
            /*
            Console.Write("Введите число: ");
            int k = Int32.Parse(Console.ReadLine()), c, s;
            int digit1 = 1234, digit2 = 239873, digit3 = 3451234, digit4 = 235, digit5 = 2335;
            Proc6DigitCountSum(k, out c, out s);
            Console.WriteLine($"кол-во {c}, сумма: {s}");
            Proc6DigitCountSum(digit1, out c, out s);
            Console.WriteLine($"кол-во {c}, сумма: {s}");
            Proc6DigitCountSum(digit2, out c, out s);
            Console.WriteLine($"кол-во {c}, сумма: {s}");
            Proc6DigitCountSum(digit3, out c, out s);
            Console.WriteLine($"кол-во {c}, сумма: {s}");
            Proc6DigitCountSum(digit4, out c, out s);
            Console.WriteLine($"кол-во {c}, сумма: {s}");
            Proc6DigitCountSum(digit5, out c, out s);
            Console.WriteLine($"кол-во {c}, сумма: {s}");
            */
            //Proc7.
            /*
            Console.Write("Введите число: ");
            int k = Int32.Parse(Console.ReadLine()),
                digit1 = 23456,
                digit2 = 98765,
                digit3 = 123432,
                digit4 = 54323456,
                digit5 = 34542;
            int result = Proc7InvertDigits(k);
            Console.WriteLine(result);
            int result1 = Proc7InvertDigits(digit1);
            Console.WriteLine(result1);
            int result2 = Proc7InvertDigits(digit2);
            Console.WriteLine(result2);
            //*/
            //Proc8
            // Console.Write("Введите число: ");
            // int x = int.Parse(Console.ReadLine());
            double a = 1000, b = 2000, c = 3;
            Proc13SortDec3(ref a, ref b, ref c);
            Console.WriteLine($"{a}  {b}  {c}");
        }


        /// <summary>
        /// Proc2.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        static void Proc2PowerA234(double a, out double b, out double c, out double d)
        {
            b = Math.Pow(a, 2);
            c = Math.Pow(a, 3);
            d = Math.Pow(a, 4);
        }


        /// <summary>
        /// Proc3.Описать процедуру Mean(X, Y, AMean, GMean), вычисляющую среднее арифметическое AMean = (X+Y)/2 
        /// и среднее геометрическое GMean = √X·Y двух положительных чисел X и Y (X и Y — входные, 
        /// AMean и GMean — выходные параметры вещественного типа). С помощью этой процедуры найти среднее арифметическое
        /// и среднее геометрическое для пар (A, B), (A, C), (A, D), если даны A, B, C, D.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="aMean"></param>
        /// <param name="gMean"></param>
        static void Proc3Mean(double value1, double value2, out double aMean, out double gMean)
        {
            aMean = (value1 + value2) / 2;
            gMean = Math.Sqrt(value1 * value2);
        }


        /// <summary>
        /// Proc4. Описать процедуру TrianglePS(a, P, S), вычисляющую по стороне a равностороннего треугольника его 
        /// периметр P = 3·a и площадь S = a2·√3/4 (a — входной, P и S — выходные параметры; все
        /// параметры являются ве- щественными). С помощью этой процедуры найти периметры и площади трех равносторонних 
        /// треугольников с данными сторонами.
        /// </summary>
        /// <param name="a"></param>
        static void Proc4TrianglePS(double a, out double p, out double s)
        {
            p = a * 3;
            s = (a * a * Math.Sqrt(3)) / 4;
        }


        /// <summary>
        /// Proc6.Описать процедуру DigitCountSum(K, C, S), находящую количество C цифр целого положительного числа K, 
        /// а также их сумму S (K — входной, C и S — выходные параметры целого типа). С помощью этой процедуры найти 
        /// количество и сумму цифр для каждого из пяти данных целых чисел.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="c"></param>
        /// <param name="s"></param>
        static void Proc6DigitCountSum(int k, out int c, out int s)
        {
            c = 0;
            s = 0;
            while (k > 0)
            {
                int digit = k % 10;
                c++;
                s += digit;
                k /= 10;
            }
        }

        /// <summary>
        ///  Proc7. Описать процедуру InvertDigits(K), меняющую порядок следования цифр целого положительного числа K на 
        /// обратный (K — параметр целого типа, являющийся одновременно входным и выходным).С помощью этой процедуры
        /// поменять порядок следования цифр на обратный для каждого из пяти данных целых чисел.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Proc7InvertDigits(int k)
        {
            int invers = 0;
            while (k > 0)
            {
                int digit = k % 10;
                invers *= 10;
                invers += digit;
                k /= 10;
            }

            return invers;
        }

        /// <summary>
        /// Proc8◦. Описать процедуру AddRightDigit(D, K), добавляющую к целому по- ложительному числу K справа цифру D
        /// (D — входной параметр целого типа, лежащий в диапазоне 0–9, K — параметр целого типа, являющийся
        /// одновременно входным и выходным). С помощью этой процедуры после- довательно добавить к данному числу
        /// K справа данные цифры D1 и D2, выводя результат каждого добавления.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Proc8AddRightDigit(int d, int k) => k * 10 + d;

        static int Proc8AddRightDigitV2(int d, int k) => Convert.ToInt32(k + d.ToString());

        /// <summary>
        /// Proc9. Описать процедуру AddLeftDigit(D, K), добавляющую к целому по- ложительному числу K слева цифру D
        /// (D — входной параметр целого типа, лежащий в диапазоне 1–9, K — параметр целого типа,
        /// являющийся одновременно входным и выходным).
        /// </summary>
        /// <param name="d"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Proc9AddRightDigit(int d, int k) => Convert.ToInt32(d + k.ToString());

        /// <summary>
        /// Proc10. Описать процедуру Swap(X, Y), меняющую содержимое перемен- ных X и Y
        /// (X и Y — вещественные параметры, являющиеся одновременно входными и выходными).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Proc10Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }

        /// <summary>
        /// Proc11. Описать процедуру Minmax(X, Y), записывающую в переменную X минимальное из значений X и Y, а в
        /// переменную Y — максимальное из этих значений (X и Y — вещественные параметры, являющиеся одновременно
        /// входными и выходными).
        /// </summary>
        /// <param name="???"></param>
        /// <param name="???"></param>
        static void Proc11Minmax(ref double x, ref double y)
        {
            double min = x;
            if (y < min)
            {
                x = y;
                y = min;
            }
        }

        /// <summary>
        /// Proc12. Описать процедуру SortInc3(A, B, C), меняющую содержимое пере- менных A, B, C таким образом, чтобы
        /// ихзначения оказались упорядоченными по возрастанию (A, B, C — вещественные параметры, являющиеся
        /// одновременно входными и выходными).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void Proc12SortInc3(ref double a, ref double b, ref double c)
        {
            if (a > b) (a, b) = (b, a);
            if (a > c) (a, c) = (c, a);
            if (b > c) (b, c) = (c, b);
        }
        /// <summary>
        /// Proc13. Описать процедуру SortDec3(A, B, C), меняющую содержимое переменных A, B, C таким образом,
        /// чтобы их значения оказались упорядоченными по убыванию
        /// (A, B, C — вещественные параметры, являющиеся одновременно входными и выходными).
        /// </summary>
        static void Proc13SortDec3(ref double a, ref double b, ref double c)
        {
            if (a < b) (a, b) = (b, a);
            if (a < c) (a, c) = (c, a);
            if (b < c) (b, c) = (c, b);
        }
    }
}