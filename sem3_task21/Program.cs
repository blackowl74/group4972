//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int getCoordinate(string x){
    Console.Write("Введите координату {0}: ", x);
    return Convert.ToInt32(Console.ReadLine());
}

double calcDistance(int pointX1, int pointY1, int pointZ1, int pointX2, int pointY2,  int pointZ2){
    return Math.Sqrt(Math.Pow((pointX1 - pointX2), 2) + Math.Pow((pointY1 - pointY2), 2) + Math.Pow((pointZ1 - pointZ2), 2));
}

int pointX1 = getCoordinate("X1");
int pointY1 = getCoordinate("Y1");
int pointZ1 = getCoordinate("Z1");
int pointX2 = getCoordinate("X2");
int pointY2 = getCoordinate("Y2");
int pointZ2 = getCoordinate("Z2");



Console.WriteLine(calcDistance(pointX1, pointY1, pointZ1, pointX2, pointY2, pointZ2));
