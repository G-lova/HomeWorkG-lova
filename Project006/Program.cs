//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int PositiveNumbersCount(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} элемент: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    return count;
}

Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели {PositiveNumbersCount(n)} положительных чисел");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        Console.WriteLine("Прямые совпадают");
        else
            Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1*x+b1;
        Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
    }
}

Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
IntersectionPoint(k1, b1, k2, b2);