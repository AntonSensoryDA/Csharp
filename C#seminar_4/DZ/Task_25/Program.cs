// Напишите ЦИКЛ, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
// Придумал условия для создания цикла (фактическое решение в две строки), как требует задача
void Exponentiation (double numberA, double numberB)
{
int i = 0;
double exponent = 0;
while (i < numberB)
{
    exponent = Math.Pow (numberA, numberB);
    Console.WriteLine(exponent);
    break;
}
}

Console.WriteLine("Введите число А");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В");
double numberB = double.Parse(Console.ReadLine()!);


Exponentiation(numberA, numberB);
