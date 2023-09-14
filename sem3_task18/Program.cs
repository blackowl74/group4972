// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int getQuarter(){
    Console.Write("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}


string pointsIdent(int quarterNum){
    switch (quarterNum){
        case 1:
            return "Возможные значения: X > 0, Y > 0";
        case 2: 
            return "Возможные значения: X < 0, Y > 0";
        case 3:
            return "Возможные значения: X < 0, Y < 0";
        case 4:
            return "Возможные значения: X > 0, Y < 0";
        default:
            return "Неверное значение";
    }
}

int quarterNum = getQuarter();
Console.WriteLine(pointsIdent(quarterNum));


