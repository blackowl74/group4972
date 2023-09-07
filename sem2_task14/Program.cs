// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int GetNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNum();

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратное" : "Не кратно");
