// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Проверим является ли первое число квадратом второго");
if (a==b*b)
{
    Console.WriteLine("Первое чисдо явяяется квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}