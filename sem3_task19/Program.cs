// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Метод для получения данных от пользователя и конвертирования в целое число
int GetNum()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
// Метод для получения числа искомого разряда
int GetDigit(int num, int numOfDigit)
{
    while (num > Math.Pow(10, numOfDigit))
    {
        num /= 10;
    }
    return num = num % 10;
}
// Метод, определяющий является ли число палиндромом
bool isPalindrome(int num)
{
    // Проверяем на пятизначность
    if (num > 9999 && num < 99999)
    {
        // разбираем число по разрядам
        int digit1 = GetDigit(num, 1);
        int digit2 = GetDigit(num, 2);
        int digit4 = GetDigit(num, 4);
        int digit5 = GetDigit(num, 5);
        // Сравниваем числа из нужных разрядов
        return digit1 == digit5 && digit2 == digit4 ? true : false;
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
}
Console.WriteLine(isPalindrome(GetNum()));






