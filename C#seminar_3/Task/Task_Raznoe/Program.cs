// See https://aka.ms/new-console-template for more information


void Sum (int first, int second)
{
    int sum = first + second;
    Console.WriteLine (sum);
}


/*
int Sum (int first, int second)
{
    int sum = first + second;
    return sum;
}
*/

Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Sum (a, b);
/*
void Main (string[] args)
{
    int result = Sum (a, b);
    Console.WriteLine($"Сумма {a} + {b} = {result}");
}
*/
