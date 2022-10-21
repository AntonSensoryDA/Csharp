// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет (645 -> 5; 78 -> третьей цифры нет)
int ThreeDigit (int number)
{
    while (number > 1000)
    {
        number = number/10;
    }
    number = number % 10;
    return number;
}

int number2 = 5;
    if (number2 < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine(ThreeDigit(number2));
    }
