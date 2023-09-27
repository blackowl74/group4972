//  Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Fibonachi(int num){
    int firstNumFib = 0;
    int secondNumFib = 1;
    int res = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{firstNumFib} ");
        res = firstNumFib + secondNumFib;
        firstNumFib = secondNumFib;
        secondNumFib = res;
    }
}

Fibonachi(GetNum("Введите число: "));