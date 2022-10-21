// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным (6 -> да; 7 -> да; 1 -> нет).
// Вариант без объявления диапазона недели
Console.Write("Введите пожалуйста день недели: ");
int digit = int.Parse(Console.ReadLine()!);
if (digit < 6)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}

/*
// С вариантом  - "Нет такого дня недели"

Console.Write("Введите пожалуйста день недели: ");
int digit = int.Parse(Console.ReadLine()!);
if (digit > 0 & digit < 6)
{
    Console.WriteLine("Нет");
}
else if (digit <= 0 || digit > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    Console.WriteLine("Да");
}

