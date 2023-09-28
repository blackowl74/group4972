// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2, k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// Найдите площадь треугольника образованного пересечением 3 прямых


// void CrossPoint(){
//     int GetNum(string message)
//     {
//         Console.Write(message);
//         return Convert.ToInt32(Console.ReadLine());
//     }

//     double GetPointX(int firstCoeff, int firstConst, int secondCoeff, int secondConst)
//     {
//         return (double)(secondConst - firstConst) / (double)(firstCoeff - secondCoeff);
//     }
//     double GetPointY(int coeff, double pointX, int constant)
//     {
//         return coeff * pointX + constant;
//     }

//     int b1 = GetNum("Введите b1: ");
//     int k1 = GetNum("Введите k1: ");
//     int b2 = GetNum("Введите b2: ");
//     int k2 = GetNum("Введите k2: ");


//     double pointX = GetPointX(k1, b1, k2, b2);
//     double pointY = GetPointY(k2, pointX, b2);


//     Console.WriteLine($"Точка пересечения двух прямых (X, Y): ({pointX}, {pointY})");
// }

void TriangleArea()
{
    // Получаем числа
    int GetNum(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
    // Получаем точки пересечения наших прямых
    (double pointX, double pointY) GetCrossPoint(int firstCoeff, int firstConst, int secondCoeff, int secondConst)
    {
        return (
            (double)(secondConst - firstConst) / (double)(firstCoeff - secondCoeff),
            firstCoeff * ((double)(secondConst - firstConst) / (double)(firstCoeff - secondCoeff)) + firstConst
         );
    }
    // Находим сторону 
    double GetSide(double pointX1, double pointY1, double pointX2, double pointY2)
    {
        return Math.Round(Math.Sqrt(Math.Pow((pointX2 - pointX1), 2) + Math.Pow((pointY2 - pointY1), 2)), 2);
    }

    //  Если дано уравнение прямой
    //  ax + by + c = 0 и координаты точки С(х₀;у₀), то расстояние
    //  от точки С до прямой находится по формуле: h = |ax₀ + by₀ + c| / √(a² + b²)

    double GetHeight(int k1, double pointXC, double pointYC, int b1){
        return Math.Round(Math.Abs(k1 * pointXC + b1 * pointYC + b1) / Math.Sqrt(k1 * k1 + b1 * b1), 2);
    }

    // Считаем площадь через сторону и высоту треугольника
    double GetTriangleArea(double side, double height){
        return Math.Round((side * height) / 2, 2);
    }

    // Метод для группировки координат точек
    double[] GetPoint(int firstCoeff, int firstConst, int secondCoeff, int secondConst){
        double[] array = new double[2];
        array[0] = GetCrossPoint(firstCoeff, firstConst, secondCoeff, secondConst).pointX;
        array[1] = GetCrossPoint(firstCoeff, firstConst, secondCoeff, secondConst).pointY;
        return array;
    }
    // Метод для вывода точек
    void OutputPoints(double[] pointA, double[] pointB, double[] pointC){
        Console.WriteLine($"Точка A: ({String.Join(", ", pointA)})");
        Console.WriteLine($"Точка B: ({String.Join(", ", pointB)})");
        Console.WriteLine($"Точка C: ({String.Join(", ", pointC)})");
    }
    // Получаем данные из уравнений
    int b1 = GetNum("Введите b1: ");
    int k1 = GetNum("Введите k1: ");
    int b2 = GetNum("Введите b2: ");
    int k2 = GetNum("Введите k2: ");
    int b3 = GetNum("Введите b3: ");
    int k3 = GetNum("Введите k3: ");
    // Получаем точки
    double[] pointA = GetPoint(k1, b1, k2, b2);
    double[] pointB = GetPoint(k1, b1, k3, b3);
    double[] pointC = GetPoint(k2, b2, k3, b3);
    // Выводим точки
    OutputPoints(pointA, pointB, pointC);
    // Считаем и выводим площадь
    Console.WriteLine($"Площадь треугольника: {GetTriangleArea(GetSide(pointA[0], pointA[1], pointB[0], pointB[1]), GetHeight(k1, pointC[0], pointC[1], b1))}");

}
TriangleArea();





