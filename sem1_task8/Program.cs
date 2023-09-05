//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());

if (count < 2)
{
    Console.WriteLine("Ошибка входных данных. Введенное число меньше 2. Чётных чисел нет");
}
else
{
    if (count % 2 == 0)
    {
        for (int i = 2; i <= count; i += 2)
        {
            Console.Write("{0} ", i);
        }
    }
    else
    {
        for (int i = 2; i <= count - 1; i += 2)
        {
            Console.Write("{0} ", i);
        }
    }
}
