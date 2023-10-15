// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunc(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else
    {
        if ((numM != 0) && (numN == 0)){
            return AkkermanFunc(numM - 1, 1);
        }
        else{
            return AkkermanFunc(numM - 1, AkkermanFunc(numM, numN - 1));
        }
    }
}
int numberM = GetNum("Введите число М: ");
int numberN = GetNum("Введите число N: ");
Console.WriteLine($"Результат выполнения функции Аккермана: {AkkermanFunc(numberM, numberN)}");

