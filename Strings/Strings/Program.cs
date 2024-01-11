using System;

namespace Strings
{
    class Program
    {
        /// String1. Дан символ C. Вывести его код (то есть номер в кодовой таблице).
        static void String1()
        {
            char s = 'd';
            char sym = char.Parse(Console.ReadLine());
            Console.WriteLine((int)sym);
        }

        ///String2. Дано целое число N (32 ≤ N ≤ 126). Вывести символ с кодом, равным N
        static void String2()
        {
            Console.Write("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"символ соответствующий числу {n} будет: {(char)n}");
        }

        /// <summary>
        /// String3. Дан символ C. Вывести два символа, первый из которых предшествует символу C в кодовой таблице,
        /// а второй следует за символом C.
        /// </summary>
        static void String3()
        {
            Console.Write("Введите символ: ");
            char s = char.Parse(Console.ReadLine());
            int symbol1 = (int)s - 1, symbol2 = (int)s + 1;
            Console.WriteLine($"{(char)symbol1} {(char)symbol2}");
        }

        static void Main()
        {
            String3();
            Console.ReadLine();
        }
    }
}