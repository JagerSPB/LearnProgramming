class Program
{
    public static void Show(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"[{i}] = {array[i]}");
        }
    }

    /// <summary>
    /// Array1. Дано целое число N (>0). Сформировать и вывести целочисленный массив размера N, содержащий N первых
    /// положительных нечетных чисел: 1, 3, 5, . . . .
    /// </summary>
    public static void Array1()
    {
        int n = 10;
        int[] array = new int[n];
        for (int i = 0, j = 1; i < array.Length; i++, j += 2)
        {
            array[i] = j;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array2. Дано целое число N (>0). Сформировать и вывести целочисленный массив размера N, содержащий степени
    /// двойки от первой до N-й: 2, 4, 8, 16, . . . .
    /// </summary>
    public static void Array2()
    {
        int n = 10;
        int[] array = new int[n];
        array[0] = 2;
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = array[i - 1] * 2;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array3. Дано целое число N (> 1), а также первый член A и разность D арифметической прогрессии. Сформировать
    /// и вывести массив размера N, содержащий N первых членов данной прогрессии A, A+D, A+2·D, A+3·D, ....
    /// </summary>
    public static void Array3()
    {
        int n = 10, a = 2, d = 5;
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = a + i * d;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array4. Дано целое число N (>1), а также первый член A и знаменатель D геометрической прогрессии.
    /// Сформировать и вывести массив размера N, содержащий N первых членов данной прогрессии:
    /// A, A·D, A·D2, A·D3, . . . .
    /// </summary>
    public static void Array4()
    {
        int n = 10, a = 3, d = 5;
        int[] array = new int[n];
        array[0] = a;
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = a * (int)Math.Pow(d, i);
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array5. Дано целое число N (&gt;2). Сформировать и вывести целочисленный
    /// массив размера N, содержащий N первых элементов последовательности чисел Фибоначчи FK:
    /// F1 =1, F2 =1, FK =FK−2 +FK−1, K =3,4,....
    /// </summary>
    public static void Array5()
    {
        int n = 10;
        int[] array = new int[n];
        array[0] = 0;
        array[1] = 1;
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array6. Даны целые числа N (>2), A и B. Сформировать и вывести целочисленный массив размера N, первый
    /// элемент которого равен A, второй равен B, а каждый последующий элемент равен сумме всех предыдущих.
    /// </summary>
    public static void Array6()
    {
        int n = 10, a = 2, b = 5;
        int[] array = new int[n];
        array[0] = a;
        array[1] = b;
        int sum = a + b;
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = sum;
            sum += array[i];
        }

        Show(array);
    }

    /// <summary>
    /// Array7◦. Дан массив размера N. Вывести его элементы в обратном порядке.
    /// </summary>
    public static void Array7()
    {
        int[] array = new int[] { 1, 12, 55, 40, 25, 64, 78, 933 };
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array8. Дан целочисленный массив размера N. Вывести все содержащиеся в данном массиве нечетные числа в порядке
    /// возрастания их индексов, а также их количество K.
    /// </summary>
    public static void Array8()
    {
        int count = 0;
        int[] array = new int[] { 1, 2, 30, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                Console.WriteLine(array[i]);
                count++;
            }
        }

        Console.WriteLine($"кол-во: {count}");
    }

    /// <summary>
    /// Array9. Дан целочисленный массив размера N. Вывести все содержащиеся в данном массиве четные числа в порядке
    /// убывания их индексов, а также их количество K.
    /// </summary>
    public static void Array9()
    {
        int count = 0;
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine(array[i]);
                count++;
            }
        }

        Console.WriteLine($"кол-во: {count}");
    }

    /// <summary>
    /// Array10. Дан целочисленный массив размера N. Вывести вначале все содержащиеся в данном массиве четные числа
    /// в порядке возрастания их индексов,а затем — все нечетные числа в порядке убывания их индексов.
    /// </summary>
    public static void Array10()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine(array[i]);
            }
        }
        Console.WriteLine("===========");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 != 0)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    public static void Main()
    {
        Array10();
    }
}