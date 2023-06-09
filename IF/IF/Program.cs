﻿using System;

namespace IF
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // If1. Дано целое число. Если оно является положительным, то прибавить к нему 1;
            // в противном случае не изменять его. Вывести полученное число.
            /*
            int a = -3;
            if (a > 0) ++a;
            Console.WriteLine(a);
            */
            // If2. Дано целое число. Если оно является положительным, то прибавить к нему 1;
            // в противном случае вычесть из него 2. Вывести полученное число.
            /*
            int a = 3;
            if (a > 0) ++a;
            else  a -= 2;
            Console.WriteLine(a);
            */
            // If3. Дано целое число. Если оно является положительным, то прибавить к нему 1; 
            // если отрицательным, то вычесть из него 2; если нулевым, то
            // заменить его на 10. Вывести полученное число.
            /*
            int a = 10;
            if (a > 0) ++a;
            else if (a < 0) a -= 2;
            else (a == 0) a = 10;
            Console.WriteLine(a);
            */
            //If4◦. Даны три целых числа. Найти количество положительных чисел в исходном наборе.
            /*
            int a = 10, b = -20, c = 30, count = 0;
            if (a > 0) count++;
            if (b > 0) count++;
            if (c > 0) count++;
            Console.WriteLine(count);
            */
            //If5. Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе.
            /*
            int a = 10, b = -20, c = 30, countPositive = 0, countNegative = 0;
            if (a > 0) countPositive++;
            if (a < 0) countNegative++;
            if (b > 0) countPositive++;
            if (b < 0) countNegative++;
            if (c > 0) countPositive++;
            if (c < 0) countNegative++;
            Console.WriteLine($"положительных чисел: {countPositive} отрицательных чисел:{countNegative}");
            */
            //If6◦. Даны два числа. Вывести большее из них.
            /*
            int a = 100, b = 20;
            if (a > b) Console.WriteLine(a);
            else
                Console.WriteLine(b);
             */
            //If7. Даны два числа. Вывести порядковый номер меньшего из них.
            /*
            int a = 100, b = 200;
            if (a > b) Console.WriteLine("1");
            else
                Console.WriteLine("2"); 
            */
            //If8◦. Даны два числа. Вывести вначале большее, а затем меньшее из них.
            /*
            int a = 1000, b = 200;
            if (a > b) Console.WriteLine($"{a}, {b}");
            if (b > a) Console.WriteLine($"{b}, {a}");
            */
            // If9. Даны две переменные вещественного типа: A, B. Перераспределить значения данных переменных так, 
            //     чтобы в A оказалось меньшее из значений, а в B большее. Вывести новые значения переменных A и B.
            /*
            double a = 100, b = 20, temp = 0;
            if (a > b)
            {
                temp = b;
                b = a;
                a = temp;
            }
            Console.WriteLine($"{a}, {b}");
            */
            // If10. Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной 
            //     сумму этих значений, а если равны, то присвоить переменным нулевые значения. Вывести новые значения
            //     переменных A и B.
            /*
            int a = 100, b = 100;
            if (a != b)
            {
                int summ = a + b;
                a = summ;
                b = summ;
            }
            else if (a == b)
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine($"{a}, {b}");
            */
            // If11. Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной
            //     большее из этих значений, а если равны, то присвоить переменным нулевые значения.
            //     Вывести новые значения переменных A и B.
            /*
            int a = 1000, b = 1000;
            if (a > b) b = a;
            else if (b > a) a = b;
            else if (a == b)
            {
                a = 0; b = 0;
            }
            Console.WriteLine($"{a}, {b}");
            */
            // If12◦. Даны три числа. Найти наименьшее из них.
            /*
            int a = 100, b = 12, c = 150, min = a;
            if (b < min) min = b;
            else if (c < min) min = c;
            Console.WriteLine(min);
            */
            // If13. Даны три числа. Найти среднее из них (то есть число, расположенное
            //     между наименьшим и наибольшим).
            /*
            int a = 1300, b = 120, c = 150, avg = a;
            if ((b > a && b < c) || (b < a && b > c)) avg = b;
            else if ((c > a && c < b) || (c < a && c > b)) avg = c;
            Console.WriteLine(avg);
            */
            // If14. Даны три числа. Вывести вначале наименьшее, а затем наибольшее из
            //     данных чисел.
            /*
            int a = 100, b = 1000, c = 10, max = a, min = a;
            if (b < min) min = b; 
            if (c < min) min = c;
            if (b > a) max = b;
            if (c > max) max = c;
            Console.WriteLine($"{min}, {max}");
            */
            //If15. Даны три числа. Найти сумму двух наибольших из них.
            /*
            int a = 10, b = 100, c = 150, min = a;
            if (b < min) min = b;
            else if (c < min) min = c;
            Console.WriteLine($"{(a + b + c) - min}");
            */
            // If16. Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию, 
            //     то удвоить их; в противном случае заменить значение каждой переменной на противоположное. 
            //     Вывести новые значения переменных A, B, C.
            /*
            float a = 10, b = 1000, c = 150;
            if (a < b && b < c)
            {
                a += a;
                b += b;
                c += c;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine($"{a}, {b}, {c}");
            */
            // If17. Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию или 
            //     убыванию, то удвоить их; в противном случае заменить значение каждой переменной на противоположное. 
            //     Вывести новые значения переменных A, B, C.
            /*
            float a = 100, b = 10, c = 1;
            if (a < b && b < c || a > b && b > c)
            {
                a += a;
                b += b;
                c += c;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine($"{a}, {b}, {c}");
            */
            // If18. Даны три целых числа, одно из которых отлично от двух других, равных между собой.
            //     Определить порядковый номер числа, отличного от остальных.
            /*
            int a = 1000, b = 1000, c = 100;
            if (a != b && a != c) Console.WriteLine("1");
            if (b != c && b != a) Console.WriteLine("2");
            else if ((c != a && c != b))
                Console.WriteLine("3");
            */
            // If19. Даны четыре целых числа, одно из которых отлично от трех других, равных между собой. 
            // Определить порядковый номер числа, отличного от остальных.
            /*
            int a = 1000, b = 100, c = 1000, d = 1000;
            if (a != b && a != c) Console.WriteLine("1");
            if (b != c && b != a) Console.WriteLine("2");
            if ((c != a && c != b)) Console.WriteLine("3");
            else if (d != a && d != b) Console.WriteLine("4");
            */
            // If20.На числовой оси расположены три точки: A, B, C.Определить, какая из двух последних
            // точек(B или C) расположена ближе к A, и вывести эту точку и ее расстояние от точки A.
            /*
            int a = 10, b = 500, c = 100;
            if (b - a < c - a) Console.WriteLine($" точка 'b' {b}  ближе, расстояние до точки 'a' {b - a}");
            if (c - a < b - a) Console.WriteLine($" точка 'c' {c}  ближе, расстояние до точки 'a' {c - a}");
            */
            // If21. Даны целочисленные координаты точки на плоскости. Если точка совпадает с началом координат, 
            //     то вывести 0. Если точка не совпадает с началом координат, но лежит на оси OX или OY,
            //     то вывести соответственно 1 или 2. Если точка не лежит на координатных осях, то вывести 3.
            /*
            int x = 0, y = 10;
            if (x == 0 && y == 0) Console.WriteLine("0");
            if (x == 0 && y != 0) Console.WriteLine("1");
            if (x != 0 && y == 0) Console.WriteLine("2");
            else if (x != 0 && y != 0) Console.WriteLine("3");
            */
            // If22◦. Даны координаты точки, не лежащей на координатных осях OX и OY.Определить номер координатной
            //     четверти, в которой находится данная точка
            /*
            int x = -20, y = -10;
            if (x > 0 && y > 0) Console.WriteLine("четверть номер 1");
            if (x > 0 && y < 0) Console.WriteLine("четверть номер 2");
            if (x < 0 && y < 0) Console.WriteLine("четверть номер 3"); 
            else if (x < 0 && y > 0) Console.WriteLine("четверть номер 4");
            */
            // If29. Дано целое число. Вывести его строку-описание вида «отрицательное
            //     четное число», «нулевое число», «положительное нечетное число» и т. д.
            /*
            int a = 0;
            if (a == 0) Console.Write("нулевое, ");
            if (a > 0) Console.Write("положительное, ");
            if (a < 0) Console.Write("отрицательное, ");
            if (a % 2 == 0) Console.Write("чётное, ");
            if (a % 2 != 0) Console.Write("нечётное, ");
            Console.WriteLine("число");
            */
            // If30. Дано целое число, лежащее в диапазоне 1–999. Вывести его строку- описание вида 
            //     «четное двузначное число», «нечетное трехзначное число» и т. д.
            /*
            int a = 0;
            if (a % 2 == 0) Console.Write("чётное, ");
            if (a % 2 != 0) Console.Write("нечётное, ");
            if (a > 9 && a < 100) Console.Write("двухзначное, ");
            if (a > 99 && a < 999) Console.Write("трёхзначное, ");
            Console.WriteLine("число");
            */
            
        }
    }
}