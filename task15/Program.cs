//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число");
string input = Console.ReadLine();
int numberA = Convert.ToInt32(input);
if (numberA == 1)
{
Console.WriteLine("Понедельник, не выходной");
}
else if (numberA == 2)
{
Console.WriteLine("Вторник, не выходной");
}
else if (numberA == 3)
{
Console.WriteLine("Среда, не выходной");
}
else if (numberA == 4)
{
Console.WriteLine("Четверг, не выходной");
}
else if (numberA == 5)
{
Console.WriteLine("Пятница, не выходной");
}
else if (numberA == 6)
{
Console.WriteLine("Суббота, выходной");
}
else if (numberA == 7)
{
Console.WriteLine("Воскресенье, выходной");
}
else
{
Console.WriteLine("Нет такого дня недели");
}