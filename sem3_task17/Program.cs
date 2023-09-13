// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int getCoordinate(string x){
    Console.Write("Введите координату {0}: ", x);
    return Convert.ToInt32(Console.ReadLine());
}
int pointX = getCoordinate("X");
int pointY = getCoordinate("Y");

string QuarterIdent(int pointX, int pointY){
    if (pointX > 0 && pointY > 0) return "Первая четверть";
    if (pointX < 0 && pointY > 0) return "Вторая четверть";
    if (pointX < 0 && pointY < 0) return "Третья четверть";
    if (pointX > 0 && pointY < 0) return "Четвертая четверть";
    return "Неверное значение, одна или обе из координат равна 0";
}

Console.WriteLine(QuarterIdent(pointX, pointY));



