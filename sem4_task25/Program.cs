// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//Написать калькулятор с операциями +, -, /, * и возведение в степень

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

char GetOperator(string message)
{
    Console.Write(message);
    return Convert.ToChar(Console.ReadLine());
}

int ToSum(int firstNum, int secondNum)
{
    return firstNum + secondNum;
}

int ToSubtraction(int firstNum, int secondNum)
{
    return firstNum - secondNum;
}

int ToMultiply(int firstNum, int secondNum)
{
    return firstNum * secondNum;
}

double ToDivide(int divisible, int divider)
{
    return (double)divisible / (double)divider;
}

int ToPow(int num, int degree)
{
    int pow = 1;
    for (int i = 1; i <= degree; i++)
    {
        pow *= num;
    }
    return pow;
}

// Todo:
// Добавить третий параметр string для получения операции от пользователя
// Вместо "Введите степень" - "Введите второе число"
void Calculation(string firstNumber, string secondNumber, string oper)
{
    int firstNum = GetNum($"{firstNumber}: ");
    char operat = GetOperator($"{oper}: ");
    int secondNum = GetNum($"{secondNumber}: ");
    switch (operat)
    {
        case '+':
            Output(ToSum(firstNum, secondNum));
            break;
        case '-':
            Output(ToSubtraction(firstNum, secondNum));
            break;
        case '*':
            Output(ToMultiply(firstNum, secondNum));
            break;
        case '/':
            Output(ToDivide(firstNum, secondNum));
            break;
        case '^':
            Output(ToPow(firstNum, secondNum));
            break;
        default:
            Console.WriteLine("Данной операции не существует");
            break;
    }

}

void Output(object operation){
    Console.WriteLine("Ответ: {0}", operation);
}

Calculation("Введите первое число", "Введите второе число", "Введите оператор");


