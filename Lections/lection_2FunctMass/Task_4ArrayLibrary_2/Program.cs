// Предыдущая задача (Task_4) + нахождение индекса из Task_3
void FillArray (int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}
// создаем метод. Так как он должен возвращать значение - поэтому не void. 
int PoiskI (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
// в int position поставим -1 вместо 0, чтобы при поиске элемента массива, которого нет (например, 560 в массиве от 1 до 10 - нам выводилось -1 - означает, что такого нет)
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];


FillArray (array);
// array [4] = 4;
// array [6] = 4;-принудительно, сами добавляем в массив 4 на позиции 4 и 6 (чтобы показать, что break выводит первую найденную)
PrintArray (array);
Console.WriteLine();

int pos = PoiskI(array, 5);
Console.WriteLine(pos);