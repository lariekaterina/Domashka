﻿//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (i<=N)
{
    Console.Write(" " + i*i*i);
    i++;
}
