using System;

namespace Semen
{
    internal class Program // ООП
    {
        public static void Main()
        {
            // Begin 1 Дана сторона квадрата a. Найти его периметр P = 4·a.
            /*
            Console.Write("Введите размер стороны квадрата: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр: {a * 4}");
            */
            // Begin 2 Дана сторона квадрата a. Найти его площадь S = a2.
            /*
            Console.Write("Введите размер стороны квадрата: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сторона квадрата: {a * a}");
            */
            // Begin 3 Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).
            /*      
            Console.Write("Введите сторону А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону Б: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь прямоугольника: {a * b} \nПериметр прямоугольника: {2 * (a + b)}");
             */
            // Begin 4 Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.
            /*
            Console.Write("Введите диаметр окружности: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"Длина окружности: {3.14 * d}");
            */
            // Begin 5 Дана длина ребра куба a. Найти объем куба V = a3 и площадь его поверхности S = 6·a2.
            // Console.Write("Введите длинну ребра куба: ");
            // int a = int.Parse(Console.ReadLine());
            // Console.WriteLine($"объём куба: {a * a * a}, а площадь его поверхности: {6 * (a * a)}");
            // Begin 6  Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти
            //его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).        
            /*
            Console.Write("Введите сторону a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"объём: {a * b * c}, Площадь поверхности: {2 * (a * b + b * c + a * c)}");
            */
            // Begin 7  Найти длину окружности L и площадь круга S заданного радиуса R: L = 2·π·R, S = π·R2.
            /*
            Console.Write("Задайте радиус: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Длина окружности: {2 * 3.14 * r}, Площадь круга: {3.14 * (r * r)}");
            */
            // Begin 8 Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.
            /*
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число Б: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое: {(a + b) / 2}");
            */
            // Begin 9 Даны два неотрицательных числа a и b. Найти их среднее геометрическое,
            // то есть квадратный корень из их произведения: √a·b.     
            /*     
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число Б: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее геометрическое: {Math.Sqrt(a * b)}");
            */
            // Begin 10 Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.
            /*      
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число Б: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write($"Сумма квадратов:{a * a + b * b},Разность:{a * a - b * b}, произведение {(a * a) * (b * b)}");
            Console.WriteLine($" и частное: {((a * a) / (b * b))}");
            */
            // Begin 11 Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей
            /* 
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число Б: ");
            int b = int.Parse(Console.ReadLine());
            int x = 0;
            Console.Write($"Сумма:{(x + a) + (x + b)},Разность:{(x + a) - (x + b)}, произведение {(x + a) * (x + b)}");
            Console.WriteLine($" и частное: {(x + a) / (x + b)}");
            */
            // Begin 12 Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр
            /*
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число Б: ");
            int b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Гипотенуза треугольника:{c}, периметр {a + b + c}");
            */
            //Begin13. Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2).
            //Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого 
            //равен R1, а внутренний радиус равен R2: S1 = π·(R1)2, S2 = π·(R2)2, S3 = S1 − S2. 
            //В качестве значения π использовать 3.14.
            /*
            Console.Write("Введите число R1: ");
            int r1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число R2: ");
            int r2 = int.Parse(Console.ReadLine());
            double s1 = 3.14 * (r1) * 2;
            double s2 = 3.14 * (r2) * 2;
            double s3 = s1 - s2;
            if (r1 > r2) Console.WriteLine($"Площадь круга R1:{s1}, Площадь круга R2 {s2}, площадь кольца: {s3}");
            else
              Console.WriteLine("error");
            */
            // Begin14◦. Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью, 
            // учитывая, что L = 2·π·R, S = π·R2. В качестве значения π использовать 3.14.
            /*      
            Console.Write("Введите число L: ");
            int l = int.Parse(Console.ReadLine());
            double r = l / (2 * 3.14);
            double s = 3.14 * (r * r);
            Console.WriteLine($"Радиус круга:{r = Math.Round(r, 2)}, Площадь круга S: {s = Math.Round(s, 2)}");
            */
            // Begin15◦. Дана площадь S круга. Найти его диаметр D и длину L окружности, ограничивающей этот круг, учитывая, 
            // что L = 2·π·R, S = π·R2. В качестве значения π использовать 3.14.  D=2√S/π   l = √ (S * 4π) 
            /*
            Console.Write("Введите число S: ");
            int s = int.Parse(Console.ReadLine());
            double d = 2 * Math.Sqrt(s / 3.14);
            double l = Math.Sqrt(s * (4 * 3.14));
            Console.WriteLine($"Диаметр круга:{d = Math.Round(d, 2)}, Длина окружности L: {l = Math.Round(l, 2)}");
            */
            //Begin16◦. Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: |x2 − x1|.
            /*
            Console.Write("Введите точку Х1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите точку X2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"расстояние между двумя точками: {x2 - x1}");
            */
            // Begin18◦. Даны три точки A, B, C на числовой оси. Точка C расположена между точками A и B. 
            // Найти произведение длин отрезков AC и BC.
            /*
            Console.Write("Введите точку A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите точку B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите точку C: ");
            int c = int.Parse(Console.ReadLine());
            if (c > a && c < b)
              Console.WriteLine($" произведение длин отрезков AC: {a * c}, произведение длин отрезков BC: {b * c}");
            else
              Console.WriteLine("error");
            */
            // Begin20◦. Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2) на плоскости.
            // Расстояние вычисляется по формуле q(x2 − x1)2 + (y2 − y1)2.
            /*
            Console.Write("Введите координаты Х1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координаты Y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координаты X2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите координаты Y2: ");
            int y2 = int.Parse(Console.ReadLine());
            double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (x2 - x1));
            Console.WriteLine($"расстояние между двумя точками:{Math.Round(result, 2)}");
            */
            // Begin22◦. Поменять местами содержимое переменных A и B и вывести новые
            // значения A и B.
            /*
            Console.Write("Введите значение А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int b = int.Parse(Console.ReadLine());
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine($"новое значение А: {a}, новое значение B: {b} ");
            */

            // Begin24◦. Даны переменные A, B, C. Изменить их значения, переместив содержимое A в C, C — в B,
            //  B — в A, и вывести новые значения переменных A, B, C.

            Console.Write("Введите значение А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите значение C: ");
            int c = int.Parse(Console.ReadLine());
            int temp = a;
            a = c;
            c = b;
            b = temp;
            Console.WriteLine($"новое значение А: {a}, новое значение B: {b}, новое значение C: {c}  ");

            
            
            //Begin25◦. Найти значение функции y = 3x6 − 6x2 − 7 при данном значении x.
            /*
            Console.Write("Введите значение X: ");
            int x = int.Parse(Console.ReadLine());
            double y = Math.Pow((3 * x), 6) - Math.Pow((6 * x), 2) - 7;
            Console.WriteLine($"значение функции y = {y}");
            */
            // Begin26◦. Найти значение функции y = 4(x−3)6 − 7(x−3)3 + 2 при данном
            // значении x.
            /*
            Console.Write("Введите значение X: ");
            int x = int.Parse(Console.ReadLine());
            double y = Math.Pow(4 * (x - 3), 6) - Math.Pow(7 * (x - 3), 3) + 2;
            Console.WriteLine($"значение функции y = {y}");
            */
            // Begin27◦. Дано число A. Вычислить A8, используя вспомогательную перемен-
            // ную и три операции умножения. Для этого последовательно находить A2,
            // A4, A8. Вывести все найденные степени числа A.
            /*
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            double a2 = Math.Pow(a, 2);
            double a4 = Math.Pow(a, 4);
            double a8 = Math.Pow(a, 8);
            Console.WriteLine($"значение A в степени 2 = {a2}, в степени 8 = {a4}, в степени 8 = {a8},");
            */
            // Begin28◦. Дано число A. Вычислить A15, используя две вспомогательные пере-
            // менные и пять операций умножения. Для этого последовательно находить
            // A2, A3, A5, A10, A15. Вывести все найденные степени числа A.
            /*      
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            double a2 = a * a;
            double a3 = a * a * a;
            Console.Write($"значение A в степени 2 = {a2}, в степени 3 = {a3}, в степени 5 = {a2 * a3},");
            Console.WriteLine($" в степени 10 = {(a2 * a3) * (a2 * a3)}, в степени 15 = {(a2 * a3) * (a2 * a3) * (a2 * a3)}");
            */
            // Begin29◦. Дано значение угла α в градусах (0 < α < 360). Определить значение этого же угла в радианах, 
            // учитывая, что 180◦ = π радианов. В качестве значения π использовать 3.14.
            /*
            Console.Write("Введите значение угла а: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0 && a < 360) Console.WriteLine($"значение этого угла в радианах = {Math.Round(a * 3.14 / 180, 2)}");
            else Console.WriteLine("error");
            */
            // Begin30◦. Дано значение угла α в радианах(0 < α < 2·π). Определить значение
            // этого же угла в градусах, учитывая, что 180◦ = π радианов.В качестве значения π использовать 3.14.
            /*
            Console.Write("Введите значение угла а в радианах: ");
            double a = double.Parse(Console.ReadLine());
            if (a > 0 && a < 2 * 3.14) Console.WriteLine($"значение этого угла в градусах = {Math.Round(a / 3.14 * 180, 2)}");
            else Console.WriteLine("error");
            */
            // Begin33◦. Известно, что X кг конфет стоит A рублей. Определить, сколько
            // стоит 1 кг и Y кг этих же конфет.
            /*
            Console.Write("Введите вес конфет: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость этих конфет: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Необходимый вес этих вкусных конфет: ");
            int needWeight = int.Parse(Console.ReadLine());
            Console.WriteLine($"стоимость за 1 кг: {price / weight}, а стоимость необходимых конфет будет {(price / weight) * needWeight}");
            */
            // Begin34◦. Известно, что X кг шоколадных конфет стоит A рублей, а Y кг ири-
            // сок стоит B рублей. Определить, сколько стоит 1 кг шоколадных конфет, 1 кг ирисок, 
            // а также во сколько раз шоколадные конфеты дороже ирисок.
            /*
            Console.Write("Введите вес шоколадных конфет: ");
            double weightX = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость этих (шоколаных) конфет: ");
            double priceA = double.Parse(Console.ReadLine());
            Console.Write("Введите вес ирисок: ");
            double weightY = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость ирисок: ");
            double priceB = double.Parse(Console.ReadLine());
            Console.Write($"стоимость шоколадных конфет за 1 кг: {Math.Round(priceA / weightX, 2)} стоимость 1 кг ирисок {Math.Round(priceB / weightY, 2)}.");
            Console.WriteLine($" Шоколадные конфеты дороже ирисок в {Math.Round((priceA / weightX) / (priceB / weightY), 2)} раз");
            */
        }
    }
}