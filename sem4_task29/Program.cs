// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Ввести с клавиатуры длину массива и диапазон значений элементов
// Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
using System;
using System.Text;

void numbers(){
    // Метод для получения чисел
    int GetNum(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Генерация рандномного числа в диапазоне
    int getRandomInt(int min, int max)
    {
        int randomNum = new Random().Next(min, max);
        return randomNum;
    }
    // Генерация массива случайных чисел введенной размерности
    int[] GenArray(int arraySize, int min, int max)
    {
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = getRandomInt(min, max);
        }
        return array;
    }
    // Вывод массива
    void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.Write("{0}]", array[array.Length - 1]);
    }
    // Вызов методов
    PrintArray(GenArray(GetNum("Введите длину массива: "), GetNum("Введите минимальное значение массива: "), GetNum("Введите максимальное значение массива: ")));
}

void names(){
    // Метод для получения строки с именами
    string GetNames(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "0";
    }
    // Метод для получения рандомного числа
    int getRandomInt(int max)
    {
        int randomNum = new Random().Next(0, max);
        return randomNum;
    }

    // Метод для получения массива из подстрок начальной строки
    string[] GenNamesArray(string names)
    {
        // Убираем лишние пробелы
        string removeSpacesNames = names.Replace(" ", "");
        // Разделяем строку на подстроки через разделитель ","
        string[] arrayNames = removeSpacesNames.Split(',');
        return arrayNames;
    }

    // Метод для вывода случайного имени из массива
    void PrintRandomName(string[] arrayNames)
    {
        Console.WriteLine(arrayNames[getRandomInt(arrayNames.Length)]);
    }

    PrintRandomName(GenNamesArray(GetNames("Введите имена через запятую: ")));
}


// Вызываем решение первой части задания
numbers();
// Вызываем решение второй(дополнительной) части задания
// Не выводит кириллицу, если писать на латинице, то всё работает.
// В чём проблема может быть???
names();