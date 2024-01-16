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

        /// <summary>
        /// String4. Дано целое число N (1 ≤ N ≤ 26). Вывести N первых прописных (то есть заглавных)
        ///букв латинского алфавита.
        /// </summary>
        static void String4()
        {
            int n = 9;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{(char)(i + 65)} ");
            }
        }

        /// <summary>
        /// String5. Дано целое число N (1 ≤ N ≤ 26). Вывести N последних строчных (тоесть маленьких) букв
        /// латинского алфавита в обратном порядке (начинаяс буквы «z»).
        /// </summary>
        static void String5()
        {
            int n = 12;
            for (int i = 122; i > 122 - n; i--)
            {
                Console.Write($"{(char)(i)} ");
            }
        }

        /// <summary>
        /// String6. Дан символ C, изображающий цифру или букву (латинскую или русскую). Если C изображает цифру,
        /// то вывести строку «digit», если латинскую букву — вывести строку «lat», если русскую — вывести строку «rus»
        /// </summary>
        static void String6()
        {
            Console.Write("Введите символ: ");
            char s = char.Parse(Console.ReadLine());
            if ((int)s >= 48 && (int)s <= 57) Console.WriteLine("digit");
            else if ((int)s >= 65 && (int)s <= 90 || (int)s >= 97 && (int)s <= 122) Console.WriteLine("lat");
            else if ((int)s >= 128 && (int)s <= 175 || (int)s >= 224 && (int)s <= 241) Console.WriteLine("rus");
        }

        /// <summary>
        /// String8. Дано целое число N (> 0) и символ C. Вывести строку длины N,которая состоит из символов C.
        /// </summary>
        static void String8()
        {
            Console.Write("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите символ: ");
            char s = char.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{s}");
            }
        }

        /// <summary>
        /// String10. Дана строка. Вывести строку, содержащую те же символы, но расположенные в обратном порядке.
        /// </summary>
        static void String10()
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write($"{s[i]}");
            }
        }

        /// <summary>
        /// String12. Дана непустая строка S и целое число N (> 0). Вывести строку, содержащую символы строки S,
        /// между которыми вставлено по N символов «*» (звездочка).
        /// </summary>
        static void String12()
        {
            Console.Write("Введите непустую строку: ");
            string s = Console.ReadLine();
            Console.Write("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s[i]}");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
            }
        }

        //==================Урок 14.01.24 Окончен===============
        /// <summary>
        /// String13. Дана строка. Подсчитать количество содержащихся в ней цифр.
        /// </summary>
        static void String13()
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] >= 48 && (int)s[i] <= 57) count++;
            }

            Console.WriteLine(count);
        }

        /// <summary>
        /// String14. Дана строка. Подсчитать количество содержащихся в ней прописных латинских букв.
        /// </summary>
        static void String14()
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] >= 65 && (int)s[i] <= 90 || (int)s[i] >= 97 && (int)s[i] <= 122) count++;
            }

            Console.WriteLine(count);
        }

        /// <summary>
        /// String16. Дана строка. Преобразовать в ней все прописные латинские буквы в строчные.
        /// </summary>
        static void String16()
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToLower());
        }

        /// <summary>
        /// String17. Дана строка. Преобразовать в ней все строчные буквы (как латинские, так и русские) в прописные.
        /// </summary>
        static void String17()
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToUpper());
        }
        static void Main()
        {
            String17();
            Console.ReadLine();
        }
    }
}