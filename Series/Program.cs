namespace Series
{
    internal class Programm
    {
        public static void Main()
        {
            //Series1◦. Даны десять вещественных чисел. Найти их сумму.
            double sum = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.Write($"[{i}] = ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);

        }
    }
}