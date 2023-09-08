// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int num = GetNum();
bool result = num > 99 && num < 1000;

Console.WriteLine(result ? "Вторая цифра числа: {0}" : "Число не трёхзначное", num / 10 % 10 );
