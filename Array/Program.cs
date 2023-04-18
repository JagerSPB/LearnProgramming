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
            // Array5. Дано целое число N (>2). Сформировать и вывести целочисленный массив размера N, содержащий N первых 
            // элементов последовательности чисел Фибоначчи FK: F1 =1, F2 =1, FK =FK−2 +FK−1, K =3,4,....4
            /*
            int n = 10, num1 = 0, num2 = 1, fib = num1 + num2;
            int[] array = new int[n];
            array[0] = num1;
            array[1] = num2;

            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] = {array[i]}");
             */
            // Array6. Даны целые числа N (>2), A и B. Сформировать и вывести целочисленный массив размера N, первый 
            // элемент которого равен A, второй равен B, а каждый последующий элемент равен сумме всех предыдущих.
            /*
            int n = 10, a = 2, b = 3, sum = a + b;
            int[] array = new int[n];
            array[0] = a;
            array[1] = b;
            for (int i = 2; i < array.Length; i++)
            {
                array[i] += sum;
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] = {array[i]}");
            }
            */
            // Array7◦. Дан массив размера N. Вывести его элементы в обратном порядке.
            /*
            int n = 10;
            int[] array = new int[] { 3, 2, 1, 5, 9, 7, 4, 2, 3, 6 };
            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"[{i}] = {array[i]}");
            }
            */
            // Array8. Дан целочисленный массив размера N. Вывести все содержащиеся в данном массиве нечетные числа в
            //     порядке возрастания их индексов, а также их количество K.
            /*
            int[] array = new int[] { 2, 4, 5, 1, 8, 5, 1, 3, 6, 8 };
            int  k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    k++;
                    Console.WriteLine($"[{i}] = {array[i]}");
                }
            }
            Console.WriteLine($"кол-во нечётных чисел в массиве: {k}");
            */
            // Array9. Дан целочисленный массив размера N. Вывести все содержащиеся в данном массиве четные числа в 
            //     порядке убывания их индексов, а также их количество K.
            /*
            int[] array = new int[] { 2, 4, 5, 1, 8, 5, 1, 3, 6, 8 };
            int  k = 0;
            for (int i = array.Length -1; i >=0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    k++;
                    Console.WriteLine($"[{i}] = {array[i]}");
                }
            }
            Console.WriteLine($"кол-во чётных чисел в массиве: {k}");
            */
            // Array10. Дан целочисленный массив размера N. Вывести вначале все содержащиеся в данном массиве четные числа
            //     в порядке возрастания их индексов, а затем  все нечетные числа в порядке убывания их индексов.
            /*
            int[] array = new[] { 2, 4, 5, 1, 3, 5, 1, 3, 6, 8 };
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0) Console.WriteLine($"[{i}] = {array[i]}");

            for (int i = array.Length - 1; i >= 0; i--)
                if (array[i] % 2 != 0) Console.WriteLine($"[{i}] = {array[i]}");
            */
            // Array11. Дан массив A размера N и целое число K (1 ≤ K ≤ N). Вывести элементы массива с порядковыми
            //     номерами, кратными K : AK , A2·K , A3·K , . . . .Условный оператор не использовать.
            /*
            int[] array = new[] { 2, 4, 5, 4, 3, 5, 1, 3, 6, 8 };
            int k = 4;
            for (int i = k; i < array.Length; i+=k)
                Console.WriteLine($"  {array[i]}");
            */
            // Array12. Дан массив A размера N (N — четное число). Вывести его элементы с четными номерами в порядке
            //     возрастания номеров: A2, A4, A6, . . ., AN .Условный оператор не использовать.
            /*
            int[] array = new[] { 2, 4, 5, 1, 3, 5, 1, 3, 6, 8 };
            for (int i = 0; i < array.Length; i+=2)
                Console.WriteLine($"  {array[i]}");
            */
            // Array13. Дан массив A размера N (N — нечетное число). Вывести его элементы с нечетными номерами в порядке 
            //     убывания номеров: AN, AN−2, AN−4, ..., A1. Условный оператор не использовать.
            /*
            int[] array = new[] { 2, 4, 5, 1, 3, 5, 1, 3, 6, 8, 9 };
            for (int i = array.Length - 1; i >= 0; i -= 2)
                Console.WriteLine($"  {array[i]}");
            */
            // Array14. Дан массив A размера N. Вывести вначале его элементы с четными номерами (в порядке возрастания
            // номеров), а затем — элементы с нечетными номерами (также в порядке возрастания номеров):A2, A4, A6, ..., 
            // A1, A3, A5, .... Условный оператор не использовать.
            /*
            int[] array = new[] { 2, 4, 5, 1, 3, 5, 1, 3, 6, 8, 9 };
            for (int i = 2; i < array.Length; i+=2)
                Console.WriteLine($"[{i}] = {array[i]}");
            Console.WriteLine();
            for (int i = 1; i < array.Length; i+=2)
                Console.WriteLine($"[{i}] =  {array[i]}");
            */
            // Array15. Дан массив A размера N. Вывести вначале его элементы с нечетными номерами в порядке возрастания
            //     номеров, а затем — элементы с четными номерами в порядке убывания номеров: A1, A3, A5, ..., A6, A4, A2. 
            //     Условный оператор не использовать.
            /*
            int[] array = new[] { 5, 25, 6, 3, 29, 57, 45, 9, 62, 192 };
            for (int i = 1; i < array.Length; i += 2)
                Console.WriteLine($"[{i}] = {array[i]}");
            Console.WriteLine();
            for (int i = array.Length - 2; i >= 0; i -= 2)
                Console.WriteLine($"[{i}] =  {array[i]}");
            */
            // Array16. Дан массив A размера N. Вывести его элементы в следующем порядке:A1, AN, A2, AN−1, A3, AN−2, ....
            /*
           int[] array = new[] { 5, 225, 6, 3, 29, 57, 45, 9, 62, 192 };
           for (int i = 0; i < array.Length / 2; i++)
               Console.Write($" {array[i]} {array[array.Length - 1 - i]}");
            */
            // Array17.Дан массив A размера N.Вывести его элементы в следующем поряд ке:
            // A1, A2, AN, AN−1, A3, A4, AN−2, AN−3, ....
            /*
            int[] array = new[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110 };
            for (int i = 0; i < array.Length / 2; i += 2)
                Console.Write($" {array[i]} {array[i+1]} {array[array.Length - 1 - i]} {array[array.Length - 2 - i ]}");
            */
            // Array18. Дан массив A ненулевых целых чисел размера 10. Вывести значение первого из тех его элементов AK, 
            //     которые удовлетворяют неравенству AK < A10. Если таких элементов нет, то вывести 0.
            /*
             int[] array = new[] { 41, 22, 33, 44, 55, 66, 77, 88, 99, 30};
             int result = 0;
             for (int i = 0; i < array.Length; i++)
             {
                 if (array[i] < array[array.Length - 1])
                 {
                     result = array[i];
                     break; 
                 }
             }
             // if (result !=0)  Console.WriteLine(result) ;
             // else Console.WriteLine("0") ;
             Console.WriteLine(result != 0 ? result : "0");
            */
            // Array19. Дан целочисленный массив A размера 10. Вывести порядковый номер последнего из тех его элементов 
            //     AK, которые удовлетворяют двойному неравенству A1 < AK < A10. Если таких элементов нет,
            //     то вывести 0.
            /*
            int[] array = new[] { 41, 52, 133, 40, 55, 66, 77, 88, 99, 80};
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <  array[0] && array[i] < array[array.Length - 1])
                {
                    result = array[i];
                    break; 
                }
            }
            Console.WriteLine(result != 0 ? result : "0");
            */
            // Array20.ДанмассивразмераN ицелыечислаK иL(1≤K ≤L≤N).Найти сумму элементов массива с номерами от K до L
            // включительно.
            /*
            int[] array = new[] { 2, 12, 2, 2, 2, 2, 77, 88, 99, 80 };
            int k = 2, l = 5, sum = 0;
            for (int i = k; i <= l; i++)
                sum += array[i];
                
            Console.WriteLine(sum);
            */
        }
    }
}