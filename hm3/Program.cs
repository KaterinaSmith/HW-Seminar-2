// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите порядковый номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (number <=5)
{
    Console.WriteLine("Это рабочий день");
}
else 
{
    Console.WriteLine("Введите число от 1 до 7");
}