// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// * Сделать вариант для числа длиной до 10 цифр не используя char или string
using System;


// Метод для получения числа
int GetNum()
{
    return Convert.ToInt32(Console.ReadLine());
}
// Получаем число и номер разряда
Console.Write("Введите число: ");
int num = GetNum();
Console.Write("Введите номер разряд: ");
int digit = GetNum();
// Метод для получения числа искомого разряда
int GetDigit(int num, int numOfDigit)
{
    while (num > Math.Pow(10, numOfDigit))
    {
        num /= 10;
    }
    return num = num % 10;
}
Console.WriteLine(num < Math.Pow(10, digit - 1) ? "Число меньше" : GetDigit(num, digit));

