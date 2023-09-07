// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

int GetNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int firstNum = GetNum();
int secondNum = GetNum();

Console.WriteLine(secondNum % firstNum == 0 ? "Кратное" : secondNum % firstNum);


