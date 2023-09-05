//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int min;
int max;
if (a > b)
{
    max = a; min = b;
}
else
{
    max = b; min = a;
}

Console.WriteLine("Максимальное число: {0}\nМинимальное число: {1}", max, min);
