//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
using System;

int getRandomNum(int min, int max)
{
    int randomNum = new Random().Next(min, max);
    return randomNum;
}

void maxDigitOfRandomNum()
{
    Console.WriteLine("Способ через число");
    int num = getRandomNum(10, 100);
    Console.WriteLine(num);
    Console.WriteLine(num / 10 > num % 10 ? num / 10 : num % 10);
}

maxDigitOfRandomNum();

void maxDigitOfRandomNumFromChar()
{
    Console.WriteLine("Способ через символы");
    int num = getRandomNum(10, 100);
    char[] digitChar = num.ToString().ToCharArray();
    Console.WriteLine((int)digitChar[0] > (int)digitChar[1] ? digitChar[0] : digitChar[1]);
}

maxDigitOfRandomNumFromChar();
