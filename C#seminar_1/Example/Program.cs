// програма на вход число, на выход квадрать его
Console.Clear();
Console.Write("Пожалуйста введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;
Console.WriteLine($"Квадрат числа {num}: {result}");
//Console.WriteLine("Квадрат числа:" +result);

if (result <= 777) Console.Write("Маловато... ");
else Console.Write("Поехали ");