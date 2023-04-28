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
            // Array21. Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N). Найти среднее арифметическое элементов 
            //     массива с номерами от K до L включительно.
            /*
            int[] array = new[] { 1, 12, 20, 11, 32, 2, 77, 88, 99, 80 };
            int k = 2, l = 5, sum = 0;
            for (int i = k; i <= l; i++)
                sum += array[i];

            Console.WriteLine(sum/(l+1-k));
            */
            // Array22. Дан массив размера N и целые числа K и L (1 < K ≤ L ≤ N). Найти сумму всех элементов массива,
            //     кроме элементов с номерами от K до L включительно.
            /*
            int[] array = new[] { 1, 12, 20, 11, 32, 2, 77, 88, 99, 80 };
            int k = 1, l = 9, sum = 0;
            for (int i = 0; i < k; i++)
                sum += array[i];

            for (int i = l; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine(sum);
            */
            // Array23. Дан массив размера N и целые числа K и L (1 < K ≤ L ≤ N). Найти среднее арифметическое всех 
            // элементов массива, кроме элементов с номерами от K до L включительно.
            /*
            int[] array = new[] { 1, 12, 20, 11, 32, 2, 77, 88, 99, 80 };
            int k = 1, l = 9, sum = 0;
            for (int i = 0; i < k; i++)
                sum += array[i];

            for (int i = l; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine(sum / (array.Length - l + k));
            */
            // Array26.Дан целочисленный массив размера N.Проверить, чередуются ли в нем четные и нечетные числа.
            //     Если чередуются, то вывести 0, если нет, то вывести порядковый номер первого элемента, нарушающего
            // закономерность.
            /*
            int[] array = new[] { 1, 112, 21, 12, 3, 2, 70, 88, 99, 80 };
            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i] % 2 == 0 && array[i - 1] % 2 == 0) ||
                    (array[i] % 2 != 0 && array[i - 1] % 2 != 0))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("0");
            */
            // Array27. Дан массив ненулевых целых чисел размера N. Проверить, череду- ются ли в нем положительные и 
            //     отрицательные числа. Если чередуются, то вывести 0, если нет, то вывести порядковый номер первого 
            //     элемента, нарушающего закономерность.
            /*
            int[] array = new[] { -1, 112, -21, 12, 3, 2, -70, 88, -99, 80 };
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > 0 && array[i] > 0 || array[i - 1] < 0 && array[i] < 0)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(0);
            */
            //Array28. Дан массив A размера N. Найти минимальный элемент из его элементов с четными номерами: A2, A4, A6, . . .
            /*
            int[] array = new [] { 10, 112, 21, 12, 3, 29, 70, 88, 99, 80 };
            int min = 0;
            for (int i = 2; i < array.Length; i+=2)
            {
                if (array[i] < array[i - 1])
                    min = array[i];
            }
            Console.WriteLine(min);
            */
            // Array29. Дан массив A размера N. Найти максимальный элемент из его элементов с нечетными номерами: A1, A3, A5, . . .
            /*
            int[] array = new[] { 12, 334, 56, 78, 43, 47, 22, 45, 51, 89 };
            int max = array[1];
            for (int i = 1; i < array.Length; i += 2)
            {
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine(max);
            */
            // Array30. Дан массив размера N. Найти номера тех элементов массива, которые больше своего правого соседа,
            //     и количество таких элементов. Найденные номера выводить в порядке их возрастания.
            /*
            int[] array = new[] { 12, 34, 56, 78, 43, 47, 22, 45, 51, 89 };
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1] > array[i])
                {
                    sum ++;
                    Console.WriteLine($"[{i-1}]");
                }
            }
            Console.WriteLine($"кол-во {sum}");
            */
            // Array31. Дан массив размера N. Найти номера тех элементов массива, которые больше своего левого соседа, 
            //     и количество таких элементов. Найденные номера выводить в порядке их убывания.
            /*
            int[] array = new[] { 12, 10, 56, 78, 43, 47, 22, 45, 51, 9 };
            int sum = 0;
            for (int i = array[^1]; i > 0; i--)
            {
                if (array[i - 1] < array[i])
                {
                    Console.WriteLine($"[{i}]");
                    sum++;
                }
            }

            Console.WriteLine($"кол-во {sum}");
            */

            // Array32. Дан массив размера N. Найти номер его первого локального минимума (локальный минимум — это элемент,
            //     который меньше любого из своих соседей).
            /*
            int[] array = new[] { 12, 100, 506, 78, 43, 47, 220, 45, 51, 9 };
            for (int i = 1; i < array[^1]; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    Console.WriteLine(i); return;
                }
            }
            */
            // Array33. Дан массив размера N. Найти номер его последнего локального максимума (локальный максимум — 
            // это элемент, который больше любого из своих соседей).
            /*
            int[] array = new[] { 12, 100, 506, 78, 43, 47, 220, 45, 51, 9 };
            for (int i = array[^1]; i > 0; i--)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.WriteLine(i); return;        
                }
            }
            */
            // Array34. Дан массив размера N. Найти максимальный из его локальных минимумов
            /*
            int[] array = new[] { 12, 100, 506, 78, 30, 47, 220, 28, 51, 9 };
            int tempIndex = array[0], localMaxOfMin = 0;
            for (int i = 1; i < array[^1]; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    if (tempIndex < array[i])
                    {
                        localMaxOfMin = i;
                        tempIndex = array[i];
                    }
                }
            }
            Console.WriteLine(localMaxOfMin);
            */
            //Array35. Дан массив размера N. Найти минимальный из его локальных максимумов 
            /*
            int[] array = new[] { 12, 10, 50, 38, 30, 47, 2200, 28, 51, 9 };
            int tempIndex = Int32.MaxValue, localMinOfMax = 0;
            for (int i = 1; i < array[^1]; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    if (tempIndex > array[i])
                    {
                        tempIndex = array[i];
                        localMinOfMax = i;
                    }
                }
            }
            Console.WriteLine(localMinOfMax);
            */
            // Array37. Дан массив размера N. Найти количество участков, на которых его элементы монотонно возрастают.
            /*
            int[] array = new[] { 12, 15, 50, 38, 30, 47, 2200, 28, 51, 9 };
            int count = 0;
            for (int i = 1; i < array[^1]; i++)
            {
                if (array[i-1] < array[i] && array[i] < array[i+1])
                    count++;
            }
            Console.WriteLine(count);
            */
            // Array38. Дан массив размера N. Найти количество участков, на которых его элементы монотонно убывают.
            /*
            int[] array = new[] { 12, 15, 50, 38, 30, 47, 2200, 28, 51, 9 };
            int count = 0;
            for (int i = 1; i < array[^1]; i++)
            {
                if (array[i - 1] > array[i] && array[i] > array[i + 1])
                    count++;
            }
            Console.WriteLine(count);
            */
            // Array40. Дано число R и массив A размера N. Найти элемент массива, который наиболее близок к числу R
            //     (то есть такой элемент AK, для которого величина |AK − R| является минимальной). 
            /*
            int[] array = new[] { 12, 15, 50, 38, 30, 47, 220, 28, 51, 9 };
            int r = 180, minDiffR = Math.Abs(r - array[0]), result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (minDiffR > Math.Abs(r - array[i]))
                {
                    minDiffR = Math.Abs(r - array[i]);
                    result = array[i];
                }
            }
            Console.WriteLine($"Елемент массива: {result}, разница между заданным числом {r} будет: {minDiffR}  ");
            */
            //=============================================================================
            //=============================================================================
            Array57();
        }

        /// <summary>
        ///    Array40. Дано число R и массив A размера N. Найти элемент массива, который наиболее близок к числу R
        /// (то есть такой элемент AK, для которого величина |AK − R| является минимальной). 
        /// </summary>
        static void Array40()
        {
            int[] array = new[] { 12, 15, 50, 38, 30, 47, 220, 28, 51, 9 };
            int r = 180, minDiffR = Math.Abs(r - array[0]), result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (minDiffR > Math.Abs(r - array[i]))
                {
                    minDiffR = Math.Abs(r - array[i]);
                    result = array[i];
                }
            }

            Console.WriteLine($"Елемент массива: {result}, разница между заданным числом {r} будет: {minDiffR}  ");
        }

        /// <summary>
        /// Дан массив размера N. Найти количество участков, на которых его элементы монотонно возрастают.
        /// </summary>
        static void Array37()
        {
            //int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // int[] array = new[] { 1, 2, 3, 4, 5, 1, 7, 8, 9, 10 };
            //int[] array = new[] { 1, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] array = new[] { 1, 2, 3, 1, 2, 3, 1, 9, 5, 6 };
            int count = 0;
            bool isGrowing = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (isGrowing == false && array[i] < array[i + 1])
                {
                    count++;
                    isGrowing = true;
                }

                if (array[i] > array[i + 1])
                {
                    isGrowing = false;
                }
            }

            Console.WriteLine(count);
        }

        /// <summary>
        /// Array38. Дан массив размера N. Найти количество участков, на которых его элементы монотонно убывают.
        /// </summary>
        static void Array38()
        {
            //int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // int[] array = new[] { 1, 2, 3, 4, 5, 1, 7, 8, 9, 10 };
            int[] array = new[] { 10, 9, 8, 7, 6, 10, 9, 8, 2, 1 };
            // int[] array = new[] { 10, 9, 7, 10, 6, 3, 1, 9, 8, 6 };
            int count = 0;
            bool isGrowing = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (isGrowing == false && array[i] > array[i + 1])
                {
                    count++;
                    isGrowing = true;
                }

                if (array[i] < array[i + 1])
                {
                    isGrowing = false;
                }
            }

            Console.WriteLine(count);
        }

        /// <summary>
        /// Array41. Дан массив размера N. Найти два соседних элемента, сумма которых максимальна, и вывести эти
        /// элементы в порядке возрастания их индексов.
        /// </summary>
        static void Array41()
        {
            int[] array = new[] { 1, 2, 3, 4, 1, 2, 1, 2, 9, 4 };
            int sumOfTwoElements = array[0] + array[1], maxElem1 = array[0], maxElem2 = array[1];
            ;
            for (int i = 2; i < array.Length - 1; i++)
            {
                if (sumOfTwoElements < (array[i] + array[i + 1]))
                {
                    sumOfTwoElements = array[i] + array[i + 1];
                    maxElem1 = array[i];
                    maxElem2 = array[i + 1];
                }
            }

            Console.WriteLine($"1: {maxElem1}  2:  {maxElem2}");
        }

        /// <summary>
        /// Array42. Дано число R и массив размера N. Найти два соседних элемента массива, сумма которых наиболее
        /// близка к числу R, и вывести эти элементы в порядке возрастания их индексов
        /// </summary>
        static void Array42()
        {
            int[] array = new[] { 12, 15, 50, 38, 30, 47, 220, 28, 51, 9 };
            int r = 186,
                sumOfTwoElements = array[0] + array[1],
                minDiffR = Math.Abs(r - sumOfTwoElements),
                element1 = 0,
                element2 = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                sumOfTwoElements = array[i] + array[i + 1];

                if (minDiffR > Math.Abs(r - sumOfTwoElements))
                {
                    minDiffR = Math.Abs(r - sumOfTwoElements);
                    element1 = array[i];
                    element2 = array[i + 1];
                }
            }

            Console.WriteLine($"Первый элемент массива: {element1}, Второй элемент массива: {element2}, {minDiffR}");
        }

        /// <summary>
        ///Array44. Дан целочисленный массив размера N, содержащий ровно два одинаковых элемента. Найти номера
        /// одинаковых элементов и вывести этиномера в порядке возрастания.
        /// </summary>
        static void Array44()
        {
            int[] array = new[] { 1, 5, 3, 40, 17, 72, 18, 1, 55, 45 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine($"[{i}]  [{j}]");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Дан массив размера N. Найти номера двух ближайших элементовиз этого массива (то есть элементов с наименьшим
        /// модулем разности) ивывести эти номера в порядке возрастания.
        /// </summary>
        static void Array45()
        {
            int[] array = new[] { 1, 5, 9, 40, 17, 72, 18, 33, 55, 45 };
            int minDiff = Math.Abs(array[0] - array[1]);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int diff = Math.Abs(array[i] - array[j]);
                    if (diff < minDiff)
                    {
                        minDiff = diff;

                        Console.WriteLine($"[{j}]  [{i}]");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Array46. Дано число R и массив размера N. Найти два различных элемента массива, сумма которых наиболее
        /// близка к числу R, и вывести эти элементы в порядке возрастания их индексов
        /// </summary>
        static void Array46()
        {
            int[] array = { 11, 4, 6, 5, 3, 7, 13, 23, 16, 33 };
            int r = 12, item1 = array[0], item2 = array[1];
            int diff = Math.Abs(r - (array[0] + array[1]));
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (diff > Math.Abs(r - (array[i] + array[j])))
                    {
                        diff = Math.Abs(r - (array[i] + array[j]));
                        item1 = array[i];
                        item2 = array[j];
                    }
                }
            }

            Console.WriteLine($"элемент1: [{item1}], элемент2: [{item2}]");
        }

        /// <summary>
        /// Array47◦. Дан целочисленный массив размера N. Найти количество различных элементов в данном массиве.
        /// </summary>
        static void Array47()
        {
            int[] array = { 11, 71, 7, 3, 7, 7, 13, 23, 16, 8 }; // задаём массив
            int countOfDifferentUnit = 0; // переменная для посчёта различных элементов
            bool isDifferentNuber = true; // флаг для переключения если найден совпадающий элемент
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++) // во вложенном цикле сравниваем все числа в массиве
                {
                    isDifferentNuber = true; // в начале итерации скидывание флага на true
                    if (array[i] == array[j]) // если находим одинаковые элементы
                    {
                        isDifferentNuber = false; // переключаем флаг на false и прерываем внутренний цикл
                        break;
                    }
                }

                if (isDifferentNuber) //  если флаг true 
                {
                    countOfDifferentUnit++; // считаем уникальный и неповторимый элемент
                }
            }

            Console.WriteLine($"{countOfDifferentUnit}"); // выводим результат 
        }

        /// <summary>
        /// Array48. Дан целочисленный массив размера N. Найти максимальное количество его одинаковых элементов.
        /// </summary>
        static void Array48()
        {
            int[] array = { 11, 71, 72, 3, 74, 6, 75, 7, 16, 8 }; // задаём массив
            int countOfSameUnit = 0; // переменная для посчёта различных элементов
            bool isSameNumber = false; // флаг для переключения если найден совпадающий элемент
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    isSameNumber = false;
                    if (array[i] == array[j])
                    {
                        isSameNumber = true;
                        break;
                    }
                }

                if (isSameNumber)
                {
                    countOfSameUnit++;
                }
            }

            Console.WriteLine(countOfSameUnit + 1);
        }

        /// <summary>
        /// Array49. Дан целочисленный массив размера N. Если он является перестановкой, то есть содержит все числа
        /// от 1 до N, то вывести 0; в противном случае вывести номер первого недопустимого элемента.
        /// </summary>
        static void Array49()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            // int[] array = { 1, 31, 52, 7, 5, 8, 32, 2, 3, 4, 19 };
            int[] permutation = new int [array.Length];
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                permutation[i] = i + 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] != permutation[j])
                    {
                        Console.WriteLine("массив не является перестановкой");
                        return;
                    }
                }
            }

            Console.WriteLine(result);
        }

        /// <summary>
        /// Array51. Даны массивы A и B одинакового размера N. Поменять местами их содержимое и вывести вначале
        /// элементы преобразованного массива A, а затем — элементы преобразованного массива B.
        /// </summary>
        static void Array51()
        {
            int[] arrayA = { 2, 4, 6, 4, 7, 9, 0, 7, 8 }; // Создаем массив arrayA и заполняем его значениями
            int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Создаем массив arrayB и заполняем его значениями
            //int tempNum = 0;
            for (int i = 0; i < arrayA.Length; i++) // Проходим по всем элементам массива arrayA
            {
                // тут я хотел показать, новый для меня способ, переноса значений без использования временной переменной
                // с помощью оператора ^=
                arrayA[i] ^= arrayB[i];
                arrayB[i] ^= arrayA[i];
                arrayA[i] ^= arrayB[i];
                // tempNum = arrayA[i]; // перенос значений классическим способом через переменнную tempNum
                // arrayA[i] = arrayB[i];
                // arrayB[i] = tempNum;

                // Выводим значение текущего элемента массива arrayA и arrayB
                Console.WriteLine($"{arrayA[i]}    {arrayB[i]}");
            }
        }

        /// <summary>
        /// Array52. Дан массив A размера N. Сформировать новый массив B того же размера, элементы которого
        /// определяются следующим образом BK = 2·AK, если AK < 5 AK/2 в противном случае.
        /// </summary>
        static void Array52()
        {
            // Создаем массив arrayA и заполняем его значениями
            int[] arrayA = { 2, 4, 6, 4, 7, 9, 0, 7, 8 };

            // Создаем новый массив arrayB той же длины, что и arrayA
            int[] arrayB = new int [arrayA.Length];

            // Проходим по всем элементам массива arrayA
            for (int i = 0; i < arrayA.Length; i++)
            {
                // Если текущий элемент меньше 5, то умножаем его на 2 и записываем в arrayB
                if (arrayA[i] < 5)
                    arrayB[i] = arrayA[i] * 2;

                // Если текущий элемент больше 5, то делим его на 2 и записываем в arrayB
                if (arrayA[i] > 5)
                    arrayB[i] = arrayA[i] / 2;

                // Выводим значение текущего элемента массива arrayB
                Console.WriteLine(arrayB[i]);
            }
        }

        /// <summary>
        /// Array53. Даны два массива A и B одинакового размера N. Сформировать новый массив C того же размера, каждый
        /// элемент которого равен максимальному из элементов массивов A и B с тем же индексом.
        /// </summary>
        static void Array53()
        {
            // Создаем массив arrayA и заполняем его значениями
            int[] arrayA = { 1, 5, 6, 13, 7, 9, 0, 10, 8 };
            // Создаем новый массив arrayB той же длины, что и arrayA
            int[] arrayB = { 15, 2, 1, 4, 9, 2, 10, 4, 3 };
            // Создаём пустой массив arrayNEW той же длины, что и предидущие два
            int[] arrayNEW = new int[arrayA.Length];
            // В цикле for находим наибольшее значение текущего елемента из двух массивов arrayA и arrayB и записываем в
            // новый массив arrayNEW
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] > arrayB[i])
                    arrayNEW[i] = arrayA[i];

                else
                    arrayNEW[i] = arrayB[i];

                Console.WriteLine(arrayNEW[i]); // Вывод на консоль  
            }
        }

        /// <summary>
        /// Array54. Дан целочисленный массив A размера N. Переписать в новый целочисленный массив B все четные
        /// числа из исходного массива (в том же порядке) и вывести размер полученного массива B и его содержимое.
        /// </summary>
        static void Array54()
        {
            int[] arrayA = { 1, 2, 6, 4, 5, 1, 7, 8, 9, 11 };
            int[] arrayB = new int[arrayA.Length];
            int countOfEvenNumbers = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] % 2 == 0)
                {
                    arrayB[countOfEvenNumbers] = arrayA[i];
                    countOfEvenNumbers++;
                }
            }

            for (int i = 0; i < countOfEvenNumbers; i++)
            {
                Console.Write($"[{arrayB[i]}] ");
            }

            Console.WriteLine($" всего {countOfEvenNumbers} чётных элементов");
        }

        /// <summary>
        /// Array55. Дан целочисленный массив A размера N (≤ 15). Переписать в новый целочисленный массив B все элементы
        /// с нечетными порядковыми номерами (1, 3, . . .) и вывести размер полученного массива B и его содержимое.
        /// Условный оператор не использовать.
        /// </summary>
        static void Array55()
        {
            int[] arrayA = { 1, 2, 6, 4, 5, 1, 7, 8, 9, 11 };
            int[] arrayB = new int[arrayA.Length];
            int countOfOddItems = 0;
            for (int i = 1; i < arrayA.Length; i += 2)
            {
                arrayB[countOfOddItems] = arrayA[i];
                countOfOddItems++;
            }

            for (int i = 0; i < countOfOddItems; i++)
            {
                Console.Write($"[{arrayB[i]}]");
            }

            Console.WriteLine($" размер {countOfOddItems} элементов");
        }

        /// <summary>
        /// Array56. Дан целочисленный массив A размера N (≤ 15). Переписать в новый целочисленный массив B все
        /// элементы с порядковыми номерами, кратными трем (3, 6, ...), и вывести размер полученного массива B и его
        /// содержимое. Условный оператор не использовать.
        /// </summary>
        static void Array56()
        {
            int[] arrayA = { 1, 2, 6, 4, 5, 3, 7, 8, 9, 11 };
            int[] arrayB = new int[arrayA.Length];
            int countOfOddItems = 0;
            for (int i = 2; i < arrayA.Length; i += 3)
            {
                arrayB[countOfOddItems] = arrayA[i];
                countOfOddItems++;
            }

            for (int i = 0; i < countOfOddItems; i++)
            {
                Console.Write($"[{arrayB[i]}]");
            }

            Console.WriteLine($" всего: {countOfOddItems} ");
        }

        /// <summary>
        /// Array57. Дан целочисленный массив A размера N. Переписать в новый целочисленный массив B того же размера
        /// вначале все элементы исходного массива с четными номерами, а затем с нечетными:
        /// A2, A4, A6, ..., A1, A3, A5, .... Условный оператор не использовать.
        /// </summary>
        static void Array57()
        {
            int[] arrayA = { 1, 2, 6, 4, 5, 3, 7, 8, 9, 11 };
            int[] arrayB = new int[arrayA.Length];
            int oddIndex = 0, evenIndex = 0;

            for (int i = 1; i < arrayA.Length; i += 2)
            {
                arrayB[evenIndex] = arrayA[i];
                evenIndex++;
            }

            for (int i = 0; i < arrayA.Length; i += 2)
            {
                arrayB[oddIndex + arrayA.Length/2] = arrayA[i];
                oddIndex++;
            }

            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.Write($"[{arrayB[i]}]");
            }
        }
    }
}