// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
int length = number.Length;

if (length != 3)
{
    Console.WriteLine("Все же введите 3х значное число");
}
else
{
int b = (a / 10) % 10;
Console.WriteLine(b);
}
