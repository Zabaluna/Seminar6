//  Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = 5*x +2  
// y = 9*x +4
Console.WriteLine("Введите значение чисел: b1, k1, b2, k2: ");

double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double GetPoint(double b1, double b2, double k1, double k2)
{
    double numberX = 0;
    double numberY = 0;
    if (k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        numberX = (b2 - b1) / (k1 - k2);
        numberY = k2 * numberX + b2;
        Console.WriteLine($"Точка пересечения двух прямых: {numberX}{numberY}");
    }
    return numberX;
    return numberY;
}

double getpoint = GetPoint(b1, b2, k1, k2);


