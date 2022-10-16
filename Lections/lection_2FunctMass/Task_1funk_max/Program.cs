// Получение максимального числа с помощью функции, но много переменных int
Console.Clear();
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 33;
int c1 = 25;
int a2 = 67;
int b2 = 383;
int c2 = 2005;
int a3 = 115;
int b3 = 30;
int c3 = 29;

int max = Max (Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));
Console.WriteLine(max);
