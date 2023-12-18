using System;

class Program
{
    private static Random rnd = new Random();

    public static void ShowMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[ ");

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine("]");
        }

        Console.WriteLine();
    }


    public static void ShowMatrix(double[,] matrix)
    {
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"[{Math.Round(matrix[i, j], 2)}] ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static int[,] MatrixRandomFill(int rows, int columns, int from = 1, int to = 100)
    {
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(from, to);
            }
        }

        return matrix;
    }

    static double[,] MatrixRandomFill(int columns, int rows)
    {
        double[,] matrix = new double[rows, columns];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.NextDouble();
            }
        }

        return matrix;
    }

    /// <summary>
    /// Matrix1. Даны целые положительные числа M и N. Сформировать целочисленную матрицу размера M × N, у которой
    /// все элементы I-й строки имеют значение 10·I (I = 1, . . ., M).
    /// </summary>
    static void Matrix1()
    {
        int[,] matrix = new int[4, 5];
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 10 * i;
            }
        }

        ShowMatrix(matrix);
    }

    /// <summary>
    /// Matrix2. Даны целые положительные числа M и N. Сформировать целочисленную матрицу размера M × N, у которой
    /// все элементы J-го столбцаимеют значение 5·J (J = 1, . . ., N).
    /// </summary>
    static void Matrix2()
    {
        int[,] matrix = new int[4, 5];
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = 5 * j;
        }

        ShowMatrix(matrix);
    }

    /// <summary>
    /// Matrix3. Даны целые положительные числа M, N и набор из M чисел. Сформировать матрицу размера M × N, у которой в
    /// каждом столбце содержатсявсе числа из исходного набора (в том же порядке).
    /// </summary>
    static void Matrix3()
    {
        int m = 4, n = 5;
        int[] mNumbers = { 4, 2, 3, 7 };
        int[,] matrix = new int[m, n];
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = mNumbers[i];
            }
        }

        ShowMatrix(matrix);
    }

    /// <summary>
    /// Matrix4. Даны целые положительные числа M, N и набор из N чисел. Сформировать матрицу размера M × N, у которой
    /// в каждой строке содержатсявсе числа из исходного набора (в том же порядке).
    /// </summary>
    static void Matrix4()
    {
        int m = 4, n = 5;
        int[] nNumbers = { 4, 2, 3, 7, 5 };
        int[,] matrix = new int[m, n];
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = nNumbers[j];
            }
        }

        ShowMatrix(matrix);
    }

    /// <summary>
    /// Matrix5. Даны целые положительные числа M, N, число D и набор из M чисел. Сформировать матрицу размера M × N, у
    /// которой первый столбец совпадает с исходным набором чисел, а элементы каждого следующего столбца равны сумме
    /// соответствующего элемента предыдущего столбцаи числа D (в результате каждая строка матрицы будет содержать
    /// элементы арифметической прогрессии)
    /// </summary>
    static void Matrix5()
    {
        int m = 5, n = 6, d = 10;
        int[] mNumbers = { 1, 2, 3, 4, 10 };
        int[,] matrix = new int[m, n];
        for (int i = 0; i < matrix.GetLength(0); i++)
            matrix[i, 0] = mNumbers[i];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
                matrix[i, j] = matrix[i, j - 1] * 2 + d;
        }

        ShowMatrix(matrix);
    }

    /// <summary>
    /// Matrix6. Даны целые положительные числа M, N, число Q и набор из N чисел. Сформировать матрицу размера M × N, у
    /// которой первая строка совпадает с исходным набором чисел, а элементы каждой следующей строки равны
    /// соответствующему элементу предыдущей строки, умноженному на Q(в результате каждый столбец матрицы будет
    /// содержать элементы геометрической прогрессии).
    /// </summary>
    static void Matrix6()
    {
        int m = 5, n = 6, q = 10;
        int[] nNumbers = { 1, 2, 3, 4, 5, 6 };
        int[,] matrix = new int[m, n];
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = nNumbers[j];
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = matrix[i - 1, j] * q;
        }

        ShowMatrix(matrix);
    }

    /// <summary>
    /// Matrix7◦. Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Вывести элементы K-й строки данной матрицы.
    /// </summary>
    static void Matrix7()
    {
        int k = 2;
        int[,] matrix = MatrixRandomFill(6, 5, 0, 100);
        ShowMatrix(matrix);
        Console.WriteLine($"\nЧисла в строке {k}\n");

        for (int i = 0; i < matrix.GetLength(1); i++)
            Console.Write($"{matrix[k - 1, i]} ");
    }

    /// <summary>
    /// Matrix8. Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). Вывести элементы K-го столбца данной матрицы.
    /// </summary>
    static void Matrix8()
    {
        int k = 2;
        int[,] matrix = MatrixRandomFill(6, 5, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine($"\nЧисла в столбце {k}\n");

        for (int i = 0; i < matrix.GetLength(0); i++)
            Console.Write($"{matrix[i, k - 1]} ");
    }

    /// <summary>
    /// Matrix9. Дана матрица размера M × N. Вывести ее элементы, расположенныев строках с четными номерами (2, 4, . . .).
    /// Вывод элементов производитьпо строкам, условный оператор не использовать.
    /// </summary>
    static void Matrix9()
    {
        int[,] matrix = MatrixRandomFill(8, 6, 0, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 1; i < matrix.GetLength(0); i += 2)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Matrix10. Дана матрица размера M × N. Вывести ее элементы, расположенные в столбцах с нечетными номерами
    /// (1, 3, . . .). Вывод элементов производить по столбцам, условный оператор не использовать.
    /// </summary>
    static void Matrix10()
    {
        int[,] matrix = MatrixRandomFill(8, 7, 0, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j += 2)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Matrix11. Дана матрица размера M × N. Вывести ее элементы в следующем порядке: первая строка слева направо,
    /// вторая строка справа налево, третья строка слева направо, четвертая строка справа налево и т. д.
    /// </summary>
    static void Matrix11()
    {
        int[,] matrix = MatrixRandomFill(9, 7, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
            else if (i % 2 != 0)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }

    // static void Matrix11()//Этот вариант работает только если Rows чётное
    // {
    //     int[,] matrix = MatrixRandomFill(6, 7, 0, 100);
    //     ShowMatrix(matrix);
    //     Console.WriteLine();
    //     for (int i = 0; i < matrix.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < matrix.GetLength(1); j++)
    //         {
    //             Console.Write($"{matrix[i, j]} ");
    //         }
    //
    //         Console.WriteLine();
    //
    //         i++;
    //         for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
    //         {
    //             Console.Write($"{matrix[i, j]} ");
    //         }
    //
    //         Console.WriteLine();
    //     }
    // }
    /// <summary>
    /// Matrix12. Дана матрица размера M × N. Вывести ее элементы в следующем порядке: первый столбец сверху вниз,
    /// второй столбец снизу вверх, третий столбец сверху вниз, четвертый столбец снизу вверх и т. д.
    /// </summary>
    // static void Matrix12_1()
    // {
    //     int[,] matrix = MatrixRandomFill(7, 6, 10, 100);
    //     ShowMatrix(matrix);
    //     Console.WriteLine();
    //     for (int i = 0; i < matrix.GetLength(0); i++)
    //     {
    //     
    //             for (int j = 0; j < matrix.GetLength(1); j +=2)
    //             {
    //                 Console.Write($"{matrix[i, j]} ");
    //             }
    //             
    //             Console.WriteLine();
    //             
    //     }
    //     Console.WriteLine();
    //     
    //     for (int i = matrix.GetLength(0)-1; i >=0 ; i--)
    //     {
    //     
    //         for (int j = 1; j < matrix.GetLength(1); j +=2)
    //         {
    //             Console.Write($"{matrix[i, j]} ");
    //         }
    //             
    //         Console.WriteLine();
    //         
    //     }
    //     
    //     
    // }
    static void Matrix12()
    {
        int[,] matrix = MatrixRandomFill(7, 6, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j % 2 == 0) //Если номер столбца четный, выводим с начала до конца
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    Console.Write($"{matrix[i, j]} ");
            }
            else //если номер столбца нечетный, выводим с конца до начала
            {
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                    Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Matrix15. Дана квадратная матрица A порядка M (M — нечетное число). Начиная с элемента A1,1 и перемещаясь по
    /// часовой стрелке, вывести всеее элементы по спирали: первая строка, последний столбец, последняястрока в обратном
    /// порядке, первый столбец в обратном порядке, оставшиеся элементы второй строки и т. д.;
    /// последним выводится центральныйэлемент матрицы.
    /// </summary>
    static void Matrix15()
    {
        // int m = 7;
        // int[,] matrix = MatrixRandomFill(m, m, 10, 100);
        // ShowMatrix(matrix);
        //


        int M = 5;

        int[,] A = new int[M, M];

        // Заполнение матрицы для примера
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < M; j++)
            {
                A[i, j] = i * M + j + 1;
            }
        }

        ShowMatrix(A);
        // Выводим элементы матрицы по спирали
        int top = 0, bottom = M - 1;
        int left = 0, right = M - 1;

        while (true)
        {
            for (int i = left; i <= right; i++)
            {
                Console.Write(A[top, i]);
            }

            top++;
            Console.WriteLine();
            if (top > bottom) break;

            for (int i = top; i <= bottom; i++)
            {
                Console.Write(A[i, right]);
            }

            right--;
            Console.WriteLine();
            if (left > right) break;

            for (int i = right; i >= left; i--)
            {
                Console.Write(A[bottom, i]);
            }

            bottom--;
            Console.WriteLine();
            if (top > bottom) break;

            for (int i = bottom; i >= top; i--)
            {
                Console.Write(A[i, left]);
            }

            left++;
            if (left > right) break;
        }


        // if (i == 0)
        // {
        //     for (int j = 0; j < matrix.GetLength(1); j++)
        //     {
        //         Console.Write($"{matrix[0, j]} ");
        //     }
        // }
        //
        // Console.WriteLine();
        // if (i == 1)
        // {
        //     for (int j = 1; j < matrix.GetLength(0); j++)
        //     {
        //         Console.Write($"{matrix[j, m - 1]} ");
        //     }
        // }
        //
        // Console.WriteLine();
        // if (i == 2)
        // {
        //     for (int j = matrix.GetLength(0) - i; j >= 0; j--)
        //     {
        //         Console.Write($"{matrix[m - 1, j]} ");
        //     }
        // }
        //
        // Console.WriteLine();
        // if (i == 3)
        // {
        //     for (int j = matrix.GetLength(0) - 2; j > 0; j--)
        //     {
        //         Console.Write($"{matrix[j, 0]} ");
        //     }
        // }
        //
        // Console.WriteLine();
        // if (i == 4)
        // {
        //     for (int j = 1; j < matrix.GetLength(1) - 1; j++)
        //     {
        //         Console.Write($"{matrix[1, j]} ");
        //     }
        // }
    }

    ///Matrix17. Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Найти сумму и произведение элементов
    /// K-й строки данной матрицы
    static void Matrix17()
    {
        int k = 2, sum = 0, product = 1;
        int[,] matrix = MatrixRandomFill(4, 3, 10, 100);
        ShowMatrix(matrix);
        for (int i = 0; i < k - 1; i++)
        {
            sum += matrix[k - 1, i];
            product *= matrix[k - 1, i];
        }

        Console.WriteLine($"Сумма элементов столбца {k} = {sum}, а произведение = {product}");
    }

    /// <summary>
    /// Matrix18. Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). Найти сумму и произведение элементов K-го
    /// столбца данной матрицы.
    /// </summary>
    static void Matrix18()
    {
        int k = 2, sum = 0, product = 1;
        int[,] matrix = MatrixRandomFill(4, 4, 10, 100);
        ShowMatrix(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, k - 1];
            product *= matrix[i, k - 1];
        }

        Console.WriteLine($"Сумма элементов строки {k} = {sum}, а произведение = {product}");
    }

    //===============================Урок 08.11.2023 закончен====================================
    /// <summary>
    /// Matrix19. Дана матрица размера M × N. Для каждой строки матрицы найти сумму ее элементов.
    /// </summary>
    static void Matrix19()
    {
        int k = 2, sum = 0;
        int[,] matrix = MatrixRandomFill(4, 4, 10, 100);
        ShowMatrix(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }

            Console.WriteLine($"Сумма элементов строки {i} = {sum} ");
        }
    }

    /// <summary>
    /// Matrix20. Дана матрица размера M × N. Для каждого столбца матрицы найти произведение его элементов.
    /// </summary>
    static void Matrix20()
    {
        int product = 1;
        int[,] matrix = MatrixRandomFill(3, 4, 10, 100);
        ShowMatrix(matrix);
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            product = 1;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                product *= matrix[j, i];
            }

            Console.WriteLine($"Произведение элементов столбца {i} = {product}");
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Matrix21. Дана матрица размера M × N. Для каждой строки матрицы с нечетным номером (1, 3, . . .) найти
    /// среднее арифметическое ее элементов.Условный оператор не использовать.
    /// </summary>
    static void Matrix21()
    {
        int m = 7, n = 3, sum = 0;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 1; i < matrix.GetLength(0); i += 2)
        {
            sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }

            Console.WriteLine($"Среднее арифметическое строки {i} = {sum / n} ");
        }
    }

    /// <summary>
    /// Matrix22. Дана матрица размера M × N. Для каждого столбца матрицы с четным номером (2, 4, . . .) найти сумму его
    /// элементов. Условный оператор не использовать.
    /// </summary>
    static void Matrix22()
    {
        int m = 4, n = 8, sum = 0;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 2; i < matrix.GetLength(1); i += 2)
        {
            sum = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                sum += matrix[j, i];
            }

            Console.WriteLine($"Сумма столбца {i} = {sum} ");
        }
    }

    /// <summary>
    ///Matrix23. Дана матрица размера M × N. В каждой строке матрицы найти минимальный элемент
    /// </summary>
    static void Matrix23()
    {
        int m = 7, n = 6;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        int minItem;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            minItem = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (minItem > matrix[i, j])
                    minItem = matrix[i, j];
            }

            Console.WriteLine($"минимальный элемент строки {i} = {minItem} ");
        }
    }

    /// <summary>
    /// Matrix24◦. Дана матрица размера M × N. В каждом столбце матрицы найти максимальный элемент
    /// </summary>
    static void Matrix24()
    {
        int m = 7, n = 6;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        int maxItem;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            maxItem = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (maxItem < matrix[j, i])
                    maxItem = matrix[j, i];
            }

            Console.WriteLine($"максимальный элемент столбца {i} = {maxItem} ");
        }
    }

    /// <summary>
    /// Matrix25. Дана матрица размера M × N. Найти номер ее строки с наибольшей суммой элементов и вывести данный
    /// номер, а также значение наибольшей суммы
    /// </summary>
    static void Matrix25()
    {
        int m = 6, n = 3, rowMaxSum = 0, sum = 0, maxRow = 0;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }

            if (rowMaxSum < sum)
            {
                rowMaxSum = sum;
                maxRow = i;
            }
        }

        Console.WriteLine($"номер строки с максимальной суммой {rowMaxSum}  ->  {maxRow + 1} ");
    }

    /// <summary>
    /// Matrix26. Дана матрица размера M × N. Найти номер ее столбца с наименьшим произведением элементов и вывести
    /// данный номер, а также значение наименьшего произведения.
    /// </summary>
    static void Matrix26()
    {
        int[,] array = MatrixRandomFill(3, 5, 10, 100);
        ShowMatrix(array);
        Console.WriteLine();
        int minProduct = int.MaxValue, minCol = 0, product = 1;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            product = 1;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                product *= array[j, i];
            }

            if (minProduct > product)
            {
                minProduct = product;
                minCol = i;
            }
        }

        Console.WriteLine($"номер столбца с минимальным произведением {minProduct}  ->  {minCol + 1} ");
    }

    /// <summary>
    /// Matrix27. Дана матрица размера M × N. Найти максимальный среди минимальных элементов ее строк
    /// </summary>
    static void Matrix27()
    {
        int m = 6, n = 5;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        int minItem = matrix[0, 0], maxOfMinItem = matrix[0, 0];
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            minItem = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < minItem)
                    minItem = matrix[i, j];
            }

            if (minItem > maxOfMinItem)
                maxOfMinItem = minItem;
            Console.WriteLine(minItem);
        }

        Console.WriteLine($"максимальный элемент среди минимальных элементов строк ->  {maxOfMinItem} ");
    }

    /// <summary>
    /// Matrix28. Дана матрица размера M × N. Найти минимальный среди максимальных элементов ее столбцов.
    /// </summary>
    static void Matrix28()
    {
        int m = 5, n = 5;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        int maxItem = matrix[0, 0], minOfMaxItem = Int32.MaxValue;
        ShowMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            maxItem = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] > maxItem)
                    maxItem = matrix[j, i];
            }

            if (maxItem < minOfMaxItem)
                minOfMaxItem = maxItem;
            Console.WriteLine(maxItem);
        }

        Console.WriteLine();
        Console.WriteLine($"минимальный среди максимальных элементов столбцов ->  {minOfMaxItem} ");
    }

    /// <summary>
    /// Matrix29. Дана матрица размера M × N. В каждой ее строке найти количество элементов, меньших среднего
    /// арифметического всех элементов этой строки.
    /// </summary>
    static void Matrix29()
    {
        int m = 7, n = 5, countMin = 0, sum = 0;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            countMin = 0;
            sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < sum / matrix.GetLength(1))
                {
                    countMin++;
                }
            }

            Console.WriteLine($"в строке {i + 1} элементов меньше среднего арифметического -> {countMin} ");
        }
    }

    /// <summary>
    /// Matrix30. Дана матрица размера M × N. В каждом ее столбце найти количество элементов, больших среднего
    /// арифметического всех элементов этого столбца.
    /// </summary>
    static void Matrix30()
    {
        int m = 7, n = 5, countMax = 0, sum = 0;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            countMax = 0;
            sum = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                sum += matrix[j, i];
            }

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] > sum / matrix.GetLength(0))
                {
                    countMax++;
                }
            }

            Console.WriteLine($"В столбце {i + 1} элементов больше среднего арифметического -> {countMax} ");
        }
    }

    /// <summary>
    /// Matrix31. Дана матрица размера M × N. Найти номера строки и столбца для элемента матрицы, наиболее близкого к
    /// среднему значению всех ее элементов. 
    /// </summary>
    static void Matrix31()
    {
        int m = 5, n = 6, sum = 0, midlOfAll, minDiff = int.MaxValue, minRow = 0, minCol = 0;
        int[,] matrix = MatrixRandomFill(m, n, 10, 100);
        ShowMatrix(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }

        midlOfAll = sum / (m * n);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j] - midlOfAll) < minDiff)
                {
                    minDiff = Math.Abs(matrix[i, j] - midlOfAll);
                    minRow = i + 1;
                    minCol = j + 1;
                }
            }
        }

        Console.WriteLine($"Среднее {midlOfAll} Ряд {minRow}, Колонка {minCol}");
    }
    //====================Урок окончен===================

    /// <summary>
    /// Matrix32. Дана целочисленная матрица размера M × N. Найти номер первой из ее строк, содержащих равное количество
    /// положительных и отрицательных элементов (нулевые элементы матрицы не учитываются). Если таких строк нет, то вывести 0.
    /// </summary>
    static void Matrix32()
    {
        int[,] matrix = MatrixRandomFill(6, 6, -10, 10);
        ShowMatrix(matrix);
        int countPositive = 0, countNegative = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            countPositive = 0;
            countNegative = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    countPositive++;
                }
                else if (matrix[i, j] < 0)
                {
                    countNegative++;
                }
            }

            if (countNegative == countPositive)
            {
                Console.WriteLine(
                    $"В строке {i + 1} содержатся одинаковое количество положительных и отрицательных элементов");
                break;
            }

            if (i == matrix.GetLength(0) - 1)
            {
                Console.WriteLine($"\n0");
            }
        }
    }

    /// <summary>
    /// Matrix33. Дана целочисленная матрица размера M × N. Найти номер последнего из ее столбцов, содержащих равное
    /// количество положительных иотрицательных элементов (нулевые элементы матрицы не учитываются).
    /// Если таких столбцов нет, то вывести 0.
    /// </summary>
    static void Matrix33()
    {
        int[,] matrix = MatrixRandomFill(6, 6, -100, 100);
        ShowMatrix(matrix);
        int countPositive = 0, countNegative = 0;
        for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
        {
            countPositive = 0;
            countNegative = 0;
            for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
            {
                if (matrix[j, i] > 0)
                {
                    countPositive++;
                }
                else if (matrix[j, i] < 0)
                {
                    countNegative++;
                }
            }

            if (countNegative == countPositive)
            {
                Console.WriteLine(
                    $"В столбце {i + 1} содержится одинаковое количество положительных и отрицательных элементов");
                return;
            }
        }

        if (countNegative != countPositive) ;
        {
            Console.WriteLine($"\n0");
        }
    }

    /// <summary>
    /// Matrix34. Дана целочисленная матрица размера M × N. Найти номер последней из ее строк, содержащих только четные
    /// числа. Если таких строк нет, то вывести 0.
    /// </summary>
    static void Matrix34()
    {
        int[,] matrix = MatrixRandomFill(4, 4, 4, 10);
        ShowMatrix(matrix);
        int evenCount = 0;
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            evenCount = 0;

            for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    evenCount++;
                }
            }

            if (evenCount == matrix.GetLength(0))
            {
                Console.WriteLine(
                    $"В строке {i + 1} содержатся только четные числа");
                break;
            }

            if (i == 0)
            {
                Console.WriteLine($"\n0");
            }
        }
    }

    //====================Урок окончен===================
    /// <summary>
    /// Matrix35. Дана целочисленная матрица размера M × N. Найти номер первого из ее столбцов, содержащих только
    /// нечетные числа. Если таких столбцовнет, то вывести 0.
    /// </summary>
    static void Matrix35()
    {
        int[,] matrix = MatrixRandomFill(4, 4, 1, 10);
        ShowMatrix(matrix);
        int oddCount = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            oddCount = 0;

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] % 2 != 0)
                    oddCount++;
            }

            if (oddCount == matrix.GetLength(0))
            {
                Console.WriteLine($"В столбце {i + 1} содержатся только нечетные числа");
                return;
            }

            if (i == matrix.GetLength(1) - 1)
            {
                Console.WriteLine($"\n0");
            }
        }
    }

    /// <summary>
    /// Matrix36. Дана целочисленная матрица размера M × N, элементы которой могут принимать значения от 0 до 100.
    /// Различные строки матрицы назовем похожими, если совпадают множества чисел, встречающихся в этих строках.
    /// Найти количество строк, похожих на первую строку данной матрицы
    /// </summary>
    static void Matrix36()
    {
        int[,] matrix = MatrixRandomFill(6, 3, 1, 3);
        ShowMatrix(matrix);
        bool isSimilar = false, rowSimilar;
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            rowSimilar = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != matrix[0, j])
                {
                    rowSimilar = false;
                    break;
                }
            }

            if (rowSimilar)
            {
                Console.WriteLine($"Строка {i + 1} похожа на первую строку данной матрицы");
                isSimilar = true;
            }
        }

        if (!isSimilar)
        {
            Console.WriteLine($"\n0");
        }
    }

    /// <summary>
    /// Matrix42. Дана матрица размера M × N. Найти количество ее строк, элементы которых упорядочены по возрастанию.
    /// </summary>
    static void Matrix42()
    {
        int[,] matrix = MatrixRandomFill(9, 4, 1, 10);
        ShowMatrix(matrix);
        int countGrowingRows = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool isGrowing = true;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])
                    isGrowing = false;
            }

            if (isGrowing)
            {
                Console.WriteLine($"строка {i + 1} упорядочена по возрастанию");
                countGrowingRows++;
            }
        }

        Console.WriteLine($"Всего упорядочено по возрастанию строк -> {countGrowingRows}");
    }

    /// <summary>
    /// Matrix44. Дана матрица размера M × N. Найти минимальный среди элементов тех строк, которые упорядочены либо по
    /// возрастанию, либо по убыванию. Если упорядоченные строки в матрице отсутствуют, то вывести 0.
    /// </summary>
    static void Matrix44()
    {
        int[,] matrix = MatrixRandomFill(9, 4, 1, 20);
        ShowMatrix(matrix);
        int minElement = int.MaxValue;
        bool isGrowing = true, isDecreasing = true;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            isGrowing = true;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])
                {
                    isGrowing = false;
                    break;
                }
            }

            if (isGrowing)
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] < minElement)
                        minElement = matrix[i, k];
                }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            isDecreasing = true;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    isDecreasing = false;
                    break;
                }
            }

            if (isDecreasing)
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] < minElement)
                        minElement = matrix[i, k];
                }
        }

        if (minElement == int.MaxValue)
            Console.WriteLine($"\n0");
        else
            Console.WriteLine($"Минимальный элемент в упорядоченных строках {minElement}");
    }

    /// <summary>
    /// Matrix46. Дана целочисленная матрица размера M × N. Найти элемент, являющийся максимальным в своей строке и
    /// минимальным в своем столбце.Если такой элемент отсутствует, то вывести 0.
    /// </summary>
    static void Matrix46() //надо проверить
    {
        int[,] matrix = MatrixRandomFill(6, 5, 10, 100);
        ShowMatrix(matrix);
        int maxElement = int.MinValue, minElement = int.MaxValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > maxElement)
                    maxElement = matrix[i, j];

                if (matrix[i, j] < minElement)
                    minElement = matrix[i, j];
            }
        }

        if (maxElement == int.MinValue || minElement == int.MaxValue)
            Console.WriteLine($"\n0");
        else
            Console.WriteLine(
                $"Максимальный элемент в своей строке {maxElement}\nМинимальный элемент в своем столбце {minElement}");
    }

    /// <summary>
    /// Matrix47. Дана матрица размера M × N и целые числа K1 и K2 (1 ≤ K1; K2 ≤ M). Поменять местами строки
    /// матрицы с номерами K1 и K2.
    /// </summary>
    static void Matrix47()
    {
        int[,] matrix = MatrixRandomFill(7, 5, 10, 100);
        ShowMatrix(matrix);
        int k1 = 0, k2 = 6;
        for (int i = k1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                {
                    (matrix[k1, j], matrix[k2, j]) = (matrix[k2, j], matrix[k1, j]);
                }
            }
        }
        
        Console.WriteLine($"Меняем местами строки матрицы с номерами {k1} и {k2}");
        ShowMatrix(matrix);
    }

    /// <summary>
    /// Matrix48. Дана матрица размера M × N и целые числа K1 и K2 (1 ≤ K1; K2 ≤ N). Поменять местами столбцы
    /// матрицы с номерами K1 и K2.
    /// </summary>
    static void Matrix48()
    {
        int[,] matrix = MatrixRandomFill(7, 5, 10, 100);
        ShowMatrix(matrix);
        int k1 = 2, k2 = 4;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = k1; j < matrix.GetLength(1); j++)
            {
                (matrix[i, k1], matrix[i, k2]) = (matrix[i, k2], matrix[i, k1]);
            }
        }

        Console.WriteLine($"Меняем местами столбцы матрицы с номерами {k1} и {k2}");
        ShowMatrix(matrix);
    }

    public static void Main()
    {
        Matrix48();
        Console.ReadLine();
    }
}