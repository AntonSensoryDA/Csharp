// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (14212 -> нет
//12821 -> да; 23432 -> да)

void Palindrome (int number)
{
    int oldNum = number;
    int newNum = 0;
    while (number > 0)
    {
        int value = number % 10;
        newNum = newNum * 10 + value;
        number = number / 10;
    }
    if (newNum == oldNum) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

Console.WriteLine("Введите число для проверки на палиндром");
int number = int.Parse(Console.ReadLine());

Palindrome (number);

// Проверка на палиндром всего (самый короткий вариант)...минус - использование var
//var s = Console.ReadLine();
//if (s.Reverse().SequenceEqual(s)) Console.WriteLine("Палиндром!");
//else Console.WriteLine("Не палиндром!");

/*
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

if (number == res) Console.WriteLine("Палиндром");
else Console.WriteLine("Не палиндром");
*/
