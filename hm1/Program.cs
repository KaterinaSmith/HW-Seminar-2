// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();

{
int a = Convert.ToInt32(number);
int b = (a / 10) % 10;
Console.WriteLine(b);
}