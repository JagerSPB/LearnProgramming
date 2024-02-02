using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;

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
            if (char.IsDigit(s[i]))
                count++;
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
            if (s[i] >= 'A' && s[i] <= 'Z')
                count++;
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
        char[] arr = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (arr[i] >= 'A' && arr[i] <= 'Z')
                arr[i] = char.ToLower(arr[i]);
        }

        s = new string(arr);
        Console.WriteLine(s);
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

    ///==================Урок 17.01.24 Окончен===============
    /// <summary>
    /// String18. Дана строка. Преобразовать в ней все строчные буквы (как латинские, так и русские) в прописные,
    /// а прописные — в строчные.
    /// </summary>
    static void String18()
    {
        Console.Write("Введите строку: ");
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(arr[i]))
                arr[i] = char.ToLower(arr[i]);
            else if (char.IsLower(arr[i]))
                arr[i] = char.ToUpper(arr[i]);
        }

        s = new string(arr);
        Console.WriteLine(s);
    }

    /// <summary>
    /// String19. Дана строка. Если она представляет собой запись целого числа, то вывести 1, если вещественного
    /// (с дробной частью) — вывести 2; если строку нельзя преобразовать в число, то вывести 0. Считать, что дробная
    /// часть вещественного числа отделяется от его целой части десятичной точкой «.».
    /// </summary>
    static void String19()
    {
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out _))
            {
                Console.WriteLine(1); // строка является целым числом
            }
            else if (double.TryParse(input, out _))
            {
                Console.WriteLine(2); // строка является вещественным числом
            }
            else
            {
                Console.WriteLine(0); // строку нельзя преобразовать в число
            }
        }
    }

    /// <summary>
    /// String20. Дано целое положительное число. Вывести символы, изображающие цифры этого числа
    /// (в порядке слева направо).
    /// </summary>
    static void String20()
    {
        Console.Write("Введите целое положительное число: ");
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine($"{input[i]}");
        }
    }

    /// <summary>
    /// String21. Дано целое положительное число. Вывести символы, изображающие цифры этого числа
    /// (в порядке справа налево).
    /// </summary>
    static void String21()
    {
        Console.Write("Введите целое положительное число: ");
        string input = Console.ReadLine();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write($"{input[i]}");
        }
    }

    /// <summary>
    /// String22. Дана строка, изображающая целое положительное число. Вывести сумму цифр этого числа.
    /// </summary>
    static void String22()
    {
        Console.WriteLine("введите строку: ");
        string numbers = Console.ReadLine();
        // string numbers = "12345";
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += int.Parse(numbers[i].ToString());
        }

        Console.WriteLine($"сумма числа: {sum}");
    }

    /// <summary>
    /// String23. Дана строка, изображающая арифметическое выражение вида «<цифра> ± <цифра> ±. . .± <цифра>»,
    /// где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»).
    /// Вывести значение данного выражения (целое число).
    /// </summary>
    static void String23()
    {
        string numbers = "1+2-3+4+5-7";
        int result = Convert.ToInt32(numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            if (char.IsDigit(numbers[i]) && numbers[i - 1] == '+')
                result += Convert.ToInt32(numbers[i]);
            else if (char.IsDigit(numbers[i]) && numbers[i - 1] == '-')
                result -= Convert.ToInt32(numbers[i]);
        }

        Console.WriteLine($"результат: {result}");
    }

    /// <summary>
    /// String24. Дана строка, изображающая двоичную запись целого положительного числа. Вывести строку,
    /// изображающую десятичную запись этого же числа.
    /// </summary>
    static void String24()
    {
        string binary = "1101";
        Console.WriteLine(Convert.ToInt32(binary, 2));
    }

    /// <summary>
    /// String25. Дана строка, изображающая десятичную запись целого положительного числа. Вывести строку, изображающую
    /// двоичную запись этого же числа.
    /// </summary>
    static void String25()
    {
        string decimalString = "13";
        int decimalNumber = int.Parse(decimalString);
        Console.WriteLine(Convert.ToString(decimalNumber, 2));
    }

    /// <summary>
    /// String26. Дано целое число N (> 0) и строка S. Преобразовать строку S в строку длины N следующим образом:
    /// если длина строки S больше N, то отбросить первые символы, если длина строки S меньше N,
    /// то в ее началодо бавить символы «.» (точка).
    /// </summary>
    static void String26()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter text: ");
        string text = Console.ReadLine()!;

        if (text.Length > n)
            text = text.Remove(0, text.Length - n);
        else if (text.Length < n)
        {
            while (text.Length != n)
                text = text.Insert(0, ".");
        }

        Console.WriteLine(text);
    }

    //==================Урок 24.01.24 Окончен===============
    /// <summary>
    /// String27. Даны целые положительные числа N1 и N2 и строки S1 и S2. Получить из этих строк новую строку,
    /// содержащую первые N1 символов строки S1 и последние N2 символов строки S2 (в указанном порядке).
    /// </summary>
    static void String27()
    {
        int n1 = 2, n2 = 4;
        string s1 = "Jager", s2 = "master";
        Console.WriteLine(s1.Substring(0, n1) + s2.Substring(s2.Length - n2));
    }

    /// <summary>
    /// String28. Дан символ C и строка S. Удвоить каждое вхождение символа C встроку S.
    /// </summary>
    static void String28()
    {
        Console.Write("Введите символ: ");
        char symbol = char.Parse(Console.ReadLine()!);
        Console.Write("Введите строку S: ");
        string inputString = Console.ReadLine()!;
        Console.WriteLine(inputString.Replace(symbol.ToString(), symbol + symbol.ToString()));
    }

    /// <summary>
    /// String29◦. Дан символ C и строки S, S0. Перед каждым вхождением символа C в строку S вставить строку S0.
    /// </summary>
    static void String29()
    {
        Console.Write("Введите символ: ");
        char symbol = char.Parse(Console.ReadLine()!);
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S0: ");
        string inputStringS0 = Console.ReadLine()!;
        Console.WriteLine(inputStringS.Replace(symbol.ToString(), inputStringS0 + symbol.ToString()));
    }

    /// <summary>
    /// String30. Дан символ C и строки S, S0. После каждого вхождения символа C в строку S вставить строку S0.
    /// </summary>
    static void String30()
    {
        Console.Write("Введите символ: ");
        char symbol = char.Parse(Console.ReadLine()!);
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S0: ");
        string inputStringS0 = Console.ReadLine()!;
        Console.WriteLine(inputStringS.Replace(symbol.ToString(), symbol.ToString() + inputStringS0));
    }

    /// <summary>
    /// String31. Даны строки S и S0. Проверить, содержится ли строка S0 в строке S. Если содержится, то вывести TRUE,
    /// если не содержится, то вывести FALSE.
    /// </summary>
    static void String31()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S0: ");
        string inputStringS0 = Console.ReadLine()!;
        Console.WriteLine(inputStringS.Contains(inputStringS0));
    }

    /// <summary>
    /// String32. Даны строки S и S0. Найти количество вхождений строки S0 в строку S.
    /// </summary>
    static void String32()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S0: ");
        string inputStringS0 = Console.ReadLine()!;
        int count = 0;
        for (int i = 0; i < inputStringS.Length - inputStringS0.Length + 1; i++)
        {
            if (inputStringS.Substring(i, inputStringS0.Length) == inputStringS0)
                count++;
        }

        Console.WriteLine(count);
    }

    /// <summary>
    /// String33. Даны строки S и S0. Удалить из строки S первую подстроку, совпадающую с S0.
    /// Если совпадающих подстрок нет, то вывести строку S без изменений.
    /// </summary>
    static void String33()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S0: ");
        string inputStringS0 = Console.ReadLine()!;
        if (inputStringS.Contains(inputStringS0))
            Console.WriteLine(inputStringS.Remove(inputStringS.IndexOf(inputStringS0), inputStringS0.Length));
        else
            Console.WriteLine(inputStringS);
    }

    /// <summary>
    /// String34. Даны строки S и S0. Удалить из строки S последнюю подстроку, совпадающую с S0. Если совпадающих
    /// подстрок нет, то вывести строку S без изменений.
    /// </summary>
    static void String34()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S0: ");
        string inputStringS0 = Console.ReadLine()!;
        if (inputStringS.Contains(inputStringS0))
            Console.WriteLine(inputStringS.Remove(inputStringS.LastIndexOf(inputStringS0), inputStringS0.Length));
        else
            Console.WriteLine(inputStringS);
    }

    /// <summary>
    /// String35. Даны строки S и S0. Удалить из строки S все подстроки, совпадающие с S0.
    /// Если совпадающих подстрок нет, то вывести строку S без изменений.
    /// </summary>
    static void String35()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S0: ");
        string inputStringS0 = Console.ReadLine()!;
        if (inputStringS.Contains(inputStringS0))
            Console.WriteLine(inputStringS.Replace(inputStringS0, ""));
        else
            Console.WriteLine(inputStringS);
    }

    //==================Урок 28.01.24 Окончен===============
    /// <summary>
    /// String36. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.
    /// </summary>
    static void String36()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S1: ");
        string inputStringS1 = Console.ReadLine()!;
        Console.Write("Введите строку S2: ");
        string inputStringS2 = Console.ReadLine()!;
        Console.WriteLine(inputStringS.Remove(inputStringS.IndexOf(inputStringS1), inputStringS1.Length)
            .Insert(inputStringS.IndexOf(inputStringS1), inputStringS2));
    }

    /// <summary>
    /// String37. Даны строки S, S1 и S2. Заменить в строке S последнее вхождение строки S1 на строку S
    /// </summary>
    static void String37()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S1: ");
        string inputStringS1 = Console.ReadLine()!;
        Console.Write("Введите строку S2: ");
        string inputStringS2 = Console.ReadLine()!;
        Console.WriteLine(inputStringS.Remove(inputStringS.LastIndexOf(inputStringS1), inputStringS1.Length)
            .Insert(inputStringS.LastIndexOf(inputStringS1), inputStringS2));
    }

    /// <summary>
    /// String38. Даны строки S, S1 и S2. Заменить в строке S все вхождения строки S1 на строку S2.
    /// </summary>
    static void String38()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        Console.Write("Введите строку S1: ");
        string inputStringS1 = Console.ReadLine()!;
        Console.Write("Введите строку S2: ");
        string inputStringS2 = Console.ReadLine()!;
        Console.WriteLine(inputStringS.Replace(inputStringS1, inputStringS2));
    }

    /// <summary>
    /// String39. Дана строка, содержащая по крайней мере один символ пробела. Вывести подстроку, расположенную
    /// между первым и вторым пробелом исходной строки. Если строка содержит только один пробел,
    /// то вывести пустую строку.
    /// </summary>
    static void String39()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        //  int secondSpaceIndex = inputStringS.IndexOf(' ', inputStringS.IndexOf(' ') + 1);
        // if (inputStringS.IndexOf(' ') != -1 && inputStringS.LastIndexOf(' ') != inputStringS.IndexOf(' '))
        //  Console.WriteLine(inputStringS.Substring(inputStringS.IndexOf(' ') + 1,
        //   secondSpaceIndex - inputStringS.IndexOf(' ') - 1));
        // else
        Console.WriteLine(inputStringS.Split(' ')[1]);
        // Console.WriteLine("тут находится очень грустная пустая строка");
    }

    /// <summary>
    /// String40. Дана строка, содержащая по крайней мере один символ пробела. Вывести подстроку, расположенную
    /// между первым и последним пробелом исходной строки. Если строка содержит только один пробел,
    /// то вывести пустую строку
    /// </summary>
    static void String40()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        if (inputStringS.IndexOf(' ') != -1 && inputStringS.LastIndexOf(' ') != inputStringS.IndexOf(' '))
            Console.WriteLine(inputStringS.Substring(inputStringS.IndexOf(' ') + 1,
                inputStringS.LastIndexOf(' ') - inputStringS.IndexOf(' ') - 1));
        else
            Console.WriteLine("тут то-же находится очень грустная пустая строка");
    }

    /// <summary>
    /// String41◦. Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими).
    /// Найти количество слов в строке.
    /// </summary>
    static void String41()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        //Console.WriteLine(inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Count());
    }

    /// <summary>
    /// String42. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами
    /// (одним или несколькими). Найти количество слов, которые начинаются и заканчиваются одной и той же буквой.
    /// </summary>
    static void String42()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        // int count = 0;
        // foreach (string word in words)
        //     if (word[0] == word[word.Length - 1])
        //         count++;

        Console.WriteLine(words.Count(word => word.First() == word.Last()));
        //Console.WriteLine(words.Count(w => w.StartsWith(w.First()) && w.EndsWith(w.Last())));
    }

    /// <summary>
    /// String43. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами
    /// (одним или несколькими). Найти количество слов, которые содержат хотя бы одну букву «А»
    /// </summary>
    static void String43()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int count = words.Count(word => word.Contains("а"));
        Console.WriteLine(count);
    }

    /// <summary>
    /// String44. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных
    /// пробелами (одним или несколькими). Найти количество слов, которые содержат ровно три буквы «А».
    /// </summary>
    static void String44()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int countOfA = 0, countOfThreepleA = 0;
        for (int i = 0; i < words.Length; i++)
        {
            countOfA = 0;
            for (int j = 0; j < words[i].Length; j++)
                if (words[i][j] == 'а')
                    countOfA++;
            if (countOfA == 3)
                countOfThreepleA++;
        }

        Console.WriteLine(countOfThreepleA);
    }

    static void String44a() //LINQ edition
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Count(word => word.Count(c => c == 'а') == 3));
    }

    /// <summary>
    /// String45. Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими).
    /// Найти длину самого короткого слова.
    /// </summary>
    static void String45()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int shortestWordLength = Int32.MaxValue;
        foreach (string word in words)
            if (word.Length < shortestWordLength)
                shortestWordLength = word.Length;
        Console.WriteLine(shortestWordLength);
    }

    static void String45a() //LINQ edition
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Min(word => word.Length));
    }

    /// <summary>
    /// String47. Дана строка, состоящая из русских слов, разделенных пробелами(одним или несколькими). Вывести строку,
    /// содержащую эти же слова, разделенные одним символом «.» (точка). В конце строки точку не ставить.
    /// </summary>
    static void String47()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(".", words));
    }

    /// <summary>
    /// String48. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами
    /// (одним или несколькими). Преобразовать каждое слово в строке, заменив в нем все последующие вхождения его
    /// первой буквы на символ «.» (точка). Например, слово «МИНИМУМ» надо преобразовать в «МИНИ.У.».
    /// Количество пробелов между словами не изменять.
    /// </summary>
    static void String48()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        // Console.Write(string.Join(" ", inputStringS.Split().Select(word => word[0] + word.Substring(1).Replace(word[0], '.'))));
        Console.WriteLine(string.Join(" ", words.Select(word => word[0] + word.Substring(1).Replace(word[0], '.'))));
    }

    //==============================урок 31.01.2024 окончен==============================
    /// <summary>
    /// String49. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами
    /// (одним или несколькими). Преобразовать каждое слово в строке, заменив в нем все предыдущие вхождения его
    /// последней буквы на символ «.» (точка). Например, слово «МИНИМУМ» надо преобразовать в «.ИНИ.УМ».
    /// Количество пробелов между словами не изменять.
    /// </summary>
    static void String49()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(" ",
            words.Select(word => word.Substring(0, word.Length - 1).Replace(word[^1], '.') + word[^1])));
    }

    /// <summary>
    /// String50. Дана строка, состоящая из русских слов, разделенных пробелами(одним или несколькими). Вывести строку,
    /// содержащую эти же слова, разделенные одним пробелом и расположенные в обратном порядке
    /// </summary>
    static void String50()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(" ", words.Reverse()));
    }

    /// <summary>
    /// String51. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами
    /// (одним или несколькими). Вывести строку, содержащую эти же слова,
    /// разделенные одним пробелом и расположенные в алфавитном порядке.
    /// </summary>
    static void String51()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(" ", words.OrderBy(word => word)));
    }

    /// <summary>
    /// String52. Дана строка-предложение на русском языке. Преобразовать строку так, чтобы каждое слово начиналось
    /// с заглавной буквы. Словом считать набор символов, не содержащий пробелов и ограниченный пробелами или
    /// началом/концом строки. Слова, не начинающиеся с буквы, не изменять.
    /// </summary>
    static void String52()
    {
        Console.Write("Введите строку S: ");
        string inputStringS = Console.ReadLine()!;
        string[] words = inputStringS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(" ", words.Select(word => char.ToUpper(word[0]) + word.Substring(1))));
        
    }
    static void Main()
    {
        String52();
        Console.ReadLine();
    }
}