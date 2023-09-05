// Напишите программу, которая будет выдавать название дня недели по заданному номеру (Решение через массив)
Console.Write("Введите номер дня недели: ");
int numOfDay = Convert.ToInt32(Console.ReadLine());
string[] dayOfWeek = new string[7];

dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Четверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "Суббота";
dayOfWeek[6] = "Воскресенье";

Console.WriteLine(numOfDay < 1 || numOfDay > 7 ?
    "Такого дня недели не существует" :
    dayOfWeek[numOfDay - 1]);

// Console.Write("Введите номер дня недели: ");
// int numOfDay = int.Parse(Console.ReadLine()??"0");

// string dayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(numOfDay));

// Console.WriteLine(dayOfWeek);