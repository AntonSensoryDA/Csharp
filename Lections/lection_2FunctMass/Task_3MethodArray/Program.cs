// поиск индекса заданного пользователем числа (find) в массиве
Console.Clear();
int [] array = {1,22,35,8,5,76,7,8};
int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
//break - позволяет вывести индекс только первого числа, которое в массиве.....а не индексы всех одинаковых чисел
    }
    index++;
}
