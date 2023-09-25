// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int GetNum(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

int FindElement(int[] array, int num){
    for (int i = 0; i < array.Length; i++){
        if (array[i] == num){
            return i;
        }
    }
    return -1;
}


void Output(){
    Console.WriteLine(FindElement(GenArray(10, -10, 11), GetNum("Введите искомый элемент: ")) == -1 ? "Элемент не найден" : "Элемент присутствует в массиве");

}

Output();