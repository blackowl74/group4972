// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumRangeRec(int numM, int numN)
{
    if (numM == numN)
    {
        return numN;
    }
    else
    {
        return numM + SumRangeRec(numM + 1, numN);
    }
}

int numberM = GetNum("Введите число М: ");
int numberN = GetNum("Введите число N: ");

Console.WriteLine($"Сумма натуральных чисел в промежутке равна {SumRangeRec(numberM, numberN)}");