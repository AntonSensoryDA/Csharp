// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N 
//(3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125)

void CubeNumbers (double number)
{
double i = 1;
while (i <= number)
{
    Console.WriteLine(Math.Pow(i, 3));
    i++;
}
}

Console.Write("Пожалуйста введите число: ");
double number = int.Parse (Console.ReadLine());

CubeNumbers (number);

