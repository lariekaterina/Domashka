// программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет
int num = new Random().Next(1, 3000);
Console.Write(num);
int a = num / 10 % 10;
Console.WriteLine();
if (num / 10 > 0)
{
 Console.WriteLine(a);
} 
else 
{
   Console.WriteLine("У числа нет третьей цифры");
}