//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondFigure (int number)
{
    int result = number % 100 / 10;
    return result;
}

Console.Write("Введите трехзначное число ");
int threeFigureNumber = Convert.ToInt32(Console.ReadLine());
if (threeFigureNumber > 100 && threeFigureNumber < 999)
{
    int secondNumber = SecondFigure(threeFigureNumber);
    Console.WriteLine ($"Вторая цифра числа {threeFigureNumber} - {secondNumber}");
}
else
{
Console.Write("Ваше число не трехзначное");
}

