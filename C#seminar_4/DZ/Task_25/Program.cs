// Напишите ЦИКЛ, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Exponentiation (int numberA, int numberB)
{
int exponent = 1;
for (int i = 0; i < numberB; i++)
    {
        exponent *= numberA;
    }
Console.WriteLine(exponent);
}

Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В");
int numberB = int.Parse(Console.ReadLine()!);

Exponentiation(numberA, numberB);
