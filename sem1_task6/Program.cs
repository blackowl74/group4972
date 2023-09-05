//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int numOddOrEven = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numOddOrEven % 2 == 0 ? "Число {0} чётное" :
    "Число {0} нечётное",
     numOddOrEven);
