namespace Array
{
    internal static class Program
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);


        static void Main()
        {
            //=====================================================
            // Console.Write("Введите размер массива: ");
            // int n = Int32.Parse(Console.ReadLine());
            // int[] array = new int[n];
            // for (int i = 0; i < array.Length;)
            //     array[i++] = rnd.Next(100);
            // for (int i = 0; i < array.Length; i++)
            //     Console.WriteLine($"[{i}] = {array[i]}");
            //=====================================================
            // Array1. Дано целое число N (>0). Сформировать и вывести целочисленный массив размера N, содержащий N
            // первых положительных нечетных чисел: 1, 3, 5, . . . .
            /*
            Console.Write("Введите размер массива: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            int oddNum = 1;
            for (int i = 0; i < array.Length; i++, oddNum += 2)
                array[i] = oddNum;
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] = {array[i]}");
            */
            // Array2. Дано целое число N (>0). Сформировать и вывести целочисленный массив размера N, содержащий степени
            //     двойки от первой до N-й: 2, 4, 8, 16, . . . .
            /*
            Console.Write("Введите размер массива: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            int pow2 = 2;
            for (int i = 0; i < array.Length; i++, pow2 *= 2)
                array[i] = pow2;
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] = {array[i]}");
            */
            // Array3. Дано целое число N (> 1), а также первый член A и разность D арифметической прогрессии.Сформировать 
            //     и вывести массив размера N, содержащий N первых членов данной прогрессии: A, A+D, A+2·D, A+3·D,
            /*
            int n = 10, a = 2, d = 3;
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
                array[i] = a + i * d;
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] = {array[i]}");
            */
            // Array4. Дано целое число N (>1), а также первый член A и знаменатель D геометрической прогрессии. 
            // Сформировать и вывести массив размера N, содержащий N первых членов данной прогрессии: A, A·D, A·D2, A·D3, . 
            /*
            int n = 10;
            double a = 2, d = 3;
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
                array[i] = a * Math.Pow(d, i);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] = {array[i]}");
            */
        }
    }
}