// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums(n - 1);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int SumOfDiapasonNumbers(int m, int n)
{
    if (m < n) return SumOfDiapasonNumbers(m, n - 1) + n;
    else
        if (m > n) return SumOfDiapasonNumbers(m - 1, n) + m;
    return m;
}

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} равна {SumOfDiapasonNumbers(m, n)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double AkkermanFunction(double m, double n)
{
    if (m > 0)
    {
        if (n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
        else
            if (n == 0) return AkkermanFunction(m - 1, 1);
    }
    else
        if (m == 0) return n + 1;
    return 0;
}

Console.Write("Введите число: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Функция Аккермана А({m},{n}) равна {AkkermanFunction(m, n)}");