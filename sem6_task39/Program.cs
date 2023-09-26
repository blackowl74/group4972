// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

//     [1 2 3 4 5] -> [5 4 3 2 1]
//     [6 7 3 6] -> [6 3 7 6]


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

void ReverseArray(int[] array){
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int[] SwapNewArray(int[] array){
    int[] SwapArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        SwapArray[i] = array[array.Length - i - 1];
    }
    return SwapArray;
}

void Output(string message, int[] array)
{
    PrintArray(array);
    Console.WriteLine(message);
    ReverseArray(array);
    PrintArray(array);
    PrintArray(SwapNewArray(array));
}

int[] randomArray = GenArray(GetNum("Введите размерность массива: "), GetNum("Введите минимальное значение элемента: "), GetNum("Введите максимальное значение элемента: "));
Output("Перевернутый массив: ", randomArray);


