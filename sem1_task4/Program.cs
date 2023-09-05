//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if (secondNum > max)
{
    max = secondNum;
}
if (thirdNum > max)
{
    max = thirdNum;
}
Console.WriteLine("Максимальное число: {0}", max);