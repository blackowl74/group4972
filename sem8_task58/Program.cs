// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Создание и заполнение массива
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
(int, int, int, int) Input(string msg)
{
    Console.WriteLine(msg);
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

// Умножение
int[,] Math(int[,] A, int[,]B, int[,] res)
{
    
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                res[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return res;
}




Console.Clear();
(int m1, int n1, int min1, int max1 ) = Input("Введите данные для первой матрицы");
(int m, int n, int min, int max ) = Input("Введите данные для второй матрицы");
int[,] firstArr = CreateArr(m1, n1, min1, max1);
int[,] secondArr = CreateArr(m, n, min, max);
PrintArr(firstArr);
Console.WriteLine();
PrintArr(secondArr);
Console.WriteLine();
if (n1 != m)
{
    Console.WriteLine("Умножение не возможно из-за размера матриц");
}
else
{
    int[,]res = new int[m1, n];
    PrintArr(Math(firstArr, secondArr, res));
}