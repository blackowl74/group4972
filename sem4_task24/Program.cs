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
int GaussSum(int num){
    return num*(num+1) / 2;
}
void Output(int num){
    Console.WriteLine("Сумма чисел введенного числа: {0}", num);
}
DateTime startTimeSum = DateTime.Now;
Output(sumOfNumbers(GetNum()));
Console.WriteLine(DateTime.Now - startTimeSum);
DateTime startTimeGauss = DateTime.Now;
Output(GaussSum(GetNum()));
Console.WriteLine(DateTime.Now - startTimeGauss);
