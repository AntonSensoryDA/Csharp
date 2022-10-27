// Количество знаков во входящем числе

int SumFromToN (int number)
{
    int count = 1;
    for (int i = 1; i < number; i++)
    {
        number = number / 10;
        count++;
    }
    return count;
}
int number = 45566;
Console.WriteLine(SumFromToN(number));

