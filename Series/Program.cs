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
        }
    }
}