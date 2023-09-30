using System.Runtime.Serialization.Formatters;

namespace Matrix
{
    internal static class Program
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);

        public static void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] = {array[i]}");
        }


        public static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine("]");
            }
        }

        /// <summary>
        /// заполняет матрицу рандомными числами и выводит её
        /// </summary>
        /// <param name="nameOfMatrix"></param>
        public static void RndMatrix(int[,] nameOfMatrix)
        {
            for (int i = 0; i < nameOfMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < nameOfMatrix.GetLength(1); j++)
                {
                    nameOfMatrix[i, j] = rnd.Next(-10, 10);
                }
            }

            ShowMatrix(nameOfMatrix);
        }


        /// <summary>
        /// Matrix1. Даны целые положительные числа M и N. Сформировать целочисленную матрицу размера M × N, у которой
        /// все элементы I-й строки имеют значение 10·I (I = 1,...,M).
        /// </summary>
        public static void Matrix1()
        {
            int rows = 4, columns = 5;
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 10 * (i + 1);
                }
            }

            ShowMatrix(matrix);
        }

        /// <summary>
        /// Matrix2. Даны целые положительные числа M и N. Сформировать целочисленную матрицу размера M × N, у которой
        /// все элементы J-го столбца имеют значение 5·J (J = 1, . . ., N).
        /// </summary>
        public static void Matrix2()
        {
            int[,] matrix = new int[4, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 5 * (j + 1);
                }
            }

            ShowMatrix(matrix);
        }

        /// <summary>
        /// Matrix3. Даны целые положительные числа M, N и набор из M чисел. Сформировать матрицу размера M × N, у
        /// которой в каждом столбце содержатся все числа из исходного набора (в том же порядке).
        /// </summary>
        public static void Matrix3()
        {
            int[] array = { 2, 3, 4 };
            int[,] matrix = new int[array.Length, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[i];
                }
            }

            ShowMatrix(matrix);
        }

        /// <summary>
        /// Matrix4. Даны целые положительные числа M, N и набор из N чисел. Сформировать матрицу размера M × N,
        /// у которой в каждой строке содержатся все числа из исходного набора (в том же порядке).
        /// </summary>
        public static void Matrix4()
        {
            int[] array = { 2, 3, 4, 5 };
            int[,] matrix = new int[5, array.Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[j];
                }
            }

            ShowMatrix(matrix);
        }

        /// <summary>
        /// Matrix5. Даны целые положительные числа M, N, число D и набор из M чисел. Сформировать матрицу размера
        /// M × N, у которой первый столбец совпадает с исходным набором чисел, а элементы каждого следующего
        /// столбца равны сумме соответствующего элемента предыдущего столбца и числа D (в результате каждая
        /// строка матрицы будет содержать элементы арифметической прогрессии).
        /// </summary>
        public static void Matrix5()
        {
            int[] array = { 2, 3, 4, 5 };
            int d = 5;
            int[,] matrix = new int[4, 6];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = array[i];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j - 1] * 2 + d;
                }
            }

            ShowMatrix(matrix);
        }

        /// <summary>
        /// Matrix6. Даны целые положительные числа M, N, число Q и набор из N чисел. Сформировать матрицу размера
        /// M × N, у которой первая строка совпадает с исходным набором чисел, а элементы каждой следующей строки
        /// равны соответствующему элементу предыдущей строки, умноженному на Q (в результате каждый столбец матрицы
        /// будет содержать элементы геометрической прогрессии).
        /// </summary>
        public static void Matrix6()
        {
            int[] array = { 2, 3, 4, 5 };
            int q = 10;
            int[,] matrix = new int[5, array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                matrix[0, i] = array[i];
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i - 1, j] * q;
                }
            }

            ShowMatrix(matrix);
        }

        /// <summary>
        /// Matrix7◦. Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Вывести элементы K-й строки данной матрицы.
        /// </summary>
        public static void Matrix7()
        {
            int[,] matrix = new int[5, 6];
            int k = 4;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            Console.Write("[ ");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write($"{matrix[k - 1, i]} ");
            }

            Console.WriteLine("]");
        }

        /// <summary>
        /// Matrix8. Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). Вывести элементы K-го столбца данной матрицы.
        /// </summary>
        public static void Matrix8()
        {
            int[,] matrix = new int[5, 6];
            int k = 4;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            Console.Write("[ ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, k - 1]} ");
            }

            Console.WriteLine("]");
        }

        /// <summary>
        /// Matrix9. Дана матрица размера M × N. Вывести ее элементы, расположенные в строках с четными номерами
        /// (2, 4, . . .). Вывод элементов производить по строкам, условный оператор не использовать.
        /// </summary>
        public static void Matrix9()
        {
            int[,] matrix = new int[4, 6];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);

            Console.WriteLine(" =============");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 1; j < matrix.GetLength(1); j += 2)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine("]");
            }
        }

        /// <summary>
        /// Matrix10. Дана матрица размера M × N. Вывести ее элементы, расположенные в столбцах с нечетными номерами
        /// (1, 3, . . .). Вывод элементов производить по столбцам, условный оператор не использовать.
        /// </summary>
        public static void Matrix10()
        {
            int[,] matrix = new int[5, 6];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(0); j += 2)
                {
                    Console.Write($"{matrix[j, i]} ");
                }

                Console.WriteLine("]");
            }
        }

        /// <summary>
        /// Matrix11. Дана матрица размера M × N. Вывести ее элементы в следующем порядке: первая строка слева направо,
        /// вторая строка справа налево, третья строка слева направо, четвертая строка справа налево и т. д.
        /// </summary>
        public static void Matrix11()
        {
            int[,] matrix = new int[6, 4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine("]");
                i++;
                Console.Write("[ ");
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine("]");
            }
        }

        /// <summary>
        /// Matrix12. Дана матрица размера M × N. Вывести ее элементы в следующем порядке: первый столбец сверху вниз, второй
        /// столбец снизу вверх, третий столбец сверху вниз, четвертый столбец снизу вверх и т. д.
        /// </summary>
        public static void Matrix12()
        {
            int[,] matrix = new int[4, 4];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        Console.Write($"{matrix[j, i]} ");
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                    {
                        Console.Write($"{matrix[j, i]} ");
                    }
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Matrix13. Дана квадратная матрица A порядка M. Начиная с элемента A1,1, вывести ее элементы следующим
        /// образом («уголками»): все элементы первой строки; элементы последнего столбца, кроме первого
        /// (уже выведенного) элемента; оставшиеся элементы второй строки; оставшиеся элементы предпоследнего столбца
        /// и т. д.; последним выводится элемент AM,1.
        /// </summary>
        public static void Matrix13()
        {
            int[,] matrix = new int[4, 4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");

            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //     Console.Write("[ ");
            //     for (int j = 0; j < matrix.GetLength(1)-i; j++)
            //     {
            //         Console.Write($"{matrix[i, j]} ");
            //     }
            //
            //     // for (int j = matrix.GetLength(0)-1-i; j >0 ; j--)
            //     // {
            //     //     Console.Write($"{matrix[j, i]} ");
            //     // }
            //     
            //     
            //     Console.WriteLine("]");
            //
            // }
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                Console.Write("[ ");
                for (int j = +1; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[j, i]} ");
                }


                Console.WriteLine("]");
            }
        }

        /// <summary>
        /// Matrix17. Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Найти сумму и произведение элементов K-й строки
        /// данной матриц
        /// </summary>
        public static void Matrix17()
        {
            int[,] matrix = new int[3, 4];
            int k = 2, sum = 0, product = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum += matrix[k - 1, i];
                product *= matrix[k - 1, i];
            }

            Console.WriteLine($"cумма чисел в строке '{k}'= {sum}, произведение = {product}.");
        }

        /// <summary>
        /// Matrix18. Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). Найти сумму и произведение элементов
        /// K-го столбца данной матрицы.
        /// </summary>
        public static void Matrix18()
        {
            int[,] matrix = new int[3, 5];
            int k = 3, sum = 0, product = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, k - 1];
                product *= matrix[i, k - 1];
            }


            Console.WriteLine($"cумма чисел в столбце '{k}'= {sum}, произведение = {product}.");
        }

        /// <summary>
        /// Matrix19. Дана матрица размера M × N. Для каждой строки матрицы найти сумму ее элементов.
        /// </summary>
        public static void Matrix19()
        {
            int[,] matrix = new int[3, 4];
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

                Console.WriteLine($"сумма элементов строки: {i + 1} = {sum}");
                sum = 0;
            }
        }

        /// <summary>
        /// Matrix20. Дана матрица размера M × N. Для каждого столбца матрицы найти произведение его элементов.
        /// </summary>
        public static void Matrix20()
        {
            int[,] matrix = new int[3, 4];
            int product = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    product *= matrix[j, i];
                }

                Console.WriteLine($"произведение элементов столбца: {i + 1} = {product}");
                product = 1;
            }
        }

        /// <summary>
        /// Matrix21. Дана матрица размера M × N. Для каждой строки матрицы с нечетным номером (1, 3, ...)
        /// найти среднее арифметическое ее элементов. Условный оператор не использовать.
        /// </summary>
        public static void Matrix21()
        {
            int[,] matrix = new int[8, 4];
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            for (int i = 0; i < matrix.GetLength(0); i += 2)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

                Console.WriteLine($"среднее арифметическое строки: {i + 1} = {sum / matrix.GetLength(1)}");
                sum = 0;
            }
        }

        /// <summary>
        /// Matrix22. Дана матрица размера M × N. Для каждой строки матрицы с нечетным номером (1, 3, ...)
        /// найти среднее арифметическое ее элементов. Условный оператор не использовать.
        /// </summary>
        public static void Matrix22()
        {
            int[,] matrix = new int[4, 7];
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            for (int i = 0; i < matrix.GetLength(1); i += 2)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }

                Console.WriteLine($"сумма столбца: {i + 1} = {sum}");
                sum = 0;
            }
        }

        /// <summary>
        /// Matrix23. Дана матрица размера M × N. В каждой строке матрицы найти минимальный элемент.
        /// </summary>
        public static void Matrix23()
        {
            int[,] matrix = new int[4, 4];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            int min = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        (matrix[i, j], min) = (min, matrix[i, j]);
                    }
                }

                Console.WriteLine($"минимальный элемент строки: {i + 1} = {min}");
                min = matrix[i, 0];
            }
        }

        /// <summary>
        /// Matrix24◦. Дана матрица размера M × N. В каждом столбце матрицы найти максимальный элемент.
        /// </summary>
        public static void Matrix24()
        {
            int[,] matrix = new int[4, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] > max)
                    {
                        (matrix[j, i], max) = (max, matrix[j, i]);
                    }
                }

                Console.WriteLine($"максимальный элемент столбца: {i + 1} = {max}");
                max = matrix[0, i];
            }
        }

        /// <summary>
        /// Matrix25. Дана матрица размера M × N. Найти номер ее строки с наибольшей суммой элементов и вывести данный
        /// номер, а также значение наибольшей суммы.
        /// </summary>
        public static void Matrix25()
        {
            int[,] matrix = new int[4, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            ShowMatrix(matrix);
            Console.WriteLine(" =============");
            int sum = 0, maxSumOfRow = 0, maxRow = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

                if (sum > maxSumOfRow)
                {
                    maxSumOfRow = sum;
                    maxRow = i + 1;
                }

                sum = 0;
            }

            Console.WriteLine($"максимальная сумма строки: {maxRow} = {maxSumOfRow}");
        }

        /// <summary>
        /// Matrix26. Дана матрица размера M × N. Найти номер ее столбца с наименьшим произведением элементов и
        /// вывести данный номер, а также значение наименьшего произведения.
        /// </summary>
        public static void Matrix26()
        {
            int[,] matrix = new int[4, 5];
            RndMatrix(matrix);
            Console.WriteLine(" =============");
            int product = 1, minProduct = Int32.MaxValue, minColumn = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    product *= matrix[j, i];
                }

                if (minProduct > product)
                {
                    minProduct = product;
                    minColumn = i + 1;
                }

                product = 1;
            }

            Console.WriteLine($"колонка с наименьшим произведением элементов = '{minColumn}'," +
                              $"\nминимальное произведение = {minProduct}");
        }

        /// <summary>
        /// Matrix27. Дана матрица размера M × N. Найти максимальный среди минимальных элементов ее строк.
        /// </summary>
        public static void Matrix27()
        {
            int[,] matrix = new int[4, 5];
            RndMatrix(matrix);
            int row = matrix.GetLength(0), columns = matrix.GetLength(1);
            int minItem = Int32.MaxValue, maxItem = Int32.MinValue;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < minItem)
                    {
                        minItem = matrix[i, j];
                    }
                }

                Console.WriteLine($"Минимальный элемент в строке {i + 1} = {minItem}");
                if (minItem > maxItem)
                {
                    maxItem = minItem;
                }
            }

            Console.WriteLine($"Максимальный элемент из минимальных = {maxItem}");
        }

        /// <summary>
        /// Matrix28. Дана матрица размера M × N. Найти минимальный среди максимальных элементов ее столбцов.
        /// </summary>
        public static void Matrix28()
        {
            int[,] matrix = new int[4, 5];
            RndMatrix(matrix);
            int row = matrix.GetLength(0), columns = matrix.GetLength(1);
            int minItem = Int32.MaxValue, maxItem = Int32.MinValue;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (matrix[j, i] > maxItem)
                    {
                        maxItem = matrix[j, i];
                    }
                }

                Console.WriteLine($"Максимальный элемент в строке {i + 1} = {maxItem}");

                if (minItem > maxItem)
                {
                    minItem = maxItem;
                }

                maxItem = Int32.MinValue;
            }

            Console.WriteLine($"Минимальный элемент из максимальных = {minItem}");
        }

        /// <summary>
        /// Matrix29. Дана матрица размера M × N. В каждой ее строке найти количество элементов, меньших среднего
        /// арифметического всех элементов этой строки.
        /// </summary>
        public static void Matrix29()
        {
            int[,] matrix = new int[3, 7];
            int sum = 0, average = 0, count = 0;
            int row = matrix.GetLength(0), columns = matrix.GetLength(1);
            RndMatrix(matrix);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];
                    average = sum / columns;
                }

                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < average)
                    {
                        count++;
                    }
                }

                Console.WriteLine(
                    $"Ср. арифм: {average}, кол-во элементов строки: {i + 1} меньше ср. арифм-ого {count}");
                sum = 0;
                average = 0;
                count = 0;
            }
        }

        /// <summary>
        /// Matrix30. Дана матрица размера M × N. В каждом ее столбце найти количе- ство элементов, больших среднего
        /// арифметического всех элементов этого столбца.
        /// </summary>
        public static void Matrix30()
        {
            int[,] matrix = new int[8, 3];
            int sum = 0, average = 0, count = 0;
            int row = matrix.GetLength(0), columns = matrix.GetLength(1);
            RndMatrix(matrix);
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    sum += matrix[j, i];
                    average = sum / row;
                }

                for (int j = 0; j < row; j++)
                {
                    if (matrix[j, i] > average)
                    {
                        count++;
                    }
                }

                Console.WriteLine(
                    $"Ср. арифм: {average}, кол-во элементов столбца: {i + 1} больше ср. арифм-ого {count}");
                sum = 0;
                average = 0;
                count = 0;
            }
        }

        /// <summary>
        /// Matrix31. Дана матрица размера M × N. Найти номера строки и столбца для элемента матрицы, наиболее близкого
        /// к среднему значению всех ее элементов.
        /// </summary>
        public static void Matrix31()
        {
            int[,] matrix = new int[3, 3];
            RndMatrix(matrix);
            int sum = 0, average = 0, row = matrix.GetLength(0), columns = matrix.GetLength(1);
            int minDiff = int.MaxValue, diff = 0, minRow = 0, minCol = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];
                    average = sum / (row * columns);
                }
            }

            Console.WriteLine($"сум = {sum}, средн = {average}");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    diff = Math.Abs(matrix[i, j] - average);
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            Console.WriteLine(
                $"Элемент матрицы, наиболее близкий к среднему значению всех ее элементов: {matrix[minRow, minCol]}");
            Console.WriteLine($"Номер строки: {minRow}, номер столбца: {minCol}");
        }

        /// <summary>
        /// Matrix32. Дана целочисленная матрица размера M × N. Найти номер первой из ее строк, содержащих равное
        /// количество положительных и отрицательных элементов (нулевые элементы матрицы не учитываются).
        /// Если таких строк нет, то вывести 0.
        /// </summary>
        public static void Matrix32()
        {
            int[,] matrix = new int[6, 6];
            RndMatrix(matrix);
            int row = matrix.GetLength(0), columns = matrix.GetLength(1);
            int countPositive = 0, countNegative = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0) countPositive++;
                    if (matrix[i, j] < 0) countNegative++;
                }

                if (countPositive == countNegative)
                {
                    Console.WriteLine($"Строка {i + 1} содержит одинаковое кол-во отр. и положительных эллементов");
                    Console.WriteLine($"Положительных: {countPositive}, отрицательных: {countNegative}");
                    break;
                }

                countPositive = 0;
                countNegative = 0;
            }

            if (countPositive == 0 || countNegative == 0)
            {
                Console.WriteLine($"Тебе не повезло, тут нет строк, с одинаковым кол-вом отр. и полож. эллементов");
                Console.WriteLine("Результат: 0");
            }
        }

//=====================================================================================
        /// <summary>
        ///Array90. Дан массив размера N и целое число K (1 ≤ K ≤ N). Удалить из массива элемент с порядковым номером K.
        /// </summary>
        public static void RemoveByIndex(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }

            array = newArray;
        }

        /// <summary>
        /// Дан массив размера N и целые числа K и L (1 ≤ K < L ≤ N). Удалить из массива элементы с номерами от K до L
        /// включительно и вывести размер полученного массива и его содержимое.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        public static void RemoveTwoElementByIndex(ref int[] array, int firstIndex, int secondIndex)
        {
            int[] newArray = new int[array.Length - 2];

            for (int i = 0; i < firstIndex; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = firstIndex + 1; i < secondIndex; i++)
            {
                newArray[i - 1] = array[i];
            }

            for (int i = secondIndex + 1; i < array.Length; i++)
            {
                newArray[i - 2] = array[i];
            }

            array = newArray;
        }

        /// <summary>
        /// Array92. Дан целочисленный массив размера N. Удалить из массива все нечетные числа и вывести размер полученного
        /// массива и его содержимое.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveOdd(ref int[] array)
        {
            int oddCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            int[] newArray = new int[array.Length - oddCount];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    newArray[j++] = array[i];
            }

            array = newArray;
        }

        /// <summary>
        /// Array93. Дан целочисленный массив размера N (> 2). Удалить из массива все элементы с четными номерами
        /// (2, 4, . . .). Условный оператор не использовать.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveOddIndex(ref int[] array)
        {
            int[] newArray = new int[array.Length / 2];
            for (int i = 0, j = 0; i < array.Length; i += 2)
            {
                newArray[j++] = array[i + 1];
            }

            array = newArray;
        }

        /// <summary>
        /// Array94. Дан целочисленный массив размера N (> 2). Удалить из массива всеэлементы с нечетными номерами
        /// (1, 3, ...). Условный оператор не использовать.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveEvenIndex(ref int[] array)
        {
            int[] newArray = new int[array.Length / 2];
            for (int i = 0, j = 0; i < array.Length; i += 2)
            {
                newArray[j++] = array[i];
            }

            array = newArray;
        }

        /// <summary>
        /// Array95. Дан целочисленный массив размера N. Удалить из массива все соседние одинаковые элементы,
        /// оставив их первые вхождения.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveAdjacentDuplicates(ref int[] array)
        {
            int dublicatesCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    dublicatesCount++;
                }
            }

            int[] newArray = new int[array.Length - dublicatesCount];
            newArray[0] = array[0];
            for (int i = 1, j = 1; i < array.Length; i++)
            {
                if (array[i - 1] != array[i])
                {
                    newArray[j++] = array[i];
                }
            }

            array = newArray;
        }

        /// <summary>
        /// Array96. Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы, оставив их
        /// первые вхождения.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveDuplicates(ref int[] array)
        {
            int length = array.Length;
            int duplicatesCount = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] == array[j] && array[j] != Int32.MinValue + 1)
                    {
                        array[j] = Int32.MinValue + 1;
                        duplicatesCount++;
                    }
                }
            }

            int[] newArray = new int[length - duplicatesCount];
            for (int i = 0, j = 0; i < length; i++)
            {
                if (array[i] != Int32.MinValue + 1)
                {
                    newArray[j++] = array[i];
                }
            }

            array = newArray;
        }
        // public static void RemoveDuplicates(ref int[] array)
        // {
        //     int length = array.Length;
        //     int duplicatesCount = 0;
        //     for (int i = 0; i < length; i++)
        //     {
        //         for (int j = i + 1; j < length; j++)
        //         {
        //             if (array[i] == array[j])
        //             {
        //                 duplicatesCount++;
        //                 break;
        //             }
        //         }
        //     }
        //
        //     int[] newArray = new int[length - duplicatesCount];
        //     int newIndex = 0;
        //     for (int i = 0; i < length; i++)
        //     {
        //         bool isDuplicate = false;
        //         for (int j = i + 1; j < length; j++)
        //         {
        //             if (array[i] == array[j])
        //             {
        //                 isDuplicate = true;
        //                 break;
        //             }
        //         }
        //
        //         if (!isDuplicate)
        //         {
        //             newArray[newIndex++] = array[i];
        //         }
        //     }
        //
        //     array = newArray;
        // }

        /// <summary>
        /// Array97. Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы,
        /// оставив их последние вхождения.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveDuplicatesLastEntry(ref int[] array)
        {
            int length = array.Length;
            int duplicatesCount = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] == array[j] && array[j] != Int32.MinValue + 1)
                    {
                        array[i] = Int32.MinValue + 1;
                        duplicatesCount++;
                    }
                }
            }

            int[] newArray = new int[length - duplicatesCount];
            for (int i = 0, j = 0; i < length; i++)
            {
                if (array[i] != Int32.MinValue + 1)
                {
                    newArray[j++] = array[i];
                }
            }

            array = newArray;
        }

        /// <summary>
        /// Array98. Дан целочисленный массив размера N. Удалить из массива все элементы, встречающиеся менее трех раз,
        /// и вывести размер полученного массива и его содержимое.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveItemsWithLessThanThreeOccurrences(ref int[] array)
        {
            int length = array.Length;
            int[] newArray = new int[length];
            int item = 0, countFlagged = 0, flag = Int32.MinValue + 1;
            for (int i = 0; i < length; i++)
            {
                newArray[i] = flag;
            }

            for (int i = 0; i < length; i++)
            {
                int countMoreThanThree = 0;
                for (int j = 0; j < length; j++)
                {
                    if (array[i] == array[j])
                        countMoreThanThree++;
                }

                if (countMoreThanThree >= 3)
                    newArray[item++] = array[i];
            }

            for (int i = 0; i < length; i++)
            {
                if (newArray[i] == flag)
                    countFlagged++;
            }

            int[] lastArray = new int[length - countFlagged];
            for (int i = 0, j = 0; i < lastArray.Length; i++)
            {
                lastArray[j++] = newArray[i];
            }

            array = lastArray;
        }

        /// <summary>
        /// Array99. Дан целочисленный массив размера N. Удалить из массива все элементы, встречающиеся более двух раз,
        /// и вывести размер полученного массива и его содержимое.
        /// </summary>
        /// <param name="array"></param>
        public static void removeDuplicatesMoreThanTwo(ref int[] array)
        {
            int length = array.Length;
            int removeCount = 0, duplicateCount = 0, markToRemove = Int32.MinValue + 1;
            for (int i = 0; i < length; i++)
            {
                duplicateCount = 0;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicateCount++;
                    }
                    if (array[i] == array[j] && duplicateCount >= 2)
                    {
                        array[i] = markToRemove;
                        removeCount++;
                    }
                }
            }

            int[] newArray = new int[length - removeCount];
            for (int i = 0, j = 0; i < length; i++)
            {
                if (array[i] != markToRemove)
                {
                    newArray[j++] = array[i];
                }
            }

            array = newArray;
        }
        /// <summary>
        /// Array100. Дан целочисленный массив размера N. Удалить из массива все элементы, встречающиеся ровно два раза,
        /// и вывести размер полученногомассива и его содержимое.
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveDoubleElements(ref int[] array)
        {
            int length = array.Length;
            int removeCount = 0, duplicateCount = 0, markToRemove = Int32.MinValue + 1;
            for (int i = 0; i < length; i++)
            {
                duplicateCount = 0;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicateCount++;
                        array[j] = markToRemove;
                    }
                    if (duplicateCount == 1)
                    {
                        array[i] = markToRemove;
                       break;
                    }
                }
            }
            
            for(int i = 0; i < length; i++)
            {
                if(array[i] == markToRemove)
                {
                    removeCount++;
                }
            }
            
            
            int[] newArray = new int[length - removeCount];
            for (int i = 0, j = 0; i < length; i++)
            {
                if (array[i] != markToRemove)
                {
                    newArray[j++] = array[i];
                }
            }

            array = newArray;
        }

        static void Main()
        {
            // int[] array = { 1,2,3,2,4,5,6,7,8,9,2 };
            // RemoveDoubleElements(ref array);
            // Show(array);
            
            // char c = 'й'; // замените 'A' на символ, который вам требуется
            // int code = c;
            // Console.WriteLine(code);

            int n = 35;
            char c = (char)n;
            Console.WriteLine(c);

        }
    }
}