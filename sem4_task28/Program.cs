// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
using System.Numerics;
int GetLongNum()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

BigInteger GetFactorial(int num)
{
    BigInteger fact = 1;
    for (int i = 0; i < num; i++)
    {
        fact *= num;
    }
    return fact;
}

void Output(string message, BigInteger num){
    Console.WriteLine(message, num);
}

Output("Факториал числа: {0}", GetFactorial(GetLongNum()));
