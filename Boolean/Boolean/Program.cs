using System;

namespace Boolean
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Boolean1◦. Дано целое число A. Проверить истинность высказывания: «Число A является положительным».
            /*
            int n = 4;
            bool positive = n > 0;
            Console.WriteLine(positive);
            */
            //Boolean2◦. Дано целое число A. Проверить истинность высказывания: «Число A является нечетным».
            /*
            int n = 7;
            bool oddNum = n % 2 != 0;
            Console.WriteLine(oddNum);
            */
            //Boolean3◦. Дано целое число A. Проверить истинность высказывания: «Число A является четным».
            /*
            int n = 8;
            bool even = n % 2 == 0;
            Console.WriteLine(even);
            */
            //Boolean4◦. Даны два целых числа: A, B. Проверить истинность высказывания:
            //«Справедливы неравенства A > 2 и B ≤ 3».
            /*
            int a = 3, b=1;
            bool comparAandB = a > 2 && b <= 3;
            Console.WriteLine(comparAandB);
            */
            //Boolean5◦. Даны два целых числа: A, B. Проверить истинность высказывания:
            //«Справедливы неравенства A ≥ 0 или B < −2».
            /*
            int a = -5, b = -11;
            bool comparAorB = a >= 0 || b < -2;
            Console.WriteLine(comparAorB);
            */
            //Boolean6◦. Даны три целых числа: A, B, C. Проверить истинность высказывания:
            //  «Справедливо двойное неравенство A < B < C».
            // int a = 2, b = 4, c = 5;
            // bool doubleInequality = a < b && a < c;
            // Console.WriteLine(doubleInequality);
            // Boolean7◦. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Число B находится 
            //     между числами A и C».
            /*
            int a = 7, b = 4, c = 5;
            bool middleNum = a < b && b < c;
            Console.WriteLine(middleNum);
            */
            //Boolean8◦. Даны два целых числа: A, B. Проверить истинность высказывания: «Каждое из чисел A и B нечетное».
            /*
            int a = 7, b = 6;
            bool notEven = a % 2 != 0 && b % 2 != 0;
            Console.WriteLine(notEven);
            */
            //Boolean9◦. Даны два целых числа: A, B. Проверить истинность высказывания: «Хотя бы одно из чисел A и B нечетное».
            /*
            int a = 8, b = 6;
            bool oneNotEven = a % 2 != 0 || b % 2 != 0;
            Console.WriteLine(oneNotEven);
            */
            //Boolean10◦. Даны два целых числа: A, B. Проверить истинность высказывания: «Ровно одно из чисел A и B нечетное».
            /*
            int a = 7, b = 6;
            bool onlyOneNotEven = a % 2 != 0 ^ b % 2 != 0;
            Console.WriteLine(onlyOneNotEven);
            */
            // Boolean11◦. Даны два целых числа: A, B. Проверить истинность высказывания:
            //     «Числа A и B имеют одинаковую четность».
            /*
            int a = 5, b = 5;
            bool sameParity = (a % 2 != 0 && b % 2 != 0)||(a % 2 == 0 && b % 2 == 0) ;
            Console.WriteLine(sameParity);                       
            */
            // Boolean12◦. Даны три целых числа: A, B, C. Проверить истинность высказывания:
            //     «Каждое из чисел A, B, C положительное».
            /*
            int a = 5, b = -5, c = 4;
            bool samePositive = (a > 0 && b > 0 && c > 0);
            Console.WriteLine(samePositive);
            */
            // Boolean13◦. Даны три целых числа: A, B, C. Проверить истинность высказывания: 
            //     «Хотя бы одно из чисел A, B, C положительное».
            /*
            int a = -5, b = -5, c = 4;
            bool onePositive = (a > 0 || b > 0 || c > 0);
            Console.WriteLine(onePositive);                
            */
            // Boolean14◦. Даны три целых числа: A, B, C. Проверить истинность высказывания:
            //     «Ровно одно из чисел A, B, C положительное».
            /*
            int a = 15, b = 5, c = 4;
            bool onlyOnePositive = (a > 0 && (b < 0 && c < 0)) || (b > 0 && (a < 0 && c < 0)) || (c > 0 && (b < 0 && a < 0));
            Console.WriteLine(onlyOnePositive);
            */
            // Boolean15◦. Даны три целых числа: A, B, C. Проверить истинность высказывания:
            //     «Ровно два из чисел A, B, C являются положительными».
            /*
            int a = -15, b = -5, c = -4;
            bool twoPositive = (a > 0 && b > 0 && c < 0) || (b > 0 && a < 0 && c > 0) || (c > 0 && b < 0 && a > 0);
            Console.WriteLine(twoPositive);
            */
            // Boolean16◦. Дано целое положительное число. Проверить истинность высказывания: 
            //     «Данное число является четным двузначным».
            /*
            int a = 10;
            bool evenTwo = a > 0 && a >= 10 && a < 100;
            Console.WriteLine(evenTwo);
            */
            // Boolean17◦. Дано целое положительное число. Проверить истинность высказывания: 
            //     «Данное число является нечетным трехзначным».
            /*
            int a = 999;
            bool notEvenThree = a % 2 != 0 && a >= 100 && a < 1000;
            Console.WriteLine(notEvenThree;
            */
            // Boolean18◦. Проверить истинность высказывания: 
            //     «Среди трех данных целых чисел есть хотя бы одна пара совпадающих».
            /*            
            int a = 80, b = 80, c = 89;
            bool sameTwo = a == b || b == c || c == a;
            Console.WriteLine(sameTwo);
            */
            // Boolean19◦. Проверить истинность высказывания: 
            //     «Среди трех данных целых чисел есть хотя бы одна пара взаимно противоположных».
            /*
            int a = 80, b = -80, c = 89;
            bool reversPaar = (a == -b || b == -c || c == -a);
            Console.WriteLine(reversPaar);
            */
            //Boolean20◦. Дано трехзначное число. Проверить истинность высказывания: «Все цифры данного числа различны».
            /*
            int a = 586;
            int num1 = a / 100;
            int num2 = a % 100 / 10;
            int num3 = a % 10;
            bool diffNumbers = num1 != num2 && num1 != num3 && num2 != num3;
            Console.WriteLine(diffNumbers);
            */
            // Boolean21◦. Дано трехзначное число. Проверить истинность высказывания:
            //     «Цифры данного числа образуют возрастающую последовательность».
            /*
            int a = 234;
            int num1 = a / 100;
            int num2 = a % 100 / 10;
            int num3 = a % 10;
            bool growNumbers = num1 == num2-1 && num2 == num3-1 ;
            Console.WriteLine(growNumbers);
            */
            // Boolean22◦. Дано трехзначное число. Проверить истинность высказывания:
            //     «Цифры данного числа образуют возрастающую или убывающую последовательность».
            /*
            int a = 654;
            int num1 = a / 100;
            int num2 = a % 100 / 10;
            int num3 = a % 10;
            bool growOrDownNumbers = (num1 == num2 - 1 && num2 == num3 - 1) || (num1 - 1 == num2 && num2 - 1 == num3);
            Console.WriteLine(growOrDownNumbers);
            */
            // Boolean23◦. Дано четырехзначное число. Проверить истинность высказывания:
            //     «Данное число читается одинаково слева направо и справа налево».
            /*
            int a = 1221;
            int num1 = a / 1000;
            int num2 = a % 1000 / 100;
            int num3 = a % 100 / 10;
            int num4 = a % 10;
            bool polidromNumbers = (num1 == num4 && num2 == num3);
            Console.WriteLine(polidromNumbers);
            */
            // Boolean24◦. Даны числа A, B, C (число A не равно 0). Рассмотрев дискриминант D = B2 − 4·A·C, 
            //     проверить истинность высказывания: «Квадратное уравнение A·x2 + B·x + C = 0 имеет вещественные корни».
            //     Если D < 0, корней нет Если D = 0, есть ровно один корень; Если D > 0, корней будет два.
            /*
            int a = 1, b = 7, c = 4;
            int dis = b * b - (4 * a * c);
            bool result = dis >= 0;
            if (result == true)
                Console.WriteLine($"{result} корни есть");
            else
                Console.WriteLine($"{result} корней нет");
             */
            // Boolean25◦. Даны числа x, y. Проверить истинность высказывания: «Точка с
            // координатами (x, y) лежит во второй координатной четверти».
            /*
            int x = 96, y = 5;
            bool quoter1 = x < 0 && y > 0;
            bool quoter2 = x > 0 && y > 0;
            bool quoter3 = x > 0 && y < 0;
            bool quoter4 = x < 0 && y < 0;
            if (quoter2 == true)
                Console.WriteLine("утверждение верно");
            else
                Console.WriteLine("утверждение не верно");
           */
            // Boolean26◦. Даны числа x, y. Проверить истинность высказывания: «Точка с
            //     координатами (x, y) лежит в четвертой координатной четверти».
            /*
            int x = -96, y = -59;
            bool quoter1 = x < 0 && y > 0;
            bool quoter2 = x > 0 && y > 0;
            bool quoter3 = x > 0 && y < 0;
            bool quoter4 = x < 0 && y < 0;
            if (quoter4 == true)
                Console.WriteLine("утверждение верно");
            else
                Console.WriteLine("утверждение не верно");   
            */
            // Boolean27◦. Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) 
            //      лежит во второй или третьей координатной четверти».
            /*
            int x = 96, y = -59;
            bool quoter1 = x < 0 && y > 0;
            bool quoter2 = x > 0 && y > 0;
            bool quoter3 = x > 0 && y < 0;
            bool quoter4 = x < 0 && y < 0;
            if (quoter2 == true || quoter3 == true)
                Console.WriteLine("утверждение верно");
            else
                Console.WriteLine("утверждение не верно");   
            */
            // Boolean28◦. Даны числа x, y. Проверить истинность высказывания: 
            //     «Точка с координатами (x, y) лежит в первой или третьей координатной четверти».
            /*
            int x = 6, y = 9;
            bool quoter1 = x < 0 && y > 0;
            bool quoter2 = x > 0 && y > 0;
            bool quoter3 = x > 0 && y < 0;
            bool quoter4 = x < 0 && y < 0;
            if (quoter1 == true || quoter3 == true)
                Console.WriteLine("утверждение верно");
            else
                Console.WriteLine("утверждение не верно");   
            */
            // Boolean29◦. Даны числа x, y, x1, y1, x2, y2. Проверить истинность высказывания:
            //     «Точка с координатами (x, y) лежит внутри прямоугольника, левая верхняя вершина которого 
            //     имеет координаты (x1, y1), правая нижняя (x2, y2), а стороны параллельны координатным осям».
            /*
            int x = 16, y = 9, x1 = 6, y1 = 30, x2 = 72, y2 = 2;
            bool pointInside = (x1 < x && x2 > x) && (y1 > y && y2 < y);
            Console.WriteLine(pointInside);
            */
            // Boolean30◦. Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. 
            //     Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».
            /*
            int a = 8, b = 8, c = 8;
            bool equalTriangle = a == b && b == c && c == a;
            Console.WriteLine(equalTriangle);
            */
            // Boolean31◦. Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.
            //     Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равнобедренным».
            /*
            int a = 8, b = 28, c = 28;
            bool equalTwoSide = (a == b && a != c) || (b == c && b != a) || (c == a && c != b);
            Console.WriteLine(equalTwoSide);
            */
            // Boolean32◦. Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. 
            //     Проверить истинность высказывания: «Треугольник со сторонами a, b, c является прямоугольным»
            //     Квадрат гипотенузы равен сумме квадратов катетов (теорема Пифагора): с2 = а2 + b2
            /*
            int a = 3, b = 4, c = 5;
            bool rightTriangle = ((a * a) == (b * b) + (c * c)) || 
                                 ((b * b) == (a * a) + (c * c)) ||
                                 ((c * c) == (b * b) + (a * a));
            Console.WriteLine(rightTriangle);
            */
            // Boolean33◦. Даны целые числа a, b, c. Проверить истинность высказывания:
            //     «Существует треугольник со сторонами a, b, c».
            /*
            int a = 30, b = 40, c = 30;
            bool existTriangle = (a + b) > c && (b + c) > a && (c + a) > b;
            Console.WriteLine(existTriangle);
            */
            // Boolean34◦. Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8). Учитывая,
            //       что левое нижнее поле доски (1,1) является черным, проверить истинность высказывания: «Данное поле является белым».
            /*
            int x = 5, y = 6;
            bool whiteCell = x % 2 != 0 && y % 2 == 0 || x % 2 == 0 && y % 2 != 0 ;
            Console.WriteLine(whiteCell);
            */
            // Boolean35◦. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2
            //       (целые числа, лежащие в диапазоне 1–8).
            //        Проверить истинность высказывания: «Данные поля имеют одинаковый цвет».
            /*
            int x1 = 8, y1 = 8, x2 = 5, y2 = 1;
            bool whiteCell1 = x1 % 2 != 0 && y1 % 2 == 0 || x1 % 2 == 0 && y1 % 2 != 0;
            bool whiteCell2 = x2 % 2 != 0 && y2 % 2 == 0 || x2 % 2 == 0 && y2 % 2 != 0;
            bool compareTwoCells = whiteCell1 == whiteCell2;
            Console.WriteLine(compareTwoCells);
            */
            // Boolean36◦. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 
            //      (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: 
            //      «Ладья за один ход может перейти с одного поля на другое».
            /*
            int x1 = 1, y1 = 5, x2 = 3, y2 = 5;
            bool rookMoveOK = x1 == x2 || y1 == y2;
            Console.WriteLine(rookMoveOK);
            */
            // Boolean37◦. Даны координаты двух различных полей шахматной доски x1,
            //     y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания:
            //     «Король за один ход может перейти с одного поля на другое».
            /*
            int x1 = 5, y1 = 3, x2 = 4, y2 = 4;
            bool kingMove1 = x1 == x2 && y1 == y2 - 1;
            bool kingMove2 = x1 == x2 - 1 && y1 == y2;
            bool kingMove3 = x1 == x2 && y1 == y2 + 1;
            bool kingMove4 = x1 == x2 + 1 && y1 == y2;
            bool kingMove5 = x1 == x2 - 1 && y1 == y2 - 1;
            bool kingMove6 = x1 == x2 - 1 && y1 == y2 + 1;
            bool kingMove7 = x1 == x2 + 1 && y1 == y2 + 1;
            bool kingMove8 = x1 == x2 + 1 && y1 == y2 - 1;
            bool kingMoveOK = kingMove1 || kingMove2 || kingMove3 || kingMove4 ||
                              kingMove5 || kingMove6 || kingMove7 || kingMove8;
            Console.WriteLine(kingMoveOK);
            */
            // Boolean38◦. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 
            //     (целые числа, лежащие в диапазоне 1–8). Проверить истинностьвысказывания: 
            //     «Слон за один ход может перейти с одного поля на другое».
            /*
            int x1 = 5, y1 = 3, x2 = 7, y2 = 1;
            bool direct1 = x1 > x2 && y1 > y2 && (x1 != x2 || y1 != y2);
            bool direct2 = x1 > x2 && y1 < y2 && (x1 != x2 || y1 != y2);
            bool direct3 = x1 < x2 && y1 < y2 && (x1 != x2 || y1 != y2);
            bool direct4 = x1 < x2 && y1 > y2 && (x1 != x2 || y1 != y2);
            bool bishopMoveOK = direct1 || direct2 || direct3 || direct4;
            Console.WriteLine(bishopMoveOK);
            */

            // Boolean39◦. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 
            //      (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания:
            //     «Ферзь за один ход может перейти с одного поля на другое».
            /*
            int x1 = 4, y1 = 4, x2 = 7, y2 = 4;
            bool quinMoveStraight1 = x1 == x2 && y1 < y2;
            bool quinMoveStraight2 = x1 < x2 && y1 == y2;
            bool quinMoveStraight3 = x1 == x2 && y1 > y2;
            bool quinMoveStraight4 = x1 > x2 && y1 == y2;
            bool quinMoveDiagonale5 = x1 == (x2 - 1) && y1 == (y2 - 1) || x1 == (x2 - 2) && y1 == (y2 - 2) ||
                                      x1 == (x2 - 3) && y1 == (y2 - 3) || x1 == (x2 - 4) && y1 == (y2 - 4) ||
                                      x1 == (x2 - 5) && y1 == (y2 - 5) || x1 == (x2 - 6) && y1 == (y2 - 6) ||
                                      x1 == (x2 - 7) && y1 == (y2 - 7) || x1 == (x2 - 8) && y1 == (y2 - 8);
            bool quinMoveDiagonale6 = x1 == (x2 - 1) && y1 == (y2 + 1) || x1 == (x2 - 2) && y1 == (y2 + 2) ||
                                      x1 == (x2 - 3) && y1 == (y2 + 3) || x1 == (x2 - 4) && y1 == (y2 + 4) ||
                                      x1 == (x2 - 5) && y1 == (y2 + 5) || x1 == (x2 - 6) && y1 == (y2 + 6) ||
                                      x1 == (x2 - 7) && y1 == (y2 + 7) || x1 == (x2 - 8) && y1 == (y2 + 8);
            bool quinMoveDiagonale7 = x1 == (x2 + 1) && y1 == (y2 + 1) || x1 == (x2 + 2) && y1 == (y2 + 2) ||
                                      x1 == (x2 + 3) && y1 == (y2 + 3) || x1 == (x2 + 4) && y1 == (y2 + 4) ||
                                      x1 == (x2 + 5) && y1 == (y2 + 5) || x1 == (x2 + 6) && y1 == (y2 + 6) ||
                                      x1 == (x2 + 7) && y1 == (y2 + 7) || x1 == (x2 + 8) && y1 == (y2 + 8);
            bool quinMoveDiagonale8 = x1 == (x2 + 1) && y1 == (y2 - 1) || x1 == (x2 + 2) && y1 == (y2 - 2) ||
                                      x1 == (x2 + 3) && y1 == (y2 - 3) || x1 == (x2 + 4) && y1 == (y2 - 4) ||
                                      x1 == (x2 + 5) && y1 == (y2 - 5) || x1 == (x2 + 6) && y1 == (y2 - 6) ||
                                      x1 == (x2 + 7) && y1 == (y2 - 7) || x1 == (x2 + 8) && y1 == (y2 - 8);
            bool quinMoveMoveOK = quinMoveStraight1 || quinMoveStraight2 || quinMoveStraight3 || quinMoveStraight4 ||
                                  quinMoveDiagonale5 || quinMoveDiagonale6 || quinMoveDiagonale7 || quinMoveDiagonale8;
            Console.WriteLine(quinMoveMoveOK);
            */

            // Boolean40◦. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 
            //        (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания:
            //        «Конь за один ход может перейти с одного поля на другое».
            // int x1 = 5, y1 = 3, x2 = 4, y2 = 4;
            // bool horseMove1 = x1 == x2 - 1 && y1 == y2 - 2;
            // bool horseMove2 = x1 == x2 - 1 && y1 == y2;
            // bool horseMove3 = x1 == x2 && y1 == y2 + 1;
            // bool horseMove4 = x1 == x2 + 1 && y1 == y2;
            // bool horseMove5 = x1 == x2 - 1 && y1 == y2 - 1;
            // bool horseMove6 = x1 == x2 - 1 && y1 == y2 + 1;
            // bool horseMove7 = x1 == x2 + 1 && y1 == y2 + 1;
            // bool horseMove8 = x1 == x2 + 1 && y1 == y2 - 1;
            // bool horseMoveOK = horseMove1 || horseMove2 || horseMove3 || horseMove4 ||
            //                    horseMove5 || horseMove6 || horseMove7 || horseMove8;
            // Console.WriteLine(horseMoveOK);

            // Console.Write("Enter color: ");
            // string s = Console.ReadLine(); // "g" "r" "y"
            // if (s == "g") Console.Write("Можете ехать");
            // if (s == "r") Console.Write("Стоп");
            // if (s == "y") Console.Write("Приготовиться");
        }
    }
}