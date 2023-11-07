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
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(1); i++)
            Console.Write($"{matrix[k, i]} ");
    }


    public static void Main()
    {
        Matrix7();
        Console.ReadLine();
    }
}