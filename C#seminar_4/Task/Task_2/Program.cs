// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

string Reverse (string number)
{
    string result = String.Empty;
    char[] ar = number.ToCharArray();
    Array.Reverse(ar);
    result = new String(ar);
    return result;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();

string res = Reverse(number);

if (number == res) Console.WriteLine("Да");
else Console.WriteLine("Нет");

