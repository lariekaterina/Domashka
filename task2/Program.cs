// По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()!);
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if (day == a)
{
    Console.WriteLine("Понедельник");
}
if (day == b)
{
    Console.WriteLine("Вторник");
}
if (day == c)
{
    Console.WriteLine("Среда");
}
if (day == d)
{
    Console.WriteLine("Четверг");
}
if (day == e)
{
    Console.WriteLine("Пятница");
}
if (day == f)
{
    Console.WriteLine("Суббота");
}
if (day == g)
{
    Console.WriteLine("Воскресенье");
}
