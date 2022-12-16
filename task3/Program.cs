// Найти максимальное из трех чисел
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int r = int.Parse(Console.ReadLine()!);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (r > max) max = r;
Console.Write("max = ");
Console.WriteLine(max);
