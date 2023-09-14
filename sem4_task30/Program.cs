// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
using System;
int GetNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int getRandomInt(int min, int max)
{
    int randomNum = new Random().Next(min, max);
    return randomNum;
}

int[] GenArray(int num){
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = getRandomInt(0, 2);
    }
    return array;
}

void PrintArray(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0}, ", array[i]);
    }
    Console.Write("{0}]", array[array.Length - 1]);
}

PrintArray(GenArray(GetNum()));