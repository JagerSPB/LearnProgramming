class Program
{
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
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 2*i;
        }

        for (int i = 1; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public static void Main()
    {
        Array2();
    }
}