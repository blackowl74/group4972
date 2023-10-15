// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNum(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumsRec(int number){
    if (number > 0)
    {
        Console.Write($"{number} ");
        PrintNumsRec(--number);
    }
}

PrintNumsRec(GetNum("Введите число: "));