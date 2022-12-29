// Задайте два двумерных массива (от 0 до 10). Напишите программу,
// которая будет находить произведение двух массивов (поэлементное).
Console.WriteLine("Введите размеры массивов и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-го массива: ");
int n = InputNumbers("Введите число столбцов 1-го массива (и строк 2-го): ");
int p = InputNumbers("Введите число столбцов 2-го массива: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMassive = new int[m, n];
FillArray(firstMassive);
Console.WriteLine($"Первый массив:");
PrintArray(firstMassive);

int[,] secomdMassive = new int[n, p];
FillArray(secomdMassive);
Console.WriteLine($"Второй массив:");
PrintArray(secomdMassive);

int[,] resultMassive = new int[m,p];

MultiplyMatrix(firstMassive, secomdMassive, resultMassive);
Console.WriteLine($"Произведение первого и второго массива:");
PrintArray(resultMassive);

void MultiplyMatrix(int[,] firstMassive, int[,] secomdMassive, int[,] resultMassive)
{
  for (int i = 0; i < resultMassive.GetLength(0); i++)
  {
    for (int j = 0; j < resultMassive.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMassive.GetLength(1); k++)
      {
        sum += firstMassive[i,k] * secomdMassive[k,j];
      }
      resultMassive[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}