namespace Array
{
    internal static class Program
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);

        public static void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] = {array[i]}");
        }

        public static void MyResize(ref int[] array, int newSize)
        {
            int[] newArray = new int [newSize];
            int length = array.Length < newSize ? array.Length : newSize;
            for (int i = 0; i < length; i++)
                newArray[i] = array[i];

            array = newArray;
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
            int[] array = { 11, 71, 7, 3, 7, 7, 13, 23, 8, 8 };
            int sameItemsCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        sameItemsCount++;
                        break;
                    }
                }
            }

            Console.WriteLine($"{array.Length - sameItemsCount}");
        }

        /// <summary>
        /// Array48. Дан целочисленный массив размера N. Найти максимальное количество его одинаковых элементов.
        /// </summary>
        static void Array48()
        {
            int[] array = { 1, 3, 4, 2, 4, 7, 8 };
            int countOfSameUnit = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        countOfSameUnit++;
                        break;
                    }
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
            int[] array = { 1, 9, 8, 7, 6, 6, 4, 3, 5, 10, 11 };
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array.Length || array[i] < 1)
                {
                    Console.WriteLine($"Массив не является перестановкой. Недопустимый элемент: {array[i]}");
                    return;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    result += (array[j] == i + 1) ? 1 : 0;
                    break;
                }
            }

            string message = (result == array.Length)
                ? "Массив является перестановкой."
                : "Массив не является перестановкой.";
            Console.WriteLine(message);
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
            int[] arrayA = { 1, 5, 6, 13, 7, 9, 0, 10, 8 };
            int[] arrayB = { 15, 2, 1, 4, 9, 2, 10, 4, 3 };
            int[] arrayNEW = new int[arrayA.Length];
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] > arrayB[i])
                    arrayNEW[i] = arrayA[i];

                else
                    arrayNEW[i] = arrayB[i];

                Console.WriteLine(arrayNEW[i]);
            }
        }

        /// <summary>
        /// Array54. Дан целочисленный массив A размера N. Переписать в новый целочисленный массив B все четные
        /// числа из исходного массива (в том же порядке) и вывести размер полученного массива B и его содержимое.
        /// </summary>
        static void Array54()
        {
            int[] arrayA = { 1, 2, 6, 4, 5, 1, 7, 8, 9, 11 };
            int evensCount = 0;
            for (int i = 0; i < arrayA.Length; i++)
                if (arrayA[i] % 2 == 0)
                    evensCount++;

            int[] evensArray = new int[evensCount];

            for (int i = 0, j = 0; i < arrayA.Length; i++)
                if (arrayA[i] % 2 == 0)
                    evensArray[j++] = arrayA[i];

            for (int i = 0; i < evensArray.Length; i++)
                Console.Write($"[{evensArray[i]}] ");

            Console.WriteLine($"Всего {evensArray.Length} чётных элементов");
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
            int[] arrayA = { 1, 2, 6, 4, 5, 3, 7, 8, 9, 11, 38 };
            int[] arrayB = new int[arrayA.Length];
            int oddIndex = 0, evenIndex = 0;

            for (int i = 1; i < arrayA.Length; i += 2)
            {
                arrayB[evenIndex] = arrayA[i];
                evenIndex++;
            }

            for (int i = 0; i < arrayA.Length; i += 2)
            {
                arrayB[oddIndex + arrayA.Length / 2] = arrayA[i];
                oddIndex++;
            }

            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.Write($"[{arrayB[i]}]");
            }
        }

        /// <summary>
        /// Array58. Дан массив A размера N. Сформировать новый массив B того жеразмера по следующему правилу:
        /// элемент BK равен сумме элементовмассива A с номерами от 1 до K.
        /// </summary>
        static void Array58()
        {
            int[] arrayA = { 1, 2, 6, 4, 5, 3, 7, 8, 9, 11, 38 };
            int[] arrayB = new int[arrayA.Length];
            int sumOfElementsArrayA = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                sumOfElementsArrayA += arrayA[i];
                arrayB[i] = sumOfElementsArrayA;
                Console.Write($"[{arrayB[i]}]");
            }
        }

        /// <summary>
        /// Array59. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент
        /// BK равен среднему арифметическому элементов массива A с номерами от 1 до K.
        /// </summary>
        static void Array59()
        {
            int[] arrayA = { 1, 3, 6, 4, 2, 6, 8, 9 };
            double[] arrayB = new double[arrayA.Length];
            double average = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                average += arrayA[i];
                arrayB[i] = average / (i + 1);
                Console.Write($"[{Math.Round(arrayB[i], 2)}]");
            }
        }

        /// <summary>
        /// Array60◦. Дан массив A размера N. Сформировать новый массив B того жеразмера по следующему правилу: элемент
        /// BK равен сумме элементомассива A с номерами от K до N.
        /// </summary>
        static void Array60()
        {
            // Array 60 Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу:
            // элемент BK равен сумме элементов массива A с номерами от K до N.

            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int[] b = new int[array.Length];
            for (int i = array.Length - 1, sum = 0; i >= 0; i--)
            {
                sum += array[i];
                b[i] = sum;
            }

            Show(b);
        }

        /// <summary>
        /// Array61. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент
        /// BK равен среднему арифметическому элементов массива A с номерами от K до N.
        /// </summary>
        static void Array61()
        {
            int[] array = { 1, 2, 3, 4, 5, 100 };
            int[] b = new int[array.Length];
            int sum = 0;
            for (int i = array.Length - 1, j = 1; i >= 0; i--, j++)
            {
                sum += array[i];
                b[i] = sum / j;
            }

            Show(b);
        }

        /// <summary>
        /// Array62. Дан массив A размера N. Сформировать два новых массива B и C: в массив B записать все положительные
        /// элементы массива A, в массив C — все отрицательные (сохраняя исходный порядок следования элементов). Вывести
        /// вначале размер и содержимое массива B, а затем — размер и содержимое массива C.
        /// </summary>
        static void Array62()
        {
            int[] arrayA = { 1, 2, 3, 5, 8, 6, 5, 4, 3, 2 };
            int oddCount = 0, evenCount = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] % 2 == 0) evenCount++;
                else oddCount++;
            }

            int[] arrayB = new int[evenCount];
            int[] arrayC = new int[oddCount];

            for (int i = 0, j = 0, k = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] % 2 == 0)
                {
                    arrayB[j] = arrayA[i];
                    j++;
                }
                else
                {
                    arrayC[k] = arrayA[i];
                    k++;
                }
            }

            Show(arrayB);
            Console.WriteLine();
            Show(arrayC);
        }

        /// <summary>
        /// Array63. Даны два массива A и B размера 5, элементы которых упорядочены по возрастанию. Объединить эти
        /// массивы так, чтобы результирующий массив C (размера 10) остался упорядоченным по возрастанию.
        /// </summary>
        static void Array63()
        {
            int[] arrayA = { 10, 40, 60, 80 };
            int[] arrayB = { 2, 3, 50, 70 };
            int[] arrayC = new int [arrayA.Length + arrayB.Length];
            int i = 0, j = 0, k = 0;
            while (i < arrayA.Length && j < arrayB.Length)
            {
                arrayC[k++] = arrayA[i] < arrayB[j] ? arrayA[i++] : arrayB[j++];
                //     if (arrayA[i] < arrayB[j])
                //         arrayC[k++] = arrayA[i++];
                //     else
                //         arrayC[k++] = arrayB[j++];
            }

            while (i < arrayA.Length)
                arrayC[k++] = arrayA[i++];
            while (j < arrayB.Length)
                arrayC[k++] = arrayB[j++];

            Show(arrayC);
        }
        // =====  Ultimate edition  =======
        // static void Array63()
        // {
        //     int[] arrayA = { 5, 6, 7, 8, 10 };
        //     int[] arrayB = { 1, 4, 6, 8, 9 };
        //     int[] arrayC = arrayA.Concat(arrayB).Order().ToArray();
        //
        //     Show(arrayC);
        // }

        /// <summary>
        /// Array64. Даны три целочисленных массива A, B и C размера NA, NB, NC соответственно, элементы которых
        /// упорядочены по убыванию. Объединить эти массивы так, чтобы результирующий целочисленный массив D
        /// (размера NA + NB + NC) остался упорядоченным по убыванию.
        /// </summary>
        static void Array64()
        {
            int[] arrayA = { 900, 70, 56, 45, 31, 30 };
            int[] arrayB = { 185, 100, 89, 25, 9 };
            int[] arrayC = { 300, 260, 240, 39, 19, 12, 3 };
            int[] arrayD = new int [arrayA.Length + arrayB.Length + arrayC.Length];
            int indexA = 0, indexB = 0, indexC = 0, indexD = 0;
            while (indexA < arrayA.Length && indexB < arrayB.Length && indexC < arrayC.Length)
            {
                if (arrayA[indexA] > arrayB[indexB] && arrayA[indexA] > arrayC[indexC])
                    arrayD[indexD++] = arrayA[indexA++];
                else if (arrayB[indexB] > arrayA[indexA] && arrayB[indexB] > arrayC[indexC])
                    arrayD[indexD++] = arrayB[indexB++];
                else
                    arrayD[indexD++] = arrayC[indexC++];
            }

            while (indexA < arrayA.Length && indexB < arrayB.Length)
                arrayD[indexD++] = arrayA[indexA] > arrayB[indexB] ? arrayA[indexA++] : arrayB[indexB++];

            while (indexB < arrayB.Length && indexC < arrayC.Length)
                arrayD[indexD++] = arrayB[indexB] > arrayC[indexC] ? arrayB[indexB++] : arrayC[indexC++];

            while (indexC < arrayC.Length && indexA < arrayA.Length)
                arrayD[indexD++] = arrayC[indexC] > arrayA[indexA] ? arrayC[indexC++] : arrayA[indexA++];

            while (indexA < arrayA.Length)
                arrayD[indexD++] = arrayA[indexA++];
            while (indexB < arrayB.Length)
                arrayD[indexD++] = arrayB[indexB++];
            while (indexC < arrayC.Length)
                arrayD[indexD++] = arrayC[indexC++];

            Show(arrayD);
        }


        // === ultima ====
        // static void Array64()
        // {
        //     int[] arrayA = { 9, 3, 5, 7, 8 };
        //     int[] arrayB = { 1, 4, 6, 8, 9 };
        //     int[] arrayC = { 10, 8, 6, 4, 1 };
        //     int[] arrayD = arrayA.Concat(arrayB).Concat(arrayC).OrderDescending().ToArray();
        //
        //     Show(arrayD);
        // }

        /// <summary>
        /// Array65. Дан массив A размера N и целое число K (1 ≤ K ≤ N). Преобразовать массив, увеличив каждый его
        /// элемент на исходное значение элемента AK .
        /// </summary>
        static void Array65()
        {
            int[] arrayA = { 3, 10, 1, 4, 5, 6 };
            int n = 3;
            for (int i = 0; i < n; i++)
                arrayA[i] += arrayA[n];

            for (int i = n + 1; i < arrayA.Length; i++)
                arrayA[i] += arrayA[n];

            arrayA[n] += arrayA[n];
            Show(arrayA);
        }

        /// <summary>
        /// Array66. Дан целочисленный массив размера N. Увеличить все четные числа, содержащиеся в массиве, на исходное
        /// значение первого четного числа. Если четные числа в массиве отсутствуют, то оставить массив без изменений.
        /// </summary>
        static void Array66()
        {
            int[] arrayA = { 4, 3, 5, 6, 8, 9, 7, 5, 4, 3 };
            int firstEven = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] % 2 == 0)
                {
                    firstEven = arrayA[i];
                    break;
                }
            }

            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] % 2 == 0)
                    arrayA[i] += firstEven;
            }

            Show(arrayA);
        }

        /// <summary>
        /// Array67. Дан целочисленный массив размера N. Увеличить все нечетные числа, содержащиеся в массиве, на
        /// исходное значение последнего нечетного числа. Если нечетные числа в массиве отсутствуют, то оставить
        /// массив без изменений.
        /// </summary>
        static void Array67()
        {
            int[] array = { 2, 3, 5, 3, 68, 987, 21, 1, 6 };
            int lastNotEven = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    lastNotEven = array[i];
                    break;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    array[i] += lastNotEven;
            }

            Show(array);
        }

        /// <summary>
        /// Array68◦. Дан массив размера N. Поменять местами его минимальный и максимальный элементы.
        /// </summary>
        static void Array68()
        {
            int[] array = { 20, 40, 999, 65, 31, 34, 560, 7 };
            int maxItem = 0, indexMax = 0, minItem = array[0], indexMin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxItem)
                {
                    maxItem = array[i];
                    indexMax = i;
                }
                else if (array[i] < minItem)
                {
                    minItem = array[i];
                    indexMin = i;
                }
            }

            (array[indexMax], array[indexMin]) = (array[indexMin], array[indexMax]);

            Show(array);
        }

        /// <summary>
        /// Array69. Дан массив размера N (N — четное число). Поменять местами его первый элемент со вторым,
        /// третий с четвертым и т. д.
        /// </summary>
        static void Array69()
        {
            int[] array = { 2, 3, 4, 6, 8, 5, 2, 4 };
            for (int i = 0; i < array.Length; i += 2)
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }

            Show(array);
        }

        /// <summary>
        /// Array70. Дан массив размера N (N — четное число). Поменять местами первую и вторую половины массива.
        /// </summary>
        static void Array70()
        {
            int[] array = { 2, 3, 17, 8, 7, 4, 16, 9 };
            for (int i = 0; i < array.Length / 2; i++)
            {
                (array[i], array[i + array.Length / 2]) = (array[i + array.Length / 2], array[i]);
            }

            Show(array);
        }

        /// <summary>
        /// Array71. Дан массив размера N. Поменять порядок его элементов на обратный.
        /// </summary>
        static void Array71()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int halfLenght = array.Length / 2;
            for (int i = 0, j = array.Length - 1; i < halfLenght; i++, j--)
            {
                (array[i], array[j]) = (array[j], array[i]);
            }

            Show(array);
        }

        /// <summary>
        /// Array72. Дан массив A размера N и целые числа K и L (1 ≤ K < L ≤ N). Переставить в обратном порядке
        /// элементы массива, расположенные между элементами AK и AL, включая эти элементы.
        /// </summary>
        static void Array72()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 5, l = 8;
            for (int i = k, j = l; i < j; i++, j--)
            {
                (array[i], array[j]) = (array[j], array[i]);
            }

            Show(array);
        }

        /// <summary>
        /// Array73. Дан массив A размера N и целые числа K и L (1 ≤ K < L ≤ N). Переставить в обратном порядке
        /// элементы массива, расположенные междуэлементами AK и AL, не включая эти элементы.
        /// </summary>
        static void Array73()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 2, l = 5;
            for (int i = k + 1, j = l - 1; i < j; i++, j--)
            {
                (array[i], array[j]) = (array[j], array[i]);
            }

            Show(array);
        }

        /// <summary>
        /// Array74. Дан массив размера N. Обнулить элементы массива, расположенные между его минимальным и
        /// максимальным элементами (не включаяминимальный и максимальный элементы).
        /// </summary>
        static void Array74()
        {
            int[] array = { 50, 40, 30, 24, 5, 6, 7, 8, 9, 1 };
            int minItem = array[0], minIndex = 0, maxItem = array[0], maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxItem)
                {
                    maxItem = array[i];
                    maxIndex = i;
                }

                if (array[i] < minItem)
                {
                    minItem = array[i];
                    minIndex = i;
                }
            }

            if (minIndex > maxIndex)
                (minIndex, maxIndex) = (maxIndex, minIndex);

            for (int i = minIndex + 1; i < maxIndex; i++)
                array[i] = 0;

            Show(array);
        }

        /// <summary>
        /// Array75. Дан массив размера N. Переставить в обратном порядке элементы массива, расположенные между его
        /// минимальным и максимальным элементами, включая минимальный и максимальный элементы.
        /// </summary>
        static void Array75()
        {
            int[] array = { 5, 1, 3, 4, 5, 6, 7, 8, 90, 10 };
            int minItem = array[0], minIndex = 0, maxItem = array[0], maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxItem)
                {
                    maxItem = array[i];
                    maxIndex = i;
                }

                if (array[i] < minItem)
                {
                    minItem = array[i];
                    minIndex = i;
                }
            }

            if (minIndex > maxIndex)
                (minIndex, maxIndex) = (maxIndex, minIndex);

            for (int i = minIndex, j = maxIndex; i < j; i++, j--)
            {
                (array[i], array[j]) = (array[j], array[i]);
            }

            Show(array);
        }


        /// <summary>
        /// Array76. Дан массив размера N. Обнулить все его локальные максимумы (то есть числа, большие своих соседей).
        /// </summary>
        static void Array76()
        {
            int[] array = { 2, 3, 50, 45, 40, 6, 8, 76, 3, 5 };
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    array[i] = 0;
                    i++;
                }
            }

            Show(array);
        }

        /// <summary>
        /// Array77. Дан массив размера N. Возвести в квадрат все его локальные минимумы
        /// (то есть числа, меньшие своих соседей).
        /// </summary>
        static void Array77()
        {
            int[] array = { 2, 4, 3, 4, 6, 8, 3, 9, 3 };
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    array[i] *= array[i];
                    i++;
                }
            }

            Show(array);
        }

        /// <summary>
        /// Array78. Дан массив размера N. Заменить каждый элемент массива на среднее арифметическое этого
        /// элемента и его соседей.
        /// </summary>
        static void Array78()
        {
            int[] array = { 2, 4, 3, 4, 6, 5, 3, 7, 3 };
            int sumOfNeighbors = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                sumOfNeighbors = array[i - 1] + array[i] + array[i + 1];
                array[i] = sumOfNeighbors / 3;
            }

            Show(array);
        }

        /// <summary>
        /// Array79. Дан массив размера N. Осуществить сдвиг элементов массива вправо на одну позицию (при этом A1
        /// перейдет в A2, A2 — в A3, ..., AN−1 — в AN, a исходное значение последнего элемента будет потеряно).
        /// Первый элемент полученного массива положить равным 0.
        /// </summary>
        static void Array79()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = 0;
            Show(array);
        }

        /// <summary>
        /// Array80. Дан массив размера N. Осуществить сдвиг элементов массива влево на одну позицию (при этом AN
        /// перейдет в AN−1, AN−1 — в AN−2, ..., A2 — в A1, a исходное значение первого элемента будет потеряно).
        /// Последний элемент полученного массива положить равным 0.
        /// </summary>
        static void Array80()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[^1] = 0;
            //array[array.Length-1] = 0;

            Show(array);
        }

        /// <summary>
        /// Array81. Дан массив размера N и целое число K (1 ≤ K < N). Осуществить сдвиг элементов массива вправо на K
        /// позиций (при этом A1 перейдет в AK+1, A2 — в AK+2, ..., AN−K — в AN, а исходное значение K последних
        /// элементов будет потеряно). Первые K элементов полученного массива положить равными 0.
        /// </summary>
        static void Array81()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int k = 3;
            for (int i = array.Length - 1; i >= k; i--)
            {
                array[i] = array[i - k];
            }

            for (int i = 0; i < k; i++)
            {
                array[i] = 0;
            }

            Show(array);
        }

        /// <summary>
        /// Array82. Дан массив размера N и целое число K (1 ≤ K < N). Осуществить сдвиг элементов массива влево на K
        /// позиций (при этом AN перейдет в AN−K, AN−1 — в AN−K−1, ..., AK+1 — в A1, а исходное значение K первых
        /// элементов будет потеряно). Последние K элементов полученного массива положить равными 0.
        /// </summary>
        static void Array82()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int k = 3;
            for (int i = 0; i < array.Length - k; i++)
                array[i] = array[i + k];

            for (int i = array.Length - k; i < array.Length; i++)
                array[i] = 0;

            Show(array);
        }

        /// <summary>
        /// Array83. Дан массив размера N. Осуществить циклический сдвиг элементов массива вправо на одну позицию
        /// (при этом A1 перейдет в A2, A2 — в A3, . . ., AN —вA1). 
        /// </summary>
        static void Array83()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int lastNum = array[^1];
            for (int i = array.Length - 1; i > 0; i--)
                array[i] = array[i - 1];

            array[0] = lastNum;
            Show(array);
        }

        /// <summary>
        /// Array84. Дан массив размера N. Осуществить циклический сдвиг элементов массива влево на одну позицию
        /// (при этом AN перейдет в AN−1, AN−1 — вAN−2,...,A1 —вAN).
        /// </summary>
        static void Array84()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int firstNum = array[0];
            for (int i = 0; i < array.Length - 1; i++)
                array[i] = array[i + 1];

            array[^1] = firstNum;
            Show(array);
        }

        /// <summary>
        /// Array85. Дан массив A размера N и целое число K (1 ≤ K ≤ 4, K < N). Осуществить циклический сдвиг элементов
        /// массива вправо на K позиций (при этом A1 перейдет в AK+1, A2 — в AK+2, ..., AN — в AK). Допускается
        /// использовать вспомогательный массив из 4 элементов.
        /// </summary>
        static void Array85()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int k = 3;
            int[] arrayB = new int[k];
            for (int i = array.Length - k, j = 0; i < array.Length; i++, j++)
                arrayB[j] = array[i];

            for (int i = array.Length - 1; i >= k; i--)
                array[i] = array[i - k];

            for (int i = 0; i < k; i++)
            {
                array[i] = arrayB[i];
            }

            Show(array);
        }

        /// <summary>
        /// Array86. Дан массив A размера N и целое число K (1 ≤ K ≤ 4, K < N). Осуществить циклический сдвиг элементов
        /// массива влево на K позиций (при этом AN перейдет в AN−K, AN−1 — в AN−K−1, ..., A1 — в AN−K+1).
        /// Допускается использовать вспомогательный массив из 4 элементов.
        /// </summary>
        static void Array86()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int k = 3;
            int[] arrayB = new int[k];
            for (int i = 0; i < k; i++)
                arrayB[i] = array[i];

            for (int i = 0; i < array.Length - k; i++)
                array[i] = array[i + k];

            for (int i = array.Length - k, j = 0; i < array.Length; i++, j++)
                array[i] = arrayB[j];
        }

        /// <summary>
        /// Array87. Дан массив размера N, все элементы которого, кроме первого, упорядочены по возрастанию. Сделать
        /// массив упорядоченным, переместив первый элемент на новую позицию.
        /// </summary>
        static void Array87()
        {
            int[] array = { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 15 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    (array[i + 1], array[i]) = (array[i], array[i + 1]);
            }

            Show(array);
        }

        /// <summary>
        /// Array88. Дан массив размера N, все элементы которого, кроме последнего, упорядочены по возрастанию.
        /// Сделать массив упорядоченным, переместив последний элемент на новую позицию.
        /// </summary>
        static void Array88()
        {
            int[] array = { 3, 4, 5, 6, 7, 8, 9, 10, 12, 6 };
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] < array[i - 1])
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
            }

            Show(array);
        }

        /// <summary>
        /// Array89. Дан массив размера N, все элементы которого, кроме одного, упорядочены по убыванию. Сделать массив
        /// упорядоченным, переместив элемент, нарушающий упорядоченность, на новую позицию.
        /// </summary>
        static void Array89()
        {
            int[] array = { 10, 9, 8, 7, 6, 8, 5, 4, 3, 2, 1 };
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > array[i - 1])
                    (array[i - 1], array[i]) = (array[i], array[i - 1]);
            }

            Show(array);
        }

        /// <summary>
        /// Array90. Дан массив размера N и целое число K (1 ≤ K ≤ N). Удалить из массива элемент с порядковым номером K.
        /// </summary>
        static void Array90()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 6;
            int[] arrayB = new int[array.Length - 1];
            for (int i = 0; i < k - 1; i++)
                arrayB[i] = array[i];

            for (int i = k, j = k - 1; i < array.Length; i++)
                arrayB[j++] = array[i];

            Show(arrayB);
        }

        // "Друг" предложил сместить массив влево начиная с числа к, а вконце использовать метод Resize,
        // что бы избавиться от последнего элемента.
        static void Array90_1()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 5;
            for (int i = k; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }

            System.Array.Resize(ref array, array.Length - 1);
            Show(array);
        }

        // мой вариант 2 без метода Resize
        static void Array90_2()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 6;
            int[] arrayB = new int[array.Length - 1];
            for (int i = k; i < array.Length; i++)
                array[i - 1] = array[i];

            for (int i = 0; i < arrayB.Length; i++)
                arrayB[i] = array[i];

            Show(arrayB);
        }

        /// <summary>
        /// Array91. Дан массив размера N и целые числа K и L (1 ≤ K < L ≤ N). Удалить из массива элементы с номерами
        /// от K до L включительно и вывести размер полученного массива и его содержимое.
        /// </summary>
        static void Array91()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3, l = 6;
            int[] arrayB = new int[array.Length - 1 - (l - k)];
            for (int i = 0; i < k - 1; i++)
                arrayB[i] = array[i];

            for (int i = l, j = k - 1; i < array.Length; i++)
                arrayB[j++] = array[i];
            Console.WriteLine($"Размер нового массива: {array.Length - 1 - (l - k)}");
            Show(arrayB);
        }

        /// <summary>
        /// Array92. Дан целочисленный массив размера N. Удалить из массива все нечетные числа и вывести размер полученного
        /// массива и его содержимое.
        /// </summary>
        static void Array92()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 4, 8, 9, 10 };
            int countEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    countEven++;
            }

            int[] arrayB = new int [countEven];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    arrayB[j++] = array[i];
            }

            Console.WriteLine($"размер нового массива: {countEven}");
            Show(arrayB);
        }

        static void Array92_2()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 4, 8, 9, 10 };
            int[] arrayB = new int [array.Length];
            int countEven = 0;
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arrayB[j++] = array[i];
                    countEven++;
                }
            }

            System.Array.Resize(ref arrayB, countEven);
            Console.WriteLine($"размер нового массива: {countEven}");
            Show(arrayB);
        }

        /// <summary>
        /// Array93. Дан целочисленный массив размера N (> 2). Удалить из массива все элементы с четными номерами
        /// (2, 4, . . .).Условный оператор не использовать.
        /// </summary>
        static void Array93()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrayB = new int [array.Length / 2];
            for (int i = 1, j = 0; i < array.Length; i += 2)
            {
                arrayB[j++] = array[i];
            }

            Show(arrayB);
        }

        /// <summary>
        /// Array94. Дан целочисленный массив размера N (> 2). Удалить из массива все элементы с нечетными номерами
        /// (1, 3, ...). Условный оператор не ис-пользовать.
        /// </summary>
        static void Array94()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrayB = new int [array.Length / 2];
            for (int i = 0, j = 0; i < array.Length; i += 2)
            {
                arrayB[j++] = array[i];
            }

            Show(arrayB);
        }

        /// <summary>
        /// Array95. Дан целочисленный массив размера N. Удалить из массива все соседние одинаковые элементы, оставив
        /// их первые вхождения.
        /// </summary>
        static void Array95()
        {
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 5, 5, 6, 6, 6, 6, 7, 7, 7 };
            int[] arrayB = new int[array.Length];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 || array[i] != array[i - 1])
                    arrayB[newIndex++] = array[i];
            }

            MyResize(ref arrayB, newIndex);
            Show(arrayB);
        }


        /// <summary>
        /// Array96. Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы, оставив их
        /// первые вхождения.
        /// </summary>
        static void Array96()
        {
            int[] array = { 10, 7, 3, 4, 4, 6, 7, 8, 9, 10 };
            int[] arrayB = new int[array.Length];
            int[] dublicate = new int[array.Length];
            int countOfSame = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        dublicate[i] = array[j];
                        countOfSame++;
                        break;
                    }
                }
            }

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (dublicate[i] != array[i])
                    arrayB[j++] = array[i];
            }

            MyResize(ref arrayB, array.Length - countOfSame);
            Show(dublicate);
        }
        /// <summary>
        /// Array97. Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы,
        /// оставив их последние вхождения.
        /// </summary>
        static void Array97()
        {
            int[] array = { 10, 2, 3, 4, 4, 6, 7, 8, 9, 10 };
            int[] arrayB = new int[array.Length];
            int[] dublicate = new int[array.Length];
            int countOfSame = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        dublicate[i] = array[j];
                        countOfSame++;
                        break;
                    }
                }
            }

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (dublicate[i] != array[i])
                    arrayB[j++] = array[i];
            }

            MyResize(ref arrayB, array.Length - countOfSame);
            Show(arrayB);
        }

        static void Main()
        {
            Array96();
        }
    }
}