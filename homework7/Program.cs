//using System.Linq;
/* Задача 47.Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
  
    matrix[i, j] = (new Random().NextDouble()*2-1)*100;
    Console.Write($"{matrix[i, j]:0.00} \t");
  }
  Console.WriteLine();
}
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17->такого числа в массиве нет
----------------------------------------------------------
// 1 решение - поиск введенного значения в массиве(пока только последнего)

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
Console.WriteLine("Введите искомое число");
int number = int.Parse(Console.ReadLine());
int positionRow = -1;
int positionColumn = -1;

// заполнение массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(10);
    if (matrix[i, j] == number)
    {
      positionRow = i;
      positionColumn = j;
    }
    Console.Write(matrix[i, j] + "\t");
  }
  Console.WriteLine();
}
if (positionRow == -1)
{
  Console.WriteLine($"Значения '{number}' нет в массиве");
}
else
{
  Console.WriteLine($"'{number}' находится в {positionRow + 1} строке и {positionColumn + 1} столбце");
}
*/
/*
-------------------------------------------------------------------
// 2 решение - разбивка введенного значения на строку и столбец и поиск значения
// например - "24" - 2-я строка, 4-й столбец


Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];
Console.WriteLine("Введите искомое число");
char[] ch = Console.ReadLine().ToCharArray();
int[] digit = new int[ch.Length];
for (int i = 0; i < ch.Length; i++) digit[i] = int.Parse(ch[i].ToString());
int positionRow = digit[0];
int positionColumn = digit[1];


for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(10);
    Console.Write(matrix[i, j] + "\t");
  }
  Console.WriteLine();
}
Console.WriteLine($"Значение массива в строке {positionRow} и столбце {positionColumn}");
Console.WriteLine(matrix[positionRow - 1, positionColumn - 1]);
*/

/*

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
double sum = 0;

// заполнение массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(10);
    Console.Write(matrix[i, j] + "\t");
  }
  Console.WriteLine();
}
// просчет среднего арифметического столбцов
Console.WriteLine("Среднее арифметическое по столбцам");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    sum += matrix[j, i]; // проходим по столбцам
  }
  Console.Write(sum / rows + "\t");
}
*/
