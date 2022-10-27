// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void Dcoord (int quarter)
{
if (quarter == 1) Console.WriteLine("положительные");
else if (quarter == 2) Console.WriteLine("положительно-отрицательные");
else if (quarter == 3) Console.WriteLine("отрицательные");
else if (quarter == 4) Console.WriteLine("положительно-отрицательные");
else Console.WriteLine($"нет четверти {quarter}");
}

int quarter = 5;
Dcoord (quarter);