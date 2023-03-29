using System.ComponentModel;

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
        }
    }
}