/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int max = a;
if (a > b) max = a;
// int max = b;
//if (a > b) max = a;
else max = b;
Console.Write("max = ");
Console.WriteLine(max);
//Задача 2. Можно изначально присвоить в max значение b и с помощью if при необходимости заменить на a. Тогда строчка с else не понадобится.