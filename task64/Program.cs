// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(m, n));


int PrintNumber(int start, int end)
{
    if (start == end) return end;
    return (start + PrintNumber(start - 1, end));
}

