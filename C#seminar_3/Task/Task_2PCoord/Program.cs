// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int GetNumberOfPlane (int x, int y)
{
    if (x == 0 || y == 0) return -1;
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    else return -1;
}

int x = -8, y = -56;
// ниже красиво оформляем вывод результатов для пользователя
// вариант с доп переменной numberOfPlane: int numberOfPlane = GetNumberOfPlane (x, y);

Console.WriteLine($"Номер плоскости: {GetNumberOfPlane (x, y)}");

/*
// ВТОРОЙ ВАРИАНТ РЕАЛИЗАЦИИ ЗАДАЧИ!
// если в функции оставить только if - будет работать неправильно (выполнябтся остальные). Чтобы выполнялся один - else if
void PrintNumberOfPlane (int x, int y)
{
    if (x == 0 || y == 0) 
    {
        Console.WriteLine("Не верные координаты");
        return;
    }
    int numberOfPlane;
    if (x > 0 && y > 0) numberOfPlane = 1;
    else if (x < 0 && y > 0) numberOfPlane = 2;
    else if (x < 0 && y < 0) numberOfPlane = 3;
    else if (x > 0 && y < 0) numberOfPlane = 4;
    else numberOfPlane = -1;

        Console.WriteLine($"Номер плоскости: {numberOfPlane}");
}

int x = -8, y = 6;
PrintNumberOfPlane(x, y);