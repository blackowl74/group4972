// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// Найдите все пары в массиве и выведите пользователю
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

// Считаем сумму эл-тов нечётных индексов
int SumOfOdd(int[] array)
{
    int sum = 0;
    // Проходимся по массиву циклом и проверяем индекс на чётность
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i]; // Прибавляем эл-т к сумму
        }
    }
    return sum;
}

// Метод для нахождения повторяющихся эл-тов
void FindPair(int[] array)
{
    var pairs = 
            array.GroupBy(pair => pair) // Группирем эл-ты по признаку
          .Where(elem => elem.Count() >= 2) // Кол-во повторяющихся эл-тов должно быть больше 2
          .ToDictionary(pair => pair.Key, count => count.Count()); // Перевоим всё в словарь с ключом и кол-вом
    Console.WriteLine($"Повторяющиеся элементы в массиве [число, повторения]: {String.Join(", ", pairs)}"); // Переводим в строку и выводим в консоль повторяющиеся эл-ты в виде число, кол-во вхождений этого числа
}

// Коммент для преподавателя: каким ещё образом можно вывести пары в массиве, не сортируя его?
// Можно ли как-то улучшить мой метод? Если да, то как?
// У меня ещё был вариант выводить имеено пары, но только уникальные, т.е. если элементов больше 2, то они исключаются

void Output(string message, int[] array)
{
    PrintArray(array);
    Console.WriteLine(message);
}




int[] randomArray = GenArray(GetNum("Введите размерность массива: "), GetNum("Введите минимальное значение элемента: "), GetNum("Введите максимальное значение элемента: "));

Output($"Сумма элементов нечётных позиций: {SumOfOdd(randomArray)}", randomArray);
FindPair(randomArray);

