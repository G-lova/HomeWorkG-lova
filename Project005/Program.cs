// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


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
