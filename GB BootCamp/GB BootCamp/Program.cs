// See https://aka.ms/new-console-template for more information

int GetValueByUser(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers1(int n)
{
    for (int i = -n; i <= n; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

string PrintNumbers2(int n)
{
    string output = String.Empty;
    for (int i = -n; i <= n; i++)
    {
        output += $"{i} ";
    }

    return output;
}

string PrintNumbers3(int n)
{
    string output = "0";

    for (int i = 1; i <= n; i++)
    {
        output = $"{-i} " + output + $" {i}";
    }

    return output;
}

void Main1()
{
    int n = GetValueByUser("Enter a number: ");
    string result = PrintNumbers3(n);
    Console.WriteLine(result);
    Console.ReadLine();
}

// int[] GetRangeSum(int[] array, int m)
// {
//     int n = array.Length;
//     int[] t = new int[n - m +1];
//     int index = 0;
//     for (int i = 0; i <= n - m; i++)
//     {
//         for (int j = i; j < i + m; j++)
//         {
//             t[index] += array[j];
//         }
//
//         index++;
//     }
//
//     return t;
// }
int[] GetRangeSum2(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n - m + 1];
    int sum = 0;
    for (int i = 0; i < m; i++) sum += array[i];
    int index = 0;
    t[index++] = sum;
    
    for (int i = 1; i <= n - m; i++)
    {
        sum = sum - array[i - 1] + array[i + m-1];
        t[index++] = sum;
    }

    return t;
}

int[] CreateArray(int size) => new int[size];
string Print(int[] array) => String.Join(" ", array);
void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(0, 10)).ToArray();
int[] numbers = CreateArray(500_0000);
Fill(ref numbers);
//Console.WriteLine(Print(numbers));

int[] sumGroupNumbers = GetRangeSum2(numbers, 100_0000);
Console.WriteLine(Print(sumGroupNumbers));


Console.ReadLine();