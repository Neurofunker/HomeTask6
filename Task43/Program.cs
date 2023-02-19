// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double CoordinX(int bc1, int kc1, int bc2, int kc2)
{
    double x = 0;
    {
        x = Convert.ToDouble(bc2 - bc1) / (kc1 - kc2);
    }
    return x;
}

double CoordinY(int bc1, int kc1, int bc2, int kc2)
{
    double y = 0;
    {
        y = Convert.ToDouble(kc1 * (bc2 - bc1)) / (kc1 - kc2) + bc1;
    }
    return y;
}

double X = CoordinX(b1, k1, b2, k2);
double Y = CoordinY(b1, k1, b2, k2);
Console.WriteLine($"Пересечение в точке: ({X} : {Y})");





