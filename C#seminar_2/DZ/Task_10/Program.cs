// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа (456 -> 5)
int GetTwoDigit (int number)
{
return number / 10 % 10;
}

int number2 = 123;
Console.WriteLine(GetTwoDigit(number2));