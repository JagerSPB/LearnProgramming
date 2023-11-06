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
            {
                matrix[i, j] = 5 * j;
            }
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

    public static void Main()
    {
        Matrix4();
        Console.ReadLine();
    }
}