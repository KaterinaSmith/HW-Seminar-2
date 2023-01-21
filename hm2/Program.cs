// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
int length = number.Length;

if (length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int c = 1;
    for (int i = length; i > 3; i--)
    { 
        c = c * 10;
    }
int result = (a / c) % 10;
Console.WriteLine(result);
}
