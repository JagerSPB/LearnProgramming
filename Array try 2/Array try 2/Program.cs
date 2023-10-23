﻿class Program
{
    private static Random rnd = new Random();

    public static void Show(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"[{i}] = {array[i]}");
        }
    }

    public static void RandomFill(int[] array, int from = 0, int to = 101)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(from, to);
        }
    }

    public static double OnlyNumInput()
    {
        double number;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("принимаем только цифры, попробуйте еще раз");
            }
        }
    }

    public static int[] RandomFill(int size, int from = 0, int to = 101)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(from, to);
        }

        return array;
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

    /// <summary>
    /// Array11. Дан массив A размера N и целое число K (1 ≤ K ≤ N). Вывести элементы массива с порядковыми номерами,
    /// кратными K : AK , A2·K , A3·K , . . . .Условный оператор не использовать.
    /// </summary>
    public static void Array11()
    {
        int k = 2;
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < array.Length; i += k)
        {
            Console.WriteLine(array[i]);
        }
    }

    ///=============== 11 10 2023 ==============
    ///
    ///Array12. Дан массив A размера N (N — четное число). Вывести его элементыс четными номерами в порядке возрастания
    /// номеров: A2, A4, A6, . . ., AN .Условный оператор не использовать.
    /// 
    public static void Array12()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array13. Дан массив A размера N (N — нечетное число). Вывести его элементы
    /// с нечетными номерами в порядке убывания номеров: AN, AN−2, AN−4, ...,
    /// A1. Условный оператор не использовать.
    /// </summary>
    public static void Array13()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = array.Length - 1; i >= 0; i -= 2)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array14. Дан массив A размера N. Вывести вначале его элементы с четными номерами (в порядке возрастания номеров),
    /// а затем — элементы с нечетными номерами (также в порядке возрастания номеров):
    /// A2, A4, A6, ..., A1, A3, A5, .... Условный оператор не использовать.
    /// </summary>
    public static void Array14()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("===========");
        for (int i = 1; i < array.Length; i += 2)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array15. Дан массив A размера N. Вывести вначале его элементы с нечетными номерами в порядке возрастания
    /// номеров, а затем — элементы с четными номерами в порядке убывания номеров: A1, A3, A5, ..., A6, A4, A2.
    /// Условный оператор не использовать.
    /// </summary>
    public static void Array15()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("===========");
        for (int i = array.Length - 1; i >= 0; i -= 2)
        {
            Console.WriteLine(array[i]);
        }
    }

    /// <summary>
    /// Array16. Дан массив A размера N. Вывести его элементы в следующем порядке:
    /// A1, AN, A2, AN−1, A3, AN−2, ....
    /// </summary>
    public static void Array16()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        {
            Console.WriteLine(array[i]);
            Console.WriteLine(array[j]);
        }
    }

    /// <summary>
    /// Array17. Дан массив A размера N. Вывести его элементы в следующем порядке:
    /// A1, A2, AN, AN−1, A3, A4, AN−2, AN−3, ....
    /// </summary>
    public static void Array17()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0, j = array.Length - 1; i < array.Length; i += 2, j -= 2)
        {
            Console.WriteLine($"{array[i]}\n{array[i++]}\n{array[j]}\n{array[j--]}");
            //Console.WriteLine($"{array[j]}\n{array[j-1]}");
        }
    }

    /// <summary>
    /// Array18. Дан массив A ненулевых целых чисел размера 10. Вывести значение первого из тех его элементов AK,
    /// которые удовлетворяют неравенству AK &lt; A10. Если таких элементов нет, то вывести 0.
    /// </summary>
    public static void Array18()
    {
        int[] array = new[] { 6, 2, 3, 4, 5, 6, 7, 8, 9, 5 };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[array.Length - 1])
            {
                Console.WriteLine(array[i]);
                break;
            }
        }
    }

    /// <summary>
    /// Array19. Дан целочисленный массив A размера 10. Вывести порядковый номер последнего из тех его элементов AK,
    /// которые удовлетворяют двойномунеравенству A1 &lt; AK &lt; A10. Если таких элементов нет, то вывести 0.
    /// </summary>
    public static void Array19()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[array.Length - 1] && array[i] > array[0])
            {
                Console.WriteLine(array[i]);
                return;
            }
        }

        Console.WriteLine(0);
    }

    //========закончен урок от 15. 10=======
    /// <summary>
    /// Array20.Дан массив размера N ицелые числа K  и L(1≤K ≤L≤N).Найти сумму элементов массива с номерами
    /// от K до L включительно.
    /// </summary>
    public static void Array20()
    {
        int n = 10, k = 2, l = 5, sum = 0;
        int[] array = RandomFill(n);
        Show(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (i >= k && i <= l)
            {
                sum += array[i];
            }
        }

        Console.WriteLine($"cумма: {sum}");
    }

    /// <summary>
    /// Array21. Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N). Найти среднее арифметическое элементов массива
    /// с номерами от K до L включительно.
    /// </summary>
    public static void Array21()
    {
        int n = 10, k = 2, l = 3, sum = 0, count = 0;
        int[] array = RandomFill(n);
        Show(array);
        for (int i = k; i <= l; i++)
        {
            sum += array[i];
            count++;
        }

        Console.WriteLine($"среднне арифметическое: {sum / count}");
    }

    /// <summary>
    /// Array22. Дан массив размера N и целые числа K и L (1 < K ≤ L ≤ N). Найти сумму всех элементов массива,
    /// кроме элементов с номерами от K до L включительно.
    /// </summary>
    public static void Array22()
    {
        int n = 10, k = 1, l = 8, sum = 0;
        int[] array = RandomFill(n);
        Show(array);
        for (int i = 0; i < k; i++)
            sum += array[i];

        for (int i = k + 1; i < array.Length; i++)
            sum += array[i];

        Console.WriteLine($"cумма: {sum}");
    }

    /// <summary>
    /// Array23. Дан массив размера N и целые числа K и L (1 &lt; K ≤ L ≤ N). Найти среднее арифметическое всех
    /// элементов массива, кроме элементов с номерами от K до L включительно.
    /// </summary>
    public static void Array23()
    {
        int n = 10, k = 1, l = 8, sum = 0, count = 0;
        int[] array = RandomFill(n);
        Show(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (i < k || i > l)
            {
                sum += array[i];
                count++;
            }
        }

        Console.WriteLine($"среднне арифметическое: {sum / count}");
    }

    /// <summary>
    /// Array24. Дан целочисленный массив размера N, не содержащий одинаковых чисел. Проверить, образуют ли его элементы
    /// арифметическую прогрессию (см. задание Array3). Если образуют, то вывести разность прогрессии, если нет — вывести 0.
    /// </summary>
    public static void Array24()
    {
        int[] array = RandomFill(10, 1, 11);
        Show(array);
        int diff = array[1] - array[0];
        for (int i = 2; i < array.Length; i++)
        {
            diff = (array[i] - array[i - 1] != diff) ? 0 : diff;
        }

        Console.WriteLine(diff);
    }

    /// <summary>
    /// Array26. Дан целочисленный массив размера N. Проверить, чередуются ли внем четные и нечетные числа.
    /// Если чередуются, то вывести 0, если нет,то вывести порядковый номер первого элемента, нарушающего закономерность
    /// </summary>
    public static void Array26()
    {
        int[] array = RandomFill(10, 1, 11);
        Show(array);
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] % 2 == 0 ^ array[i + 1] % 2 != 0)
            {
                Console.WriteLine(i + 1);
                return;
            }
        }

        Console.WriteLine(0);
    }

    //========================УРОК 18.10 ЗАКОНЧЕН==============
    /// <summary>
    /// Array27. Дан массив ненулевых целых чисел размера N. Проверить, чередуются ли в нем положительные и
    /// отрицательные числа. Если чередуются,то вывести 0, если нет, то вывести порядковый номер первого элемента,
    /// нарушающего закономерность.
    /// </summary>
    public static void Array27()
    {
        int[] array = RandomFill(10, -5, 6);
        Show(array);
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] >= 0 ^ array[i + 1] < 0)
            {
                Console.WriteLine($"первый элемент нарушающий закономерность: {i + 1}");
                return;
            }
        }

        Console.WriteLine(0);
    }

    /// <summary>
    /// Array28. Дан массив A размера N. Найти минимальный элемент из его элементов с четными номерами:
    /// A2, A4, A6, . . . .
    /// </summary>
    public static void Array28()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int minElement = array[0];
        for (int i = 2; i < array.Length - 1; i += 2)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }

        Console.WriteLine($"минимальный элемент из четных: {minElement}");
    }

    /// <summary>
    /// Array29. Дан массив A размера N. Найти максимальный элемент из его элементов с нечетными номерами:
    /// A1, A3, A5, . . . .
    /// </summary>
    public static void Array29()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int maxElement = array[1];
        for (int i = 1; i < array.Length - 1; i += 2)
        {
            if (array[i] > maxElement)
            {
                (array[i], maxElement) = (maxElement, array[i]);
            }
        }

        Console.WriteLine($"максимальный элемент из нечетных: {maxElement}");
    }

    /// <summary>
    /// Array30. Дан массив размера N. Найти номера тех элементов массива, которые больше своего правого соседа,
    /// и количество таких элементов. Найденные номера выводить в порядке их возрастания.
    /// </summary>
    public static void Array30()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int count = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                Console.WriteLine($"элемент [{i}] больше своего правого соседа: {array[i]}");
                count++;
            }
        }

        Console.WriteLine($"Количество элементов: {count}");
    }

    /// <summary>
    /// Array31. Дан массив размера N. Найти номера тех элементов массива, которые больше своего левого соседа,
    /// и количество таких элементов. Найденные номера выводить в порядке их убывания
    /// </summary>
    public static void Array31()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int count = 0;
        for (int i = array.Length - 1; i > 1; i--)
        {
            if (array[i] > array[i - 1])
            {
                Console.WriteLine($"элемент [{i}] больше своего левого соседа: {array[i]}");
                count++;
            }
        }

        Console.WriteLine($"Количество элементов: {count}");
    }

    /// <summary>
    /// Array32. Дан массив размера N. Найти номер его первого локального минимума (локальный минимум — это элемент,
    /// который меньше любого из своих соседей).
    /// </summary>
    public static void Array32()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1] && array[i] < array[i - 1])
            {
                Console.WriteLine($"элемент [{i}] первый локальный минимум: {array[i]}");
                break;
            }
        }
    }

    /// <summary>
    /// Array33. Дан массив размера N. Найти номер его последнего локального масимума (локальный максимум — это элемент,
    /// который больше любого из своих соседей).
    /// </summary>
    public static void Array33()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        for (int i = array.Length - 2; i > 1; i--)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                Console.WriteLine($"элемент [{i}] последний локальный максимум: {array[i]}");
                break;
            }
        }
    }

    /// <summary>
    /// Array34. Дан массив размера N. Найти максимальный из его локальных минимумов.
    /// </summary>
    public static void Array34()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int maxOfmin = Int32.MinValue;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1] && array[i] < array[i - 1] && array[i] > maxOfmin)
            {
                maxOfmin = array[i];
            }
        }

        Console.WriteLine($"максимальный локальный минимум: {maxOfmin}");
    }

    /// <summary>
    /// Array35. Дан массив размера N. Найти минимальный из его локальных масимумов.
    /// </summary>
    public static void Array35()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int minOfmax = Int32.MaxValue;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1] && array[i] < minOfmax)
            {
                minOfmax = array[i];
            }
        }

        Console.WriteLine($"Минимальный локальный максимум: {minOfmax}");
    }

    /// <summary>
    ///Array36. Дан массив размера N. Найти максимальный из его элементов, не являющихся ни локальным минимумом,
    /// ни локальным максимумом . Если таких элементов в массиве нет, то вывести 0
    /// </summary>
    public static void Array36()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int maxOfNotMinMax = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] < array[i + 1] && array[i] > array[i - 1]) ||
                (array[i] > array[i + 1] && array[i] < array[i - 1])
                && array[i] > maxOfNotMinMax)
            {
                maxOfNotMinMax = array[i];
            }
        }

        Console.WriteLine($"максимальный элемент ни локальный мин, ни локальный мин {maxOfNotMinMax}");
    }

    //====================Урок 22.10.2023 окончен =========================
    /// <summary>
    /// Array37. Дан массив размера N. Найти количество участков, на которых егоэлементы монотонно возрастают
    /// </summary>
    public static void Array37()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int count = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1] && array[i] > array[i - 1])
            {
                count++;
            }
        }

        Console.WriteLine($"в массиве {count} монотонно возрастающих участков");
    }

    /// <summary>
    /// Array38. Дан массив размера N. Найти количество участков, на которых егоэлементы монотонно убывают.
    /// </summary>
    public static void Array38()
    {
        int[] array = RandomFill(15, 0, 100);
        Show(array);
        int count = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] < array[i - 1])
            {
                count++;
            }
        }

        Console.WriteLine($"в массиве {count} монотонно убывающих участков");
    }

    /// <summary>
    /// Array39. Дан массив размера N. Найти количество его промежутков монотонности (то есть участков,
    /// на которых его элементы возрастают или убывают).
    /// </summary>
    public static void Array39()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int count = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] < array[i - 1] ||
                array[i] < array[i + 1] && array[i] > array[i - 1])
            {
                count++;
            }
        }

        Console.WriteLine($"в массиве {count} промежутков монотонности");
    }

    /// <summary>
    /// Array40. Дано число R и массив A размера N. Найти элемент массива, который наиболее близок к числу R
    /// (то есть такой элемент AK, для которого величина |AK − R| является минимальной).
    /// </summary>
    public static void Array40()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int r = 55, minDiff = Math.Abs(r - array[0]), minElement = array[0];
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (Math.Abs(r - array[i]) < minDiff)
            {
                minDiff = Math.Abs(r - array[i]);
                minElement = array[i];
            }
        }

        Console.WriteLine($"самое близкое к {r} -> {minElement}, их разница {minDiff}");
    }

    /// <summary>
    /// Array41. Дан массив размера N. Найти два соседних элемента, сумма которых максимальна, и вывести эти элементы
    /// в порядке возрастания их индексов.
    /// </summary>
    public static void Array41()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int maxSumOfTwo = array[0] + array[1], maxElement1 = array[0], maxElement2 = array[1];
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] + array[i + 1] > maxSumOfTwo)
            {
                maxElement1 = array[i];
                maxElement2 = array[i + 1];
            }
        }

        Console.WriteLine($"Елемент 1 -> {maxElement1}, Елемент 2 -> {maxElement2}");
    }

    /// <summary>
    /// Array42. Дано число R и массив размера N. Найти два соседних элемента массива, сумма которых наиболее близка
    /// к числу R, и вывести эти элементыв порядке возрастания их индексов
    /// </summary>
    public static void Array42()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int r = 70, minDiff = Math.Abs(r - (array[0] + array[1])), maxElement1 = array[0], maxElement2 = array[1];
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (Math.Abs(r - (array[i] + array[i + 1])) < minDiff)
            {
                minDiff = Math.Abs(r - (array[i] + array[i + 1]));
                maxElement1 = array[i];
                maxElement2 = array[i + 1];
            }
        }

        Console.WriteLine($"самое близкая к {r} -> сумма {maxElement1} и {maxElement2} ");
    }

    /// <summary>
    /// Array43. Дан целочисленный массив размера N, все элементы которого упорядочены (по возрастанию или по убыванию).
    /// Найти количество различных элементов в данном массиве
    /// </summary>
    public static void Array43()
    {
        // int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        Show(array);
        int countUniqe = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1] ^ array[i] > array[i + 1])
            {
                countUniqe++;
            }
        }

        Console.WriteLine($"{countUniqe} различных элементов в данном массиве");
    }

    /// <summary>
    /// Array44. Дан целочисленный массив размера N, содержащий ровно два одинаковых элемента. Найти номера одинаковых
    /// элементов и вывести эти номера в порядке возрастания.
    /// </summary>
    public static void Array44()
    {
        int[] array = new int[] { 1, 9, 8, 7, 6, 10, 4, 3, 10, 1 };
        Show(array);

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[i] == array[j])
                {
                    Console.WriteLine($"[{i}] {array[i]} и [{j}] {array[j]} одинаковы ");
                }
            }
        }
    }

    /// <summary>
    /// Array45. Дан массив размера N. Найти номера двух ближайших элементов из этого массива (то есть элементов с
    /// наименьшим модулем разности) и вывести эти номера в порядке возрастания.
    /// </summary>
    public static void Array45()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int elment1 = array[0], elment2 = array[1], minDiff = Math.Abs(elment1 - elment2);
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (Math.Abs(array[i] - array[j]) < minDiff)
                {
                    elment1 = array[i];
                    elment2 = array[j];
                    minDiff = Math.Abs(elment1 - elment2);
                }
            }
        }

        Console.WriteLine($"[{elment1}] и [{elment2}] разница  {minDiff} ");
    }

    /// <summary>
    /// Array46. Дано число R и массив размера N. Найти два различных элемента массива, сумма которых наиболее близка к
    /// числу R, и вывести эти элементы в порядке возрастания их индексов 
    /// </summary>
    public static void Array46()
    {
        int[] array = RandomFill(10, 0, 100);
        Show(array);
        int r = 70, elment1 = array[0], elment2 = array[1], minDiff = Math.Abs(r - (elment1 + elment2));
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (Math.Abs(r - (array[i] + array[j])) < minDiff)
                {
                    elment1 = array[i];
                    elment2 = array[j];
                    minDiff = Math.Abs(r - (array[i] + array[j]));
                }
            }
        }

        Console.WriteLine($"числа сумма которых наиболее близка к {r}, будут {elment1} и {elment2}");
    }

    public static void Main()
    {
        Array46();
        Console.ReadLine();
    }
}