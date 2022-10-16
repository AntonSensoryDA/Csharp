/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int PosMin = 1;
while (PosMin <= a)
{
    if (PosMin % 2 == 0) Console.Write(PosMin +" ");
    PosMin++;
}
