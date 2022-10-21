// Программа выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа (78 -> 8)
int MaxDigit (int number_rand)
{
int result = 0;
int one = number_rand % 10;
int two = number_rand / 10;

if (one > two)
{
    result = one;
}
else
{
    result = two;
}
return result;
}
int number_rand = new Random().Next(10, 100);
Console.WriteLine(number_rand);

Console.WriteLine(MaxDigit(number_rand));