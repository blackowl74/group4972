// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
using System;

int getRandomNum(int min, int max)
{
    int randomNum = new Random().Next(min, max);
    return randomNum;
}

int num = getRandomNum(99, 1000);

int firstDigit = num / 100;
int lastDigit = num % 10;

Console.WriteLine(num);
int resNumber = firstDigit*10 + lastDigit;
Console.WriteLine(resNumber);
