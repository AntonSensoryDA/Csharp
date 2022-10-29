// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран (1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]).

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position <= count)
    {
        if (position == 0) Console.Write("[");
        if (position < 7) Console.Write($"{col[position]}, ");
        if (position == 7)
            {
                Console.Write($"{col[position]}");
                Console.Write("]");
            }
        position++;
    }
    
}

Console.WriteLine("Введите восемь элементов массива:");
int num1 = int.Parse (Console.ReadLine()!);
int num2 = int.Parse (Console.ReadLine()!);
int num3 = int.Parse (Console.ReadLine()!);
int num4 = int.Parse (Console.ReadLine()!);
int num5 = int.Parse (Console.ReadLine()!);
int num6 = int.Parse (Console.ReadLine()!);
int num7 = int.Parse (Console.ReadLine()!);
int num8 = int.Parse (Console.ReadLine()!);

int[] array = {num1, num2, num3, num4, num5, num6, num7, num8};

PrintArray (array);


