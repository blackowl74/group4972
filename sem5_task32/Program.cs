// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int GetRandomInt(int min, int max)
{
    int randomNum = new Random().Next(min, max);
    return randomNum;
}

int[] GenArray(int num, int min, int max){
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = GetRandomInt(min, max);
    }
    return array;
}

void PrintArray(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0}, ", array[i]);
    }
    Console.WriteLine("{0}]", array[array.Length - 1]);
}

void InversArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

void Output(string message){
    Console.WriteLine(message);
}

int[] array = GenArray(10, -10, 11);

Output("Начальный массив: ");
PrintArray(array);
InversArray(array);
Output("Инвертированный массив: ");
PrintArray(array);
