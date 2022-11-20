/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1

int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(11);
    Console.Write(matrix[i, j] + "\t"); // литералы строк
  }
  Console.WriteLine();
}

*/
/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5


int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = i + j;
    Console.Write(matrix[i, j] + "\t"); // литералы строк
  }
  Console.WriteLine();
}

*/
/* Задача 49: Задайте двумерный массив. Найдите элементы, 
  у которых оба индекса чётные, и замените эти элементы на их квадраты.


int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(11);
    if (i % 2 == 0 && j % 2 == 0)
    {
      matrix[i, j] *= matrix[i, j];
    }
    Console.Write(matrix[i, j] + "\t"); // литералы строк

  }
  Console.WriteLine();
}
*/


/* Задача 51: Найти сумму элементов главной диагонали.
  Например, задан массив:
  1 4 7 2
  5 9 2 3
  8 4 2 4
  Сумма элементов главной диагонали: 1+9+2 = 12


int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(11);
    Console.Write(matrix[i, j] + "\t"); // литералы строк
    if (i == j)
    {
      sum += matrix[i, j];
    }
  }
  Console.WriteLine();
}
Console.WriteLine($"Сумма главной диагонали равна {sum}");
*/

//double test = 3.1415926535;
//Console.Write($"{test:0.0000}");