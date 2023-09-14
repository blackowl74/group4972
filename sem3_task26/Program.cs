// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int GetNum()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

void Output(int num){
    Console.WriteLine("Разрядность числа: {0}", num);
}

Output(GetCountDigit(GetNum()));