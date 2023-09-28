// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.


int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


string GetNumInString(int count)
{
    Console.WriteLine($"Введите {count} чисел через запятую: ");
    string str = Console.ReadLine() ?? "0";
    string[] strArray = str.Replace(" ", "").Split(",");
    if (strArray.Length == count)
    {
        return string.Join(" ", strArray);
    }
    else
    {
        return "Ошибка. Неверные входные данные";
    }
}
string CountOfPositiveNums(string str)
{
    string[] stringArray = str.Split(" ");
    int[] numsArray = new int[stringArray.Length];
    if (int.TryParse(stringArray[0], out int numValue))
    {
        for (int i = 0; i < numsArray.Length; i++)
        {
            numsArray[i] = Convert.ToInt32(stringArray[i]);
        }
        int count = 0;
        for (int i = 0; i < numsArray.Length; i++)
        {
            if (numsArray[i] > 0)
            {
                count++;
            }
        }
        return count.ToString();
    }
    else{
        return string.Join(" ", stringArray);
    }
}



int countOfUserNums = GetNum("Введите количество чисел: ");
string numInString = GetNumInString(countOfUserNums);
Console.WriteLine($"Количество положительных чисел: {CountOfPositiveNums(numInString)}");