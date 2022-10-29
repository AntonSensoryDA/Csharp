// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе(452 -> 11; 82 -> 10; 9012 -> 12)

void Sum (int number)
{
    int i = 0;
    int result = 0;
    while (number > i)
    {
        result = result + number % 10;
        number = number / 10;
        i++; 
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число:");
int number = int.Parse (Console.ReadLine()!);

Sum(number);

// Вариант решения с массивами (ограничен установленным размером массива)
/*
int[] array = new int[100000];
void DigitArray (int number)
{
    int i = 0;
    while (number > i)
    {
       array [i] = number % 10;
       number = number / 10;
        i++; 
    }
    
}

void Sum (int[] array2)
{
    int res = 0;
    for (int i = 0; i < 100000; i++)
    {
        res = array2[i] + res;
    }
    Console.WriteLine(res);

}

Console.WriteLine("Введите число:");
int number = int.Parse (Console.ReadLine());

DigitArray (number);
Sum (array);
*/