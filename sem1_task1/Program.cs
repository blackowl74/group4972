// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((int)Math.Pow(secondNum, 2) == firstNum ?
    "Да, первое число является квадратом второго: {0} {1}" :
    "Нет, первое число не является квадратом второго: {0} {1}", 
    firstNum, (int)Math.Pow(secondNum, 2));

