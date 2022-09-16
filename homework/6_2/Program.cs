// 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CoordinatesIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = 0;
    
    if (k1 * x + b1 != k2 * x + b2) Console.WriteLine("У данных прямых нет точки пересечения");

    else
    {
        y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения данных прямых: ({x}; {y})");
    }

}

CoordinatesIntersectionPoint(2, 5, 4, 9);
CoordinatesIntersectionPoint(1,2,8,12);