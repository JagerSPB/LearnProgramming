class Program
{
    private static Random rnd = new Random();

    public static void Show(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"[{i}] = {array[i]}");
        }
    }

    public static void Show(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"[{i}] = {array[i]}");
        }
    }

    public static void ShowInRow(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"[{array[i]}] ");
        }
    }

    public static void RandomFill(int[] array, int from = 0, int to = 101)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(from, to);
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
    /// Array37. Дан массив размера N. Найти количество участков, на которых его элементы монотонно возрастают
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
                maxSumOfTwo = maxElement1 + array[i + 1];
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
                    minDiff = Math.Abs(r - (elment1 + elment2));
                }
            }
        }

        Console.WriteLine($"числа сумма которых наиболее близка к {r}, будут {elment1} и {elment2}");
    }

    /// <summary>
    /// Array47◦ Дан целочисленный массив размера N. Найти количество различных элементов в данном массиве.      
    /// </summary>
    public static void Array47()
    {
        int[] array = RandomFill(10, 0, 20);
        Show(array);
        int sameItemCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    sameItemCount++;
                }
            }
        }

        Console.WriteLine($"в массиве {array.Length - sameItemCount} различных элементов");
    }

    /// <summary>
    /// Array48. Дан целочисленный массив размера N. Найти максимальное количество его одинаковых элементов
    /// </summary>
    public static void Array48()
    {
        int[] array = RandomFill(10, 0, 10);
        Show(array);
        int sameItemCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    sameItemCount++;
                    break;
                }
            }
        }

        Console.WriteLine($"в массиве {sameItemCount} одинаковых элементов");
    }

    /// <summary>
    /// Array49. Дан целочисленный массив размера N. Если он является перестановкой, то есть содержит все числа
    /// от 1 до N, то вывести 0; в противном случае вывести номер первого недопустимого элемента
    /// </summary>
    public static void Array49()
    {
        // int[] array = RandomFill(10, 0, 10);
        int[] array = new[] { 1, 2, 3, 4, 6, 80, 5, 7, 9 };
        Show(array);
        int isPermutation = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j] || array[i] > array.Length - 1)
                {
                    isPermutation = array[i];
                    break;
                }
            }
        }

        Console.WriteLine($" {isPermutation} ");
    }

    /// <summary>
    /// Array50. Дан целочисленный массив A размера N, являющийся перестановкой. Найти количество инверсий в данной
    /// перестановке, то есть таких пар элементов AI и AJ , вкоторых большее число находится слева от меньшего:
    /// AI > AJ при I < J
    /// </summary>
    public static void Array50()
    {
        int[] array = new[] { 1, 3, 2, 4, 6, 8, 5, 7, 9 };
        Show(array);
        int inversionCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    inversionCount++;
                }
            }
        }

        Console.WriteLine($" {inversionCount} ");
    }

    /// <summary>
    /// Array51. Даны массивы A и B одинакового размера N. Поменять местами их содержимое и вывести вначале элементы
    /// преобразованного массива A, а затем — элементы преобразованного массива B.
    /// </summary>
    static void Array51()
    {
        int[] arrayA = RandomFill(10, 0, 10);
        ShowInRow(arrayA);
        Console.WriteLine();
        int[] arrayB = RandomFill(10, 0, 10);
        ShowInRow(arrayB);
        Console.WriteLine();
        (arrayA, arrayB) = (arrayB, arrayA);

        ShowInRow(arrayA);
        Console.WriteLine();
        ShowInRow(arrayB);
    }

    /// <summary>
    /// Array52. Дан массив A размера N. Сформировать новый массив B того же размера, элементы которого определяются
    /// следующим образом:BK = 2·AK, если AK < 5,AK/2 в противном случае.
    /// </summary>
    public static void Array52()
    {
        int[] arrayA = RandomFill(10, 0, 11);
        Show(arrayA);
        Console.WriteLine();
        int[] arrayB = new int[arrayA.Length];
        for (int i = 0; i < arrayA.Length; i++)
        {
            arrayB[i] = arrayA[i] < 5 ? arrayA[i] * 2 : arrayA[i] / 2;
        }

        Console.WriteLine();
        Show(arrayB);
    }

    /// <summary>
    /// Array53. Даны два массива A и B одинакового размера N. Сформировать новыймассив C того же размера, каждый
    /// элемент которого равен максимальному из элементов массивов A и B с тем же индексом.
    /// </summary>
    public static void Array53()
    {
        int[] arrayA = RandomFill(10, 0, 10);
        ShowInRow(arrayA);
        Console.WriteLine();
        int[] arrayB = RandomFill(10, 0, 10);
        ShowInRow(arrayB);
        Console.WriteLine();
        int[] arrayC = new int[arrayA.Length];
        for (int i = 0; i < arrayA.Length; i++)
        {
            arrayC[i] = arrayA[i] > arrayB[i] ? arrayA[i] : arrayB[i];
        }

        Console.WriteLine();
        ShowInRow(arrayC);
    }

    /// <summary>
    /// Array54. Дан целочисленный массив A размера N. Переписать в новый целочисленный массив B все четные числа из
    /// исходного массива (в том жепорядке) и вывести размер полученного массива B и его содержимое
    /// </summary>
    public static void Array54()
    {
        int[] arrayA = RandomFill(10, 0, 20);
        Show(arrayA);
        int countEven = 0;
        for (int i = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] % 2 == 0)
                countEven++;
        }

        int[] arrayB = new int[countEven];
        for (int i = 0, j = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] % 2 == 0)
                arrayB[j++] = arrayA[i];
        }

        Console.WriteLine($"Чисел в новом массиве: {countEven}");
        Show(arrayB);
    }

    /// <summary>
    /// Array55. Дан целочисленный массив A размера N (≤ 15). Переписать в новый целочисленный массив B все элементы с
    /// нечетными порядковыми номерами (1, 3, . . .) и вывести размер полученного массива B и его содержимое.
    /// Условный оператор не использовать.
    /// </summary>
    public static void Array55()
    {
        int[] arrayA = RandomFill(15, 0, 50);
        Show(arrayA);
        Console.WriteLine();
        int[] arrayB = new int[arrayA.Length / 2];
        for (int i = 1, j = 0; i < arrayA.Length; i += 2)
        {
            arrayB[j++] = arrayA[i];
        }

        Show(arrayB);
    }

    /// <summary>
    /// Array56. Дан целочисленный массив A размера N (≤ 15). Переписать в новый целочисленный массив B все элементы с
    /// порядковыми номерами, кратными трем (3, 6, . . .), и вывести размер полученного массива B и егосодержимое.
    /// Условный оператор не использовать
    /// </summary>
    public static void Array56()
    {
        int[] arrayA = RandomFill(15, 0, 50);
        Show(arrayA);
        Console.WriteLine();
        int[] arrayB = new int[arrayA.Length / 3];
        for (int i = 2, j = 0; i < arrayA.Length; i += 3)
        {
            arrayB[j++] = arrayA[i];
        }

        Show(arrayB);
    }

    /// <summary>
    /// Array57. Дан целочисленный массив A размера N. Переписать в новый целочисленный массив B того же размера вначале
    /// все элементы исходного массива с четными номерами, а затем — с нечетными: A2, A4, A6, . . ., A1, A3, A5, . . . .
    /// </summary>
    public static void Array57()
    {
        int[] arrayA = RandomFill(10, 0, 50);
        Show(arrayA);
        Console.WriteLine();
        int[] arrayB = new int[arrayA.Length];
        for (int i = 0; i < arrayA.Length; i += 2)
        {
            arrayB[i] = arrayA[i];
        }

        for (int i = 1; i < arrayA.Length; i += 2)
        {
            arrayB[i] = arrayA[i];
        }

        Show(arrayB);
    }

    /// <summary>
    /// Array58. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент
    /// BK равен сумме элементов массива A с номерами от 1 до K
    /// </summary>
    public static void Array58()
    {
        int[] arrayA = RandomFill(10, 0, 10);
        Show(arrayA);
        Console.WriteLine();
        int sum = 0;
        int[] arrayB = new int[arrayA.Length];
        for (int i = 0; i < arrayA.Length; i++)
        {
            sum += arrayA[i];
            arrayB[i] = sum;
        }

        Show(arrayB);
    }

    /// <summary>
    /// Array59. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент
    /// BK равен среднему арифметическому элементов массива A с номерами от 1 до K.
    /// </summary>
    public static void Array59()
    {
        int[] arrayA = RandomFill(10, 0, 10);
        Show(arrayA);
        Console.WriteLine();
        int sum = 0;
        double[] arrayB = new double[arrayA.Length];
        for (int i = 0; i < arrayA.Length; i++)
        {
            sum += arrayA[i];
            arrayB[i] = sum / (i + 1);
        }

        Show(arrayB);
    }

    /// <summary>
    /// Array60◦. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент
    /// BK равен сумме элементов массива A с номерами от K до N.
    /// </summary>
    public static void Array60()
    {
        int[] arrayA = RandomFill(10, 0, 10);
        Show(arrayA);
        Console.WriteLine();
        int sum = 0;
        int[] arrayB = new int[arrayA.Length];
        // for (int i = 0, j = arrayB.Length-1; i < arrayA.Length; i++)
        // {
        //     sum += arrayA[i];
        //     arrayB[j--] = sum;
        // }
        for (int i = arrayA.Length - 1; i >= 0; i--)
        {
            sum += arrayA[i];
            arrayB[i] = sum;
        }

        Show(arrayB);
    }

    /// <summary>
    /// Array61. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент
    /// BK равен среднему арифметическому элементов массива A с номерами от K до N.
    /// </summary>
    public static void Array61()
    {
        int[] arrayA = RandomFill(6, 1, 10);
        Show(arrayA);
        Console.WriteLine();
        int sum = 0;
        int[] arrayB = new int[arrayA.Length];
        // for (int i = 0, j = arrayA.Length-1; i < arrayA.Length ; i++)
        // {
        //     sum += arrayA[i];
        //     arrayB[j--] = sum / (i+1);
        // }
        for (int i = arrayA.Length - 1, j = 1; i >= 0; i--, j++)
        {
            sum += arrayA[i];
            arrayB[i] = sum / j;
        }

        Show(arrayB);
    }

    /// <summary>
    /// Array62. Дан массив A размера N. Сформировать два новых массива B и C: в массив B записать все положительные
    /// элементы массива A, в массив C —все отрицательные (сохраняя исходный порядок следования элементов).
    /// Вывести вначале размер и содержимое массива B, а затем — размер и содержимое массива C
    /// </summary>
    public static void Array62()
    {
        int[] arrayA = RandomFill(10, -10, 10);
        Show(arrayA);
        Console.WriteLine();
        int countPositive = 0, countNegative = 0;
        for (int i = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] > 0)
                countPositive++;
            else if (arrayA[i] < 0)
                countNegative++;
        }

        int[] arrayB = new int[countPositive];
        int[] arrayC = new int[countNegative];
        for (int i = 0, j = 0, k = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] > 0)
            {
                arrayB[j++] = arrayA[i];
            }
            else if (arrayA[i] < 0)
            {
                arrayC[k++] = arrayA[i];
            }
        }

        Console.WriteLine($"элементов в массиве B: {countPositive}");
        Show(arrayB);

        Console.WriteLine($"элементов в массиве С: {countNegative}");
        Show(arrayC);
    }

    /// <summary>
    /// Array63. Даны два массива A и B размера 5, элементы которых упорядочены по возрастанию. Объединить эти массивы так,
    /// чтобы результирующий массив C (размера 10) остался упорядоченным по возрастанию.
    /// </summary>
    // public static void Array63()
    // {
    //     int[] arrayA = new int[] { 1, 20, 50, 60, 90 };
    //     Show(arrayA);
    //     Console.WriteLine();
    //     int[] arrayB = new int[] { 3, 4, 6, 8, 9 };
    //     Show(arrayB);
    //     int[] arrayC = new int [arrayA.Length + arrayB.Length];
    //     for (int i = 0, j = arrayA.Length; i < arrayA.Length; i++)
    //     {
    //         arrayC[i] = arrayA[i];
    //         arrayC[j++] = arrayB[i];
    //     }
    //
    //     for (int i = 0; i < arrayC.Length; i++)
    //     {
    //         for (int j = i + 1; j < arrayC.Length ; j++)
    //         {
    //             if (arrayC[j] < arrayC[i])
    //             {
    //                 (arrayC[j], arrayC[i]) = (arrayC[i], arrayC[j]);
    //             }
    //         }
    //     }
    //
    //     Console.WriteLine();
    //     Show(arrayC);
    // }
    static void Array63()
    {
        int[] arrayA = new int[] { 1, 4, 5, 7, 9 };
        Show(arrayA);
        Console.WriteLine();
        int[] arrayB = new int[] { 2, 3, 6, 8, 10 };
        Show(arrayB);
        int[] arrayC = new int [arrayA.Length + arrayB.Length];
        for (int i = 0, j = 0, k = 0; i < arrayC.Length; i++)
        {
            if (j < arrayA.Length && k < arrayB.Length)
            {
                arrayC[i] = arrayA[j] < arrayB[k] ? arrayA[j++] : arrayC[i] = arrayB[k++];
            }
            else if (j < arrayA.Length)
                arrayC[i] = arrayA[j++];

            else if (k < arrayB.Length)
                arrayC[i] = arrayB[k++];
        }

        Console.WriteLine();
        Show(arrayC);
    }

    //========================= урок 25.10.23 окончен=============================
    /// <summary>
    /// Array65. Дан массив A размера N и целое число K (1 ≤ K ≤ N). Преобразовать массив, увеличив каждый его элемент
    /// на исходное значение элемента AK.
    /// </summary>
    static void Array65()
    {
        int[] array = RandomFill(10, 0, 10);
        Show(array);
        int k = 3;
        for (int i = 0; i < k; i++)
        {
            array[i] += array[k];
        }

        for (int i = k + 1; i < array.Length; i++)
        {
            array[i] += array[k];
        }

        array[k] += array[k];
        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array66. Дан целочисленный массив размера N. Увеличить все четные числа, содержащиеся в массиве, на исходное
    /// значение первого четного числа. Если четные числа в массиве отсутствуют, то оставить массив без изменений.
    /// </summary>
    static void Array66()
    {
        int[] array = RandomFill(10, 1, 10);
        Show(array);
        int firstEvenItem = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                firstEvenItem = array[i];
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                array[i] += firstEvenItem;
            }
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array67. Дан целочисленный массив размера N. Увеличить все нечетные числа, содержащиеся в массиве, на исходное
    /// значение последнего нечетногочисла. Если нечетные числа в массиве отсутствуют, то оставить массив без изменений.
    /// </summary>
    static void Array67()
    {
        int[] array = RandomFill(10, 1, 10);
        Show(array);
        int lastOddItem = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 != 0)
            {
                lastOddItem = array[i];
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                array[i] += lastOddItem;
            }
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array68◦. Дан массив размера N. Поменять местами его минимальный и максимальный элементы.
    /// </summary>
    static void Array68()
    {
        int[] array = RandomFill(10, 0, 50);
        Show(array);
        int maxItem = array[0], maxIndex = 0, minItem = array[0], minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > maxItem)
                {
                    maxItem = array[j];
                    maxIndex = j;
                }
                else if (array[j] < minItem)
                {
                    minItem = array[j];
                    minIndex = j;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"max: {maxItem}   min: {minItem}");

        (array[maxIndex], array[minIndex]) = (array[minIndex], array[maxIndex]);
        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array69. Дан массив размера N (N — четное число). Поменять местами его первый элемент со вторым,
    /// третий — с четвертым и т. д.
    /// </summary>
    static void Array69()
    {
        int[] array = RandomFill(10, 0, 20);
        Show(array);
        for (int i = 0; i < array.Length; i += 2)
        {
            (array[i], array[i + 1]) = (array[i + 1], array[i]);
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array70. Дан массив размера N (N — четное число). Поменять местами первую и вторую половины массива.
    /// </summary>
    static void Array70()
    {
        int[] array = RandomFill(10, 0, 20);
        Show(array);
        for (int i = 0, j = array.Length / 2; i < array.Length / 2; i++, j++)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array71. Дан массив размера N. Поменять порядок его элементов на обратный.
    /// </summary>
    static void Array71()
    {
        int[] array = RandomFill(10, 0, 20);
        Show(array);
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array72. Дан массив A размера N и целые числа K и L (1 ≤ K < L ≤ N). Переставить в обратном порядке элементы
    /// массива, расположенные междуэлементами AK и AL, включая эти элементы.
    /// </summary>
    static void Array72()
    {
        int[] array = RandomFill(10, 0, 50);
        Show(array);
        int k = 3, l = 7;
        for (int i = k, j = l; i <= j; i++, j--)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array73. Дан массив A размера N и целые числа K и L (1 ≤ K < L ≤ N). Переставить в обратном порядке элементы
    /// массива, расположенные междуэлементами AK и AL, не включая эти элементы.
    /// </summary>
    static void Array73()
    {
        int[] array = RandomFill(10, 0, 50);
        Show(array);
        int k = 2, l = 5;
        for (int i = k + 1, j = l - 1; i <= j; i++, j--)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array74. Дан массив размера N. Обнулить элементы массива, расположенные между его минимальным и максимальным
    /// элементами (не включая минимальный и максимальный элементы)
    /// </summary>
    static void Array74()
    {
        int[] array = RandomFill(10, 0, 50);
        Show(array);
        int maxItem = array[0], indexOfMax = 0, minItem = array[0], indexOfMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > maxItem)
                {
                    maxItem = array[j];
                    indexOfMax = j;
                }
                else if (array[j] < minItem)
                {
                    minItem = array[j];
                    indexOfMin = j;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"max:[{indexOfMax}]   min:[{indexOfMin}]");
        if (indexOfMax < indexOfMin)
            (indexOfMax, indexOfMin) = (indexOfMin, indexOfMax);
        {
            for (int i = indexOfMin + 1; i < indexOfMax; i++)
            {
                array[i] = 0;
            }
        }
        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array75. Дан массив размера N. Переставить в обратном порядке элементы массива, расположенные между его
    /// минимальным и максимальным элементами, включая минимальный и максимальный элементы.
    /// </summary>
    static void Array75()
    {
        int[] array = RandomFill(10, 0, 50);
        Show(array);
        int maxItem = array[0], indexOfMax = 0, minItem = array[0], indexOfMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > maxItem)
                {
                    maxItem = array[j];
                    indexOfMax = j;
                }
                else if (array[j] < minItem)
                {
                    minItem = array[j];
                    indexOfMin = j;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"max:[{indexOfMax}]   min:[{indexOfMin}]");
        if (indexOfMax < indexOfMin)
            (indexOfMax, indexOfMin) = (indexOfMin, indexOfMax);

        for (int i = indexOfMin, j = indexOfMax; i < j; i++, j--)
            (array[i], array[j]) = (array[j], array[i]);

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array76. Дан массив размера N. Обнулить все его локальные максимумы (то есть числа, большие своих соседей).
    /// </summary>
    static void Array76()
    {
        int[] array = RandomFill(10, 1, 50);
        Show(array);
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                array[i++] = 0;
            }
        }

        Console.WriteLine();
        Show(array);
    }

    /// <summary>
    /// Array77. Дан массив размера N. Возвести в квадрат все его локальные минимумы (то есть числа, меньшие своих соседей).
    /// </summary>
    static void Array77()
    {
        int[] array = RandomFill(10, 1, 50);
        Show(array);
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] < array[i - 1] && array[i] < array[i + 1])
            {
                array[i] *= array[i];
                i++;
            }
        }

        Console.WriteLine();
        Show(array);
    }

    public static void Main()
    {
        Array77();
        Console.ReadLine();
    }
}