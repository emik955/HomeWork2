/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7");
string dayOfWeeks = Console.ReadLine();

if (dayOfWeeks == "1")
{
    Console.WriteLine("Сегодня понедельник! Не выходной день, трудись холоп");
}
else if (dayOfWeeks == "2")
{
    Console.WriteLine("Сегодня вторник! Не выходной день, трудись холоп");
}
else if (dayOfWeeks == "3")
{
    Console.WriteLine("Сегодня среда! Не выходной день, трудись холоп");
}
else if (dayOfWeeks == "4")
{
    Console.WriteLine("Сегодня четверг! Не выходной день, трудись холоп");
}
else if (dayOfWeeks == "5")
{
    Console.WriteLine("Сегодня пятница! Почти, но нет, не выходной день, трудись холоп");
}
else if (dayOfWeeks == "6")
{
    Console.WriteLine("Сегодня суббота, а значит выходной день!");
}
else if (dayOfWeeks == "7")
{
    Console.WriteLine("Сегодня воскресенье, а значит выходной день!");
}
else
{
    Console.WriteLine("Вы ввели неправильное число");
}