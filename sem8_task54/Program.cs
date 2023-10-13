// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] Sort(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0;j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                
                    if (arr[i,j] > arr[i,k])
                    {
                        temp = arr[i,j];
                        arr[i,j] = arr[i,k];
                        arr[i,k] = temp;
                    }
                
            }
        }
    }
    return arr;
}

Console.Clear();
(int m, int n, int min, int max) = Input();
int[,] arr = CreateArr(m, n, min, max);
PrintArr(arr);
Console.WriteLine();
PrintArr(Sort(arr));