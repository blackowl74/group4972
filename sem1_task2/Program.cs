Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int min;
int max;
a > b ? max = a; min = b; : max = b; min = a;

Console.WriteLine("Максимальное число: {0}\nМинимальное число: {1}", max, min);
