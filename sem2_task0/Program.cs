//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
using System;

void maxDigitOfRandomNum(){
    Console.WriteLine("Способ через число");


    int getRandomNum(int min, int max){
        int randomNum = new Random().Next(min, max);
        return randomNum;
    }
    int num = getRandomNum(10, 100);
    Console.WriteLine(num);
    Console.WriteLine(num / 10 > num%10 ? num /10 : num%10);
}

maxDigitOfRandomNum();

void maxDigitOfRandomNumFromChar(){
    Console.WriteLine("Способ через символы");
    int getRandomNum(int min, int max){
        int randomNum = new Random().Next(min, max);
        return randomNum;
    }
    int num = getRandomNum(10, 100);
    char[] digitChar = num.ToString().ToCharArray();

    Console.WriteLine((int)digitChar[0]>(int)digitChar[1]?digitChar[0]:digitChar[1]);
}

maxDigitOfRandomNumFromChar();
