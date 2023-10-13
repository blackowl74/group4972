// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Создание и заполнение массива
using System.Diagnostics.CodeAnalysis;

int[,] CreateArr(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

// Прием данных
(int, int, int, int) Input()
{
    System.Console.WriteLine("Введите количество строк в массиве: ");
    int m = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите количество столбцов в массиве: ");
    int n = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите минимальный элемент: ");
    int min = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите максимальный элемент: ");
    int max = int.Parse(Console.ReadLine());
    return (m, n, min, max);
}

// Печать массива
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] MinStr(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
    }
    return sum;
}

int Test(int[] sumStr)
{ 
    int min = sumStr[0];
    int index = 0;
    for (int i = 0;i < sumStr.Length;i++)
    {
        if (sumStr[i] < min)
        {
            min = sumStr[i];
            index = i;
        }
    }
    return index;
}


Console.Clear();
(int m, int n, int min, int max) = Input();
int[,] arr = CreateArr(m, n, min, max);
PrintArr(arr);
Console.WriteLine();
if (m == n)
{
    Console.WriteLine("Массив не прямоугольный");

}
else
{
    Console.WriteLine($"Строка с минимальнй суммой под индексом: {Test(MinStr(arr))}");
}