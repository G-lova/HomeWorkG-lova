// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
double NumberDegree(double firstNumber, double secondNumber)
{
    double degree = Math.Pow(firstNumber, secondNumber);
    return degree;
}

Console.Write("Введите число ");
double firstNum = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень числа ");
double secondNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Число {firstNum} в степени {secondNum} равно {NumberDegree(firstNum, secondNum)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumFigures(int number)
{
    int sumFigures = 0;
    int digitFigure = 0;

    while (number > 0)
    {
        digitFigure = number % 10;
        sumFigures += digitFigure;
        number = number / 10;
    }
    return sumFigures;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {num} равна {SumFigures(num)}");
