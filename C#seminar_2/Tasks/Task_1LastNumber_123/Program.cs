// Программа принимает на вход трехзначное число, и на выходе показывает последнюю цифру этого числа (456 -> 6)
int GetLastDigit (int number)
{
//int lastDigit = number % 10;
//return lastDigit; - эти 2 строки, большая запись, можно сократить до return number % 10
return number % 10;
}

int number2 = 452364;
//int lastDigit = GetLastDigit(number2);
//Console.WriteLine(lastDigit); - полная запись, сократить можно до Console.WriteLine(GetLastDigit(number2))
Console.WriteLine(GetLastDigit(number2));
