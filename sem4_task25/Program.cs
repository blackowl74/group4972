// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//Написать калькулятор с операциями +, -, /, * и возведение в степень


// Метод для получения числа от пользователя
int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод для получения оператора от пользователя
char GetOperator(string message)
{
    Console.Write(message);
    return Convert.ToChar(Console.ReadLine());
}

// Метод сложения
int ToSum(int firstNum, int secondNum)
{
    return firstNum + secondNum;
}
// Метод вычитания
int ToSubtraction(int firstNum, int secondNum)
{
    return firstNum - secondNum;
}

// Метод умножения
int ToMultiply(int firstNum, int secondNum)
{
    return firstNum * secondNum;
}

// Метод деления, возвращает тип double, т.к. при делении могут получиться не только целые числа
double ToDivide(int divisible, int divider)
{
    return (double)divisible / (double)divider;
}

// Метод возведения в степень
int ToPow(int num, int degree)
{
    int pow = 1;
    for (int i = 1; i <= degree; i++)
    {
        pow *= num;
    }
    return pow;
}
// Метод для более удобного вывода ответа
void OutputResult(object operation){
    Console.WriteLine("Ответ: {0}", operation);
}


// Метод, который проверяет знак и, в зависимости от знака, вызывает нужный метод и выдает ответ
void Calculation(string firstNumber, string secondNumber, string oper)
{
    int firstNum = GetNum($"{firstNumber}: ");
    char operat = GetOperator($"{oper}: ");
    int secondNum = GetNum($"{secondNumber}: ");
    switch (operat)
    {
        case '+':
            OutputResult(ToSum(firstNum, secondNum));
            break;
        case '-':
            OutputResult(ToSubtraction(firstNum, secondNum));
            break;
        case '*':
            OutputResult(ToMultiply(firstNum, secondNum));
            break;
        case '/':
            OutputResult(ToDivide(firstNum, secondNum));
            break;
        case '^':
            OutputResult(ToPow(firstNum, secondNum));
            break;
        default:
            Console.WriteLine("Данной операции не существует");
            break;
    }

}



Calculation("Введите первое число", "Введите второе число", "Введите оператор");


