// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ConverToBinary(int num){
    int temp = 0;
    List<int> result = new List<int>();
    while(num > 0){
        temp = num % 2;
        num = num / 2;
        result.Add(temp);
    }
    int[] array = new int[result.Count];
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - i - 1] = result[i];
    } 
    return Convert.ToInt32(string.Join<int>("", array));
}

// вариант через рекурсию
string ToBinaryRec(int num){
    return num == 0 ? "" : ToBinaryRec(num / 2) + Convert.ToString(num % 2);
}
int number = GetNum("Введите число: ");
Console.WriteLine("Перевод в двоичную через рекурсию: {0}", ToBinaryRec(number));

void Output(string message){
    Console.WriteLine(message, ConverToBinary(GetNum("Введите число: ")));
}
Output("Число в двоичной системе: {0}");
