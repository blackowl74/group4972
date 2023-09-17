// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки
void methodNum(){
    // Метод для получения данных от пользователя и конвертирования в целое число
    int GetNum()
    {
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    // Метод для получения числа искомого разряда
    int GetDigit(int num, int numOfDigit)
    {
        while (num > Math.Pow(10, numOfDigit))
        {
            num /= 10;
        }
        return num %=10;
    }

    int SumOfDigits(int num){
        string countDigit = Convert.ToString(num);
        int sumOfDigit = 0;
        for (int i = 1; i <= countDigit.Length; i++)
        {
            sumOfDigit += GetDigit(num, i);
        }
        return sumOfDigit;
    }
    void OutputTime(string message, int number){
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Сумма цифр числа: {0}", SumOfDigits(number));
        Console.WriteLine(message, DateTime.Now - startTime);
    }
    int number = GetNum();
    OutputTime("Время, затраченное на выполнение: {0}", number);
    
}
void methodChar(){

    string GetStringNum()
    {
        Console.Write("Введите число: ");
        return Console.ReadLine() ?? "0";
    }

    int GetSumDigits(string number){
        string digits = number.ToString();
        int result = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            result += digits[i] - '0';
        }
        return result;
    }
    string number = GetStringNum();
    void OutputTime(string message, string number){
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Сумма цифр числа: {0}", GetSumDigits(number));
        Console.WriteLine(message, DateTime.Now - startTime);
    }
    OutputTime("Время, затраченное на выполнение: {0}", number);
}
methodNum();
methodChar();

// DateTime startTimeSum = DateTime.Now;
// methodNum();
// Console.WriteLine(DateTime.Now - startTimeSum);

// DateTime startTimeGauss = DateTime.Now;
// methodChar();
// Console.WriteLine(DateTime.Now - startTimeGauss);














