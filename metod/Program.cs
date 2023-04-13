using System;

namespace Method
{
    internal static class Program
    {
        static void Main()
        {
            double a = 5, b=2;

            Console.WriteLine(Proc37Power1(a,b));
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
        /// Proc8◦. Описать процедуру AddRightDigit(D, K), добавляющую к целому положительному числу K справа цифру D
        /// (D — входной параметр целого типа, лежащий в диапазоне 0–9, K — параметр целого типа, являющийся
        /// одновременно входным и выходным). С помощью этой процедуры последовательно добавить к данному числу
        /// K справа данные цифры D1 и D2, выводя результат каждого добавления.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Proc8AddRightDigit(int d, int k) => k * 10 + d;

        static int Proc8AddRightDigitV2(int d, int k) => Convert.ToInt32(k + d.ToString());

        /// <summary>
        /// Proc9. Описать процедуру AddLeftDigit(D, K), добавляющую к целому положительному числу K слева цифру D
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
        static void Proc10Swap(ref double x, ref double y) => (x, y) = (y, x);

        /// <summary>
        /// Proc11. Описать процедуру Minmax(X, Y), записывающую в переменную X минимальное из значений X и Y, а в
        /// переменную Y — максимальное из этих значений (X и Y — вещественные параметры, являющиеся одновременно
        /// входными и выходными).
        /// </summary>
        /// <param name="???"></param>
        /// <param name="???"></param>
        static void Proc11Minmax(ref double x, ref double y)
        {
            if (y < x) (y, x) = (x, y);
        }
        //V2
        //static void Proc11Minmax(ref double x, ref double y) => (x, y) = (y < x) ? (y, x) : (x, y);

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

        /// <summary>
        /// Proc14. Описать процедуру ShiftRight3(A, B, C), выполняющую правый циклический сдвиг:
        /// значение A переходит в B, значение B — в C, значение C — в A (A, B, C — вещественные параметры,
        /// являющиеся одновременно входными и выходными). 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void Proc14ShiftRight3(ref double a, ref double b, ref double c) => (a, b, c) = (b, c, a);

        /// <summary>
        ///Proc15. Описать процедуру ShiftLeft3(A, B, C), выполняющую левый циклический сдвиг: значение A переходит
        /// в C, значение C — в B, значение B — в A (A, B, C — вещественные параметры,
        /// являющиеся одновременно входными и выходными).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void Proc15ShiftLeft3(ref double a, ref double b, ref double c) => (a, b, c) = (c, a, b);

        /// <summary>
        /// Proc16. Описать функцию Sign(X) целого типа, возвращающую для вещественного числа X следующие
        /// значения:−1, еслиX <0; 0, еслиX =0; 1, еслиX >0.
        /// </summary>
        static double Proc16Sign(double x)
        {
            if (x < 0) x = -1;
            if (x == 0) x = 0;
            if (x > 0) x = 1;
            return x;
        }

        /// <summary>
        /// Proc18. Описать функцию CircleS(R) вещественного типа, находящую площадь круга радиуса R (R — вещественное).
        /// С помощью этой функции найти площади трех кругов с данными радиусами.
        ///   Площадь круга радиуса R вычисляется по формуле S = π·R2. В качестве значения π использовать 3.14.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        static double Proc18CircleS(double r) => 3.14 * r * r;

        /// <summary>
        /// Proc19. Описать функцию RingS(R1, R2) вещественного типа, находящую площадь кольца, заключенного между
        /// двумя окружностями с общим центром и радиусами R1 и R2 (R1 и R2 — вещественные, R1 > R2).
        /// С ее помощью найти площади трех колец, для которых даны внешние и внутренние ра- диусы.
        /// Воспользоваться формулой площади круга радиуса R: S = π·R2. В качестве значения π использовать 3.14.
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        static double Proc19RingS(double r1, double r2) => (3.14 * r2 * r2) - (3.14 * r1 * r1);

        /// <summary>
        /// Proc20. Описать функцию TriangleP(a, h), находящую периметр равнобедренного треугольника по его основанию
        /// a и высоте h, проведенной к основанию (a и h — вещественные). С помощью этой функции найти периметры
        /// трех треугольников, для которых даны основания и высоты.
        /// Для нахождения боковой стороны b треугольника использовать теорему Пифагора: b2 = (a/2)2 + h2.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        static double Proc20TriangleP(double a, double h)
        {
            double result = 2 * a + 2 * Math.Sqrt(h * h + (a / 2) * (a / 2));
            return result;
        }
        //v2 static double Proc20TriangleP(double a, double h) => 2 * a + 2 * Math.Sqrt(h * h + (a / 2) * (a / 2));

        /// <summary>
        /// Proc21◦. Описать функцию SumRange(A, B) целого типа, находящую сумму всех целых чисел от A до B включительно
        /// (A и B — целые). Если A > B,то функция возвращает 0. С помощью этой функции найти суммы чиселот A до B
        /// и от B до C, если даны числа A, B, C.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Proc21SumRange(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }

        /// <summary>
        /// Proc22. Описать функцию Calc(A, B, Op) вещественного типа, выполняющуюнад ненулевыми вещественными числами
        /// A и B одну из арифметических операций и возвращающую ее результат Вид операции определяется
        /// целым параметром Op: 1 — вычитание, 2 — умножение, 3 — деление, остальные значения — сложение.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        static double Proc22Calc(double a, double b, int operation)
        {
            double result = 0;
            if (operation == 1) result = a - b;
            else if (operation == 2) result = a * b;
            else if (operation == 3) result = a / b;
            else result = a + b;
            return result;
        }

        /// <summary>
        /// Proc23. Описать функцию Quarter(x, y) целого типа, определяющую номер координатной четверти,
        /// в которой находится точка с ненулевыми веще- ственными координатами (x, y).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Proc23Quarter(int x, int y)
        {
            int result = 0;
            if (x > 0 && y > 0) result = 1;
            else if (x > 0 && y < 0) result = 2;
            else if (x < 0 && y < 0) result = 3;
            else if (x < 0 && y > 0) result = 4;
            return result;
        }

        /// <summary>
        /// Proc24. Описать функцию Even(K) логического типа, возвращающую TRUE, если целый параметр K является четным,
        /// и FALSE в противном случае. С ее помощью найти количество четных чисел в наборе из 10 целых чисел.
        /// </summary>
        /// <returns></returns>
        static bool Proc24Even(int k) => k % 2 == 0;

        /// <summary>
        /// Proc25◦. Описать функцию IsSquare(K) логического типа, возвращающую TRUE, если целый параметр K (>0)
        /// является квадратом некоторого целого числа, и FALSE в противном случае.
        /// С ее помощью найти количество квадратов в наборе из 10 целых положительных чисел.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        static bool Proc25IsSquare(int k)
        {
            double square = Math.Sqrt(k);
            return square == Math.Floor(square);
        }

        /// <summary>
        /// Proc26. Описать функцию IsPower5(K) логического типа, возвращающую TRUE, если целый параметр K (> 0)
        /// является степенью числа 5, и FALSE в противном случае.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        static bool Proc26IsPower5(int k)
        {
            while (k % 5 == 0)
            {
                k /= 5;
            }

            return k == 1;
        }

        /// <summary>
        /// Proc27. Описать функцию IsPowerN(K, N) логического типа, возвращающую TRUE, если целый параметр K (>0)
        /// является степенью числа N (>1), и FALSE в противном случае. 
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        static bool Proc27IsPowerN(int k, int n)
        {
            while (k % n == 0)
            {
                k /= n;
            }

            return k == 1;
        }

        /// <summary>
        /// Proc29. Описать функцию DigitCount(K) целого типа, находящую количество цифр целого положительного числа K.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Proc29DigitCount(int k)
        {
            int result = 0;
            for (int i = 1; i <= k; i++)
            {
                k = k / 10;
                result++;
            }

            return result;
        }

        /// <summary>
        /// Proc30. Описать функцию DigitN(K, N ) целого типа, возвращающую N -ю цифру целого положительного числа K
        /// (цифры в числе нумеруются справа налево). Если количество цифр в числе K меньше N, то функция возвращает −1.
        /// </summary>
        /// <returns></returns>
        static int Proc30DigitN(int k, int n)
        {
            for (int i = 1; i < n; i++)
            {
                k = k / 10;
            }

            k = k % 10;
            if (k == 0) return -1;
            return k;
        }
        /// <summary>
        /// Proc31. Описать функцию IsPalindrom(K), возвращающую TRUE, если целый параметр K (> 0) является палиндромом
        /// (то есть его запись читается одинаково слева направо и справа налево), и FALSE в противном случае.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        // static bool Proc31IsPalindrom(int k)
        // {
        //     хз как это делать )
        // }

        /// <summary>
        /// Proc32. Описать функцию DegToRad(D) вещественного типа, находящую величину угла в радианах, если дана его
        /// величина D в градусах (D — вещественное число, 0 < D < 360). Воспользоваться следующим соотношением:
        /// 180◦ = π радианов. В качестве значения π использовать 3.14.
        /// </summary>
        /// <returns></returns>
        static double Proc32DegToRad(double d) => d * 3.14 / 180;

        /// <summary>
        /// Proc33. Описать функцию RadToDeg(R) вещественного типа, находящую ве- личину угла в градусах, если дана его
        /// величина R в радианах (R — вещественное число, 0 < R < 2·π). Воспользоваться следующим соотношением:
        /// 180◦ = π радианов. В качестве значения π использовать 3.14
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static double Proc33RadToDeg(double r) => r * 180 / 3.14;

        /// <summary>
        /// Proc34. Описать функцию Fact(N) вещественного типа, вычисляющую значение факториала N! = 1·2·...·N
        /// (N > 0 — параметр целого типа; вещественное возвращаемое значение используется для того, чтобы избежать
        /// целочисленного переполнения при больших значениях N). С помощью этой функции найти факториалы пяти данных
        /// целых чисел.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static double Proc34Fact(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Proc35. Описать функцию Fact2(N) вещественного типа, вычисляющую двой- ной факториал: N !! = 1·3·5·. . .·N,
        /// если N — нечетное; N !! = 2·4·6·. . .·N, если N — четное (N > 0 — параметр целого типа;
        /// вещественное возвращаемое значение используется для того, чтобы избежать целочисленного переполнения при
        /// больших значениях N). 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static double Proc35Fact2(int n)
        {
            double result = 1;
            if (n % 2 == 0)
                for (int i = 2; i <= n; i = i + 2)
                {
                    result *= i;
                }
            else if (n % 2 != 0)
                for (int i = 1; i <= n; i = i + 2)
                {
                    result *= i;
                }

            return result;
        }

        /// <summary>
        /// Proc36. Описать функцию Fib(N) целого типа, вычисляющую N-й элемент последовательности чисел Фибоначчи FK,
        /// которая описывается следующими формулами:F1 =1, F2 =1, FK =FK−2 +FK−1, K =3,4,....
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Proc36Fib(int n)
        {
            int num1 = 0, num2 = 1, num3 = 0;
            for (int i = 3; i <= n; i++)
            {
                num3 = num1 + num2;
                (num1, num2) = (num2, num3);
            }
            return num3;
        }

        /// <summary>
        /// Proc37. Описать функцию Power1(A, B) вещественного типа, находящую величину AB по формуле AB = exp(B·ln(A))
        /// (параметры A и B — вещественные). В случае нулевого или отрицательного параметра A функция возвращает 0.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Proc37Power1(double a, double b) => Math.Exp(b * Math.Log(a));
    }
}