namespace Matrix
{
    internal static class Program
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);

        public static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine("]");
            }
        }

        // public static int[,] FullRndMatrix(int rows, int columns, int lower, int upper)
        // {
        //     int[,]matrix = new int[rows, columns];
        //     for (int i = 0; i < matrix.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matrix.GetLength(1); j++)
        //         {
        //             matrix[i, j] = rnd.Next(lower, upper);
        //         }
        //     }
        //     return matrix;
        // }

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
            
            for (int i = 0,k=0; i < matrix.GetLength(0); i ++)
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
        
        static void Main()
        {
            Matrix11();
        }
    }
}