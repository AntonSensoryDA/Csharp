// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран (1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]).

Console.WriteLine("Введите 8 целых чисел в строку через пробел:");
string[] s = Console.ReadLine().Split();
int[] array = new int[8];
for (int i = 0; i < 8; i++) 
{
    array[i] = Int32.Parse(s[i]);
}

Console.WriteLine("[{0}]", string.Join(", ", array));


