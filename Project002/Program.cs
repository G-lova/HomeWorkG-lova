//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondFigure (int number)
{
    int result = number % 100 / 10;
    return result;
}

Console.Write("Введите трехзначное число ");
int threeFigureNumber = Convert.ToInt32(Console.ReadLine());
if (threeFigureNumber >= 100 && threeFigureNumber < 1000)
{
    int secondNumber = SecondFigure(threeFigureNumber);
    Console.WriteLine ($"Вторая цифра числа {threeFigureNumber} - {secondNumber}");
}
else
{
Console.Write("Ваше число не трехзначное");
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdFigure (int number)
{
    int i = 10;
    int intermediateValue = number / i;

    while (intermediateValue > 99)
    {
        i = i * 10;
        intermediateValue = number / i;
    }

    int result = number % i / (i / 10);
    return result;
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int thirdFigure = ThirdFigure(number);
    Console.WriteLine ($"Третья цифра числа {number} - {thirdFigure}");
}
else
{
    Console.Write($"У числа {number} нет третьей цифры");
}