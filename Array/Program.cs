using System;

namespace Array
{
    internal static class Program
    {
        static void Main()
        {
            //int[] myArray = { 1, 4, 6, 2, 5, 2, 8, 9, 2, 1 };

            int[] myArray = new int[30];
            FullArray(myArray, 1, 999);
            Insert(ref myArray, -5000, 5);
            PrintArray(myArray);
        }

        static void FullArray(int[] array, int startNum, int finishNum)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(startNum, finishNum);
        }

        static void PrintArray(int[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");


            // for (int i = 0; i < array.Length; i++)
            //     Console.Write(array[i] + " ");
        }


        static void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0);
        }

        static void AddLast(ref int[] array, int value)
        {
            Insert(ref array, value, array.Length);
        }


        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];
            array = newArray;
        }
    }
}