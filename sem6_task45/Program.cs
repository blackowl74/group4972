// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] array){
    int[] CopiedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        CopiedArray[i] = array[i];
    }
    return CopiedArray;
}

void Output(string message, int[] array)
{
    PrintArray(array);
    Console.WriteLine(message);
    PrintArray(CopyArray(array));
}

int[] randomArray = GenArray(GetNum("Введите размерность массива: "), GetNum("Введите минимальное значение элемента: "), GetNum("Введите максимальное значение элемента: "));
Output("Скопированный массив: ", randomArray);
