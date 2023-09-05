//Напишите программу, которая на вход принимает одно число(N), а на выходе показывает все целые числа от -N до N

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = -num; i <= num; i++)
{
    if (i < num)
    {
        Console.Write(i + ", ");

    }
    if (i == num)
    {
        Console.Write(i);
    }
}




