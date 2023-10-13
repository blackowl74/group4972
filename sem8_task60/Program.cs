
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Создание и заполнение массива
int[,,] CreateArr(int m, int n, int l)
{

    int[,,] arr = new int[m, n, l];
    // создание массива с случайными не повторяющимися числами
    int[] numbs = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
    a: numbs[i] = new Random().Next(10, 100);
        for (int j = numbs.Length - 1; j > 0; j--)
        {
            // Проверка
            if (numbs[i] == numbs[j] && i != j) goto a;
        }
    }
    // Помещаем в трехмерный массив числа.
    int d = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {

                arr[i, j, k] = numbs[d];
                d++;

            }
        }
    }
    return arr;


}


// Прием данных
(int, int, int) Input()
{
    System.Console.WriteLine("Введите x: ");
    int l = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите y: ");
    int m = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите z: ");
    int n = int.Parse(Console.ReadLine());

    return (m, n, l);
}

// Печать массива
void PrintArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine("\t");
        }
        System.Console.WriteLine();
    }
}



Console.Clear();
(int m, int n, int l) = Input();
int[,,] arr = CreateArr(m, n, l);
PrintArr(arr);