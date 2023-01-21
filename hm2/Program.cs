// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
int ReadInt (string message)
{
Console.WriteLine("Введите число:");
return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
    else 
    {
        int c = 1;
        for (int i = b, i > 3; i--);
    {
        c = c * 10;
    }
    result = (a / c ) % 10;
    }
    return result;
}