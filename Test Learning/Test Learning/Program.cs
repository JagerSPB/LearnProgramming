using System;
using System.Linq;

class Programm
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };


    static void Test1()
    {
        DaysOfWeek day = DaysOfWeek.Monday;
        Console.WriteLine((int)day + 1);
    }

    static void Test2()
    {
        int sum = 1, max = 6, i = 2;
        while (i <= max)
        {
            sum *= i;
            i++;
        }
        Console.WriteLine(sum);
    }

    static void Main()
    {
        Test2();
        Console.ReadLine();
    }
}