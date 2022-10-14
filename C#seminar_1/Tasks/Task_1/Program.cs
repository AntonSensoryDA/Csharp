//Выдает название дня недели по заданному номеру. Например, 3 -> Среда, 5 -> Пятница

Console.Clear();

Console.WriteLine("Введите пожалуйста день недели:");
int day = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Вы выбрали:" +day);
if (day == 1) Console.WriteLine("Понедельник");
if (day == 2) Console.WriteLine("Вторник");
if (day == 3) Console.WriteLine("Среда");  
if (day == 4) Console.WriteLine("Четверг");
if (day == 5) Console.WriteLine("Пятница");
//else Console.WriteLine("Нет такого дня недели");
 