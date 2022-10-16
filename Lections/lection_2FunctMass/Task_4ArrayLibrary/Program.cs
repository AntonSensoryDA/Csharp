// Здесь мы созали массив, заполнили его случайными числами и напечатали (вывели в консоль)
// Если используем метод (функцию) void (она ничего не возвращает), то не должны использовать оператор return
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
// FillArray - функция заполнила массив 10-ю элементами
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
// PrintArray - печатаемый массив

int[] array = new int[10];
// определили массив из 10 элементов, по умолчанию он заполнен нолями

FillArray (array);
PrintArray (array);
