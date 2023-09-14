// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int sumOfNumbers(int num){
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
void Output(string message){
    Console.WriteLine(message, sumOfNumbers(GetNum()));
}
Output("Сумма чисел введенного числа: {0}");
