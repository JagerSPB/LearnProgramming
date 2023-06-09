﻿using System.ComponentModel;

namespace Series
{
    internal class Programm
    {
        public static void Main()
        {
            //Series1◦. Даны десять вещественных чисел. Найти их сумму.
            /*
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"[{i}] = ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
            */
            //Series2. Даны десять вещественных чисел. Найти их произведение.
            /*
            double product = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"[{i}] = ");
                product *= double.Parse(Console.ReadLine());
            }
            Console.WriteLine(product);
            */
            //Series3. Даны десять вещественных чисел. Найти их среднее арифметическое.
            /*
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"[{i}] = ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Среднее арифметическое: {sum/10}");
            */
            // Series4. Дано целое число N и набор из N вещественных чисел. Вывести
            //     сумму и произведение чисел из данного набора.
            /*
            Console.WriteLine("Введите число N: ");
            int n = Int32.Parse(Console.ReadLine());
            double sum = 0, product = 1, num;
            for (double i = 1; i <= n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Double.Parse(Console.ReadLine());
                sum += num;
                product *= num;
            }
            Console.WriteLine($"Сумма: {sum}, Произведение: {product}");
            */
            // Series5. Дано целое число N и набор из N положительных вещественных чисел. Вывести в том же порядке целые
            // части всех чисел из данного набора (как вещественные числа с нулевой дробной частью),
            // а также сумму всех целых частей.
            //
            //==============V1 using Convert.ToInt32 ==========================
            /*
             Console.WriteLine("Введите число N: ");
             int n = Int32.Parse(Console.ReadLine());
             double sum = 0, num;
             for (double i = 1; i <= n; i++)
             {
                 Console.Write($"[{i}] = ");
                 num = Double.Parse(Console.ReadLine());
                 Console.WriteLine($"Целое число: {Convert.ToInt32(num)}");
                 sum += Convert.ToInt32(num);
             }
             Console.Write($"сумма всех целых частей: {sum}");
             */
            //===============V2 using Math.Truncate=======================
            /*
            Console.WriteLine("Введите число N: ");
            int n = Int32.Parse(Console.ReadLine());
            double sum = 0, num;
            for (double i = 1; i <= n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Целое число: {Math.Truncate(num)}");
                sum += Math.Truncate(num);
            }
            Console.Write($"сумма всех целых частей: {sum}");          
            */
            // Series6. Дано целое число N и набор из N положительных вещественных чисел. Вывести в том же порядке дробные 
            //     части всех чисел из данного набора (как вещественные числа с нулевой целой частью),
            //     а также произведение всех дробных частей.
            //
            //==============V1 using Convert.ToInt32 ==========================
            /*
            Console.WriteLine("Введите число N: ");
            int n = Int32.Parse(Console.ReadLine());
            double product = 1, num;
            for (double i = 1; i <= n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Double.Parse(Console.ReadLine());
                Console.WriteLine($"дробная часть: {(num - Convert.ToInt32(num))}");
                product *= (num - Convert.ToInt32(num));
            }
            Console.Write($"произведение всех дробных частей: {product}");
            */
            //===============V2 using Math.Truncate=======================
            /*
            Console.WriteLine("Введите число N: ");
            int n = Int32.Parse(Console.ReadLine());
            double product = 1, num;
            for (double i = 1; i <= n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Double.Parse(Console.ReadLine());
                Console.WriteLine($"дробная часть: {(num-Math.Truncate(num))}");
                product *= (num-Math.Truncate(num));
            }
            Console.Write($"произведение всех дробных частей: {product}");
            */
            // Series7. Дано целое число N и набор из N вещественных чисел. Вывести в том же порядке округленные значения
            //     всех чисел из данного набора (как целые числа), а также сумму всех округленных значений.
            /*
            Console.WriteLine("введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            double sum = 0, num;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"[{i}] = ");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Целое число: {Convert.ToInt32(num)}");
                sum += Convert.ToInt32(num);
            }
            Console.WriteLine($"сумма целых чисел: {sum}");
            */
            // Series8. Дано целое число N и набор из N целых чисел. Вывести в том же порядке все четные числа из 
            //     данного набора и количество K таких чисел.
            /*
            int n = 5, num, k = 0;
            for (int i = 1; i <=n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Int32.Parse(Console.ReadLine());
                if (num % 2 == 0) k++;
            }
            Console.WriteLine($"количество чётных чисел: {k}");
            */
            // Series9. Дано целое число N и набор из N целых чисел. Вывести в том же порядке номера всех нечетных чисел
            //     из данного набора и количество K таких чисел.
            /*
            int n = 5, num, k = 0;
            for (int i = 1; i <=n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Int32.Parse(Console.ReadLine());
                if (num % 2 != 0) k++;
            }
            Console.WriteLine($"количество нечётных чисел: {k}");
            */
            // Series10. Дано целое число N и набор из N целых чисел. Если в наборе имеются положительные числа,
            //     то вывести TRUE; в противном случае вывести FALSE.
            /*
            int n = 5, num, isPositive = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Int32.Parse(Console.ReadLine());
                if (num > 0) isPositive = 1;
            }
            Console.WriteLine(isPositive==1);
            */
            // Series11. Даны целые числа K, N и набор из N целых чисел. Если в наборе имеются числа, меньшие K, 
            // то вывести TRUE; в противном случае вывести FALSE.
            /*
            Console.Write("Введите число N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Введите число K: ");
            int k = Int32.Parse(Console.ReadLine());
            int num, flage = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"[{i}] = ");
                num = Int32.Parse(Console.ReadLine());
                if (num < k) flage = 1;
            }
            Console.WriteLine(flage == 1);
            */
            // Series12. Дан набор ненулевых целых чисел; признак его завершения — число 0. 
            //     Вывести количество чисел в наборе.
            /*
            int num = 1;
            for (int i = 1; num != 0; i++)
            {
                Console.Write("Введите число: ");
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"кол-во: {i}");
            }
            */
            // Series13. Дан набор ненулевых целых чисел; признак его завершения — число 0. Вывести сумму всех 
            // положительных четных чисел из данного набора. Если требуемые числа в наборе отсутствуют, то вывести 0.
            /*
             int num = 1, sum = 0;
             for (int i = 1; num != 0; i++)
             {
                 Console.Write("Введите число: ");
                 num = Int32.Parse(Console.ReadLine());
                 if (num > 0 && num % 2 == 0) sum += num;
             }
             Console.WriteLine($"сумма: {sum}");
            
             */
            // Series14. Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0.
            //     Вывести количество чисел в наборе, меньших K.
            /*
            int k = 5, num = 1, count = 0;
            for (int i = 1; num != 0; i++)
            {
                Console.Write($"[{i}] = ");
                Console.Write("Введите число: ");
                num = Int32.Parse(Console.ReadLine());
                if (num < k) count ++;
            }
            Console.WriteLine($"кол-во: {count}");
            */
            // Series15◦. Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0.
            //     Вывести номер первого числа в наборе, большего K. Если таких чисел нет, то вывести 0.
            /*
            int k = 5, num = 1, id=0;
            for (int i = 1; num != 0; i++)
            {
                Console.Write($"[{i}] = ");
                Console.Write("Введите число: ");
                num = Int32.Parse(Console.ReadLine());
                if (num > k && id == 0) id = i;
            }
            Console.WriteLine($"номер первого числа (>K): {id}");
            */
            // Series16◦. Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0. 
            //     Вывести номер последнего числа в наборе, большего K. Если таких чисел нет, то вывести 0.
            /*
            int k = 5, num = 1, maxNumIndex =0;
            for (int i = 1; num != 0; i++)
            {
                Console.Write($"[{i}] = ");
                Console.Write("Введите число: ");
                num = Int32.Parse(Console.ReadLine());
                if (num > k ) maxNumIndex = i;
            }
            Console.WriteLine($"номер последнего числа (>K): {maxNumIndex}");
            */
            // Series19◦. Дано целое число N (>1) и набор из N целых чисел. Вывести те элементы в наборе, которые меньше
            //     своего левого соседа, и количество K таких элементов.
            /*
            int k = 5, num, countNum = 0, tempNum = 0;
            for (int i = 1; i <= k; i++, tempNum = num)
            {
                Console.Write("Введите число: ");
                num = Int32.Parse(Console.ReadLine());
                if (num < tempNum)
                {
                    Console.WriteLine($"-->[{num}]");
                    countNum++;
                }
            }
            Console.WriteLine($"кол-во чисел, меньше пред-идущего: {countNum}");
            */
            // Series20. Дано целое число N (>1) и набор из N целых чисел. Вывести те элементы в наборе, которые меньше
            //     своего правого соседа, и количество K таких элементов.
            /*
            int k = 5, newNum, oldNum = 0, countNum = 0;
            for (int i = 1; i <= k; i++, oldNum = newNum)
            {
                Console.Write("Введите число: ");
                newNum = Int32.Parse(Console.ReadLine());
                if (oldNum < newNum && i != 1)
                {
                    Console.WriteLine($"-->[{newNum}]");
                    countNum++;
                }
            }
            Console.WriteLine($"кол-во чисел, меньше следущего: {countNum}");
            */
            // Series21◦. Дано целое число N (> 1) и набор из N вещественных чисел. Проверить, образует ли данный набор 
            // возрастающую последовательность. Если образует, то вывести TRUE, если нет — вывести FALSE.
            /*
            int n = 5;
            double num, tempNum = 0;
            bool hasGrowNums = true;
            for (int i = 1; i <= n; i++, tempNum = num)
            {
                Console.Write("Введите число: ");
                num = double.Parse(Console.ReadLine());
                if (num <= tempNum ) hasGrowNums = false;
            }
            Console.WriteLine(hasGrowNums);
            */
            // Series22. Дано целое число N (> 1) и набор из N вещественных чисел. Если данный набор образует убывающую 
            // последовательность, то вывести 0; в противном случае вывести номер первого числа, нарушающего закономерность.
            /*
            int n = 5;
            double num, tempNum = 0, wrongNum = 0;

            for (int i = 1; i <= n; i++, tempNum = num)
            {
                Console.Write("Введите число: ");
                num = double.Parse(Console.ReadLine());
                if (num > tempNum && i != 1)
                {
                    wrongNum = num;
                    break;
                }
            }
            Console.WriteLine(wrongNum);
            */
            // Series25. Дано целое число N и набор из N целых чисел, содержащий по крайней мере два нуля. 
            //     Вывести сумму чисел из данного набора, расположенных между первым и последним нулем 
            //     (если первый и последний нули идут подряд, то вывести 0).
            //
            /*
            int n = 8, num, sum = 0, num2 = 1;
            bool hasZero = false;
            for (int i = 0; i <= n; i++, num2 = num)
            {
                Console.Write("Введите число: ");
                num = Int32.Parse(Console.ReadLine());
                if (num == 0)  hasZero = true; // ловим первый 0
                if (hasZero)   sum += num; // суммируем числа после первого 0
                if (num == 0 && (num2 == 0 || sum!=0) && hasZero)   hasZero = false; // ловим второй 0 
            }
            Console.WriteLine(sum);
            */
            //
            //
            // Series26. Даны целые числа K, N и набор из N вещественных чисел: A1, A2, . . ., AN .
            // Вывести K-e степени чисел из данного набора:(A1)K, (A2)K, ..., (AN)K.
            /*
             int k = 3, n = 5;
             double degree = 1, numA;
             for (int i = 0; i < n; i++)
             {
                 Console.Write("Введите число: ");
                 numA = double.Parse(Console.ReadLine());
                 for (int j = 0; j < k; j++)
                 {
                     degree *= numA;
                 }
                 Console.WriteLine($"{numA}^{k}=[{degree}]");
                 degree = 1;
             }
             */
            // Series27. Дано целое число N и набор из N вещественных чисел: A1, A2, . . .,AN . Вывести следующие числа:
            // A1, (A2)2, ..., (AN−1)N−1, (AN)N.
            /*
            int  n = 5;
            double degree = 1, numA;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число: ");
                numA = double.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    degree *= numA;
                }
                Console.WriteLine($"{numA}^{n}=[{degree}]");
                degree = 1;
            }
            */
            // Series30◦. Даны целые числа K, N, а также K наборов целых чисел по N эле-
            //     ментов в каждом наборе. Для каждого набора вывести сумму его элемен-
            //     тов.
            int k = 5, n = 4, sum = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите число: "); 
                    sum += int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Cумма: {sum}");
                sum = 0;
            }
        }
    }
}