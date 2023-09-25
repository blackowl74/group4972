// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом.
// Для задачи со звездочкой использовать заполнение массива целыми числами.


// Метод для получения числа 
int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод для генерации рандомного вещественного числа

double GetRandomDouble(double min, double max)
{
    double randomNum = new Random().NextDouble() * (max - min) + min;
    return Math.Round(randomNum, 4);
}

// Генерируем массив

double[] GenArray(int num, double min, double max)
{
    double[] array = new double[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = GetRandomDouble(min, max + 1);
    }
    return array;
}

// Печатаем массив

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0}, ", array[i]);
    }
    Console.WriteLine("{0}]", array[array.Length - 1]);
}

// Поиск разицы между макс и мин

double GetDiff(double[] array){
    double min = array[0];
    double max = 0;
    for (int i = 1; i < array.Length; i++){
        if (array[i] < min){
            min = array[i];
        }
        if (array[i] > max){
            max = array[i];
        }
    }
    return max - min;
}

void Output(string message, double[] array)
{
    PrintArray(array);
    Console.WriteLine(message);
}

// Получаем массив
double[] randomArray = GenArray(GetNum("Введите размерность массива: "), GetNum("Введите минимальное значение элемента: "), GetNum("Введите максимальное значение элемента: "));
// Выводим массив и разницу
Output($"Разница между максимальным и минимальным: {GetDiff(randomArray)}", randomArray);

