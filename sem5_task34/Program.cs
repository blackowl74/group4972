// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька


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

int CountOfEvenInArray(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0){
            count++;
        }
    }
    return count;
}

void Output(string message, int[] array ){
    PrintArray(array);
    Console.WriteLine(message);
}

int [] randomArray = GenArray(10, 100, 1000);

Output($"Количество четных элементов: {CountOfEvenInArray(randomArray)}", randomArray);





