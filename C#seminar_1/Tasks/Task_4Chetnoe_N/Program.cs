// программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int PosMin = 1;
while (PosMin <= a)
{
    if (PosMin % 2 == 0) Console.Write(PosMin +" ");
    PosMin++;
}
