// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string CheckExistenceTriangle(int firstNum, int secondNum, int thirdNum){
    if(firstNum + secondNum > thirdNum && firstNum + thirdNum > secondNum && secondNum + thirdNum > firstNum){
        return "Треугольник существует";
    }
    else{
        return "Треугольник не существует";
    }
}

Console.WriteLine(CheckExistenceTriangle(GetNum("Введите первую сторону треугольника:"), GetNum("Введите вторую сторону треугольника:"), GetNum("Введите третью сторону треугольника:")));

