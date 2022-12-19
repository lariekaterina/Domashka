// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным
Console.WriteLine("Введите номер дня недели от 1 до 7:");
int day = int.Parse(Console.ReadLine()!);

if (day > 5)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}