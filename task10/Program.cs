//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);

int secondDigit = (randomNumber / 10) % 10;

Console.Write (secondDigit); 

int GetRandomNumber (int min, int max)
{
return new Random().Next(min, max + 1);
}