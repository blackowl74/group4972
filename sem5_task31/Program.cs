// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.


int getRandomInt(int min, int max)
{
    int randomNum = new Random().Next(min, max);
    return randomNum;
}

int[] GenArray(int num, int min, int max){
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = getRandomInt(min, max);
    }
    return array;
}

(int posSum, int negSum) GetSum(int[] array){
    int posSum = 0;
    int negSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            posSum += array[i];
        }
        else
        {
            negSum += array[i];
        }
    }
    return (posSum, negSum);
}



void PrintArray(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0}, ", array[i]);
    }
    Console.WriteLine("{0}]", array[array.Length - 1]);
}

void Output(string message, int posSum, int negSum){
    Console.WriteLine(message, posSum, negSum);
}

int[] randomIntArray= GenArray(12, -9, 10);
PrintArray(randomIntArray);
Output("Сумма положительных чисел: {0}\nСумма отрицательных чисел: {1}", GetSum(randomIntArray).posSum, GetSum(randomIntArray).negSum);



