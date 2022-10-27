// Примеры с TryParse
/*
int number;
int.TryParse (Console.ReadLine(), out number);
Console.WriteLine(number);


// Пользователь должен ввести число от 1 до 4. В ином случае будет "Ошибка...". 
//(! перед int) - инвертирует значение (то есть не спарсилось)
// можно написать функцию и задача - ввести число пользователю....потом его как-то использовать.....
int number1;
while (!int.TryParse (Console.ReadLine(), out number1) || number1 > 1 || number1 < 4)
{
    Console.WriteLine("Ошибка...");
}

Console.WriteLine(number1);
*/

Console.WriteLine("Введите пожалуйсто число от 1 до 4");
int number1;
if (!int.TryParse (Console.ReadLine(), out number1) || number1 < 1 || number1 > 4)
{
    Console.WriteLine("Ошибка...");
}
else
{
    Console.WriteLine(number1);
}
