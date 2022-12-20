// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int step = A;
for (int i = 1; i < B; i++)
{
    step = step * A;
}
Console.WriteLine("A в степени В = " + step);
