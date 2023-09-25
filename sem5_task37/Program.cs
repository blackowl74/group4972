// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
using System.Collections.Generic;
int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomInt(int min, int max)
{
    int randomNum = new Random().Next(min, max);
    return randomNum;
}

int[] GenArray(int num, int min, int max)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = GetRandomInt(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0}, ", array[i]);
    }
    Console.WriteLine("{0}]", array[array.Length - 1]);
}



int[] MultiplyPairs(int[] array)
{
    int[] pairArray = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        pairArray[i] = array[i] * array[array.Length - 1 - i];
    }

    return pairArray;
}

void Output(string message, int[] array)
{
    PrintArray(array);
    Console.WriteLine(message);
    PrintArray(MultiplyPairs(array));
}


int[] randomArray = GenArray(GetNum("Введите размерность массива: "), GetNum("Введите минимальное значение элемента: "), GetNum("Введите максимальное значение элемента: "));
Output("Произведение пар:", randomArray);

