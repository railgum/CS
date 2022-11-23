/* Задача 53: Задайте двумерный массив. Напишите программу, 
  которая поменяет местами первую и последнюю строку массива.
*/

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

// проверка на "квадратность" массива
if (rows != columns)
{
  Console.WriteLine("Строк и столбцов должно быть одинаковое количество");
  return;
}

// функция создания двумерного массива
//строки - m, столбцы - n, минимум - min, максимум - max
int[,] GetArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(min, max + 1);
    }
  }
  return result;
}

//функция вывода массива

void PrintArray(int[,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      Console.Write(inputArray[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

// функция замены строк
void ChangeRows(int[,] matrix) //matrix - 
{
  int rowCount = matrix.GetLength(0) - 1; // получение индекса последней строки
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    int temp = matrix[0, i];
    matrix[0, i] = matrix[rowCount, i];
    matrix[rowCount, i] = temp;         // сортировка пузырьком
  }
}

/*
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ChangeRows(array);
Console.WriteLine();
PrintArray(array);
*/

/*Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
*/
// функция замены строк столбцами
int[,] ReplaceRowsWithColumns(int[,] original)
{
  int[,] result = new int[original.GetLength(0), original.GetLength(1)];
  for (int i = 0; i < original.GetLength(0); i++)
  {
    for (int j = 0; j < original.GetLength(1); j++)
    {
      result[i, j] = original[j, i];
    }
  }
  return result;
}

/*
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ReplaceRowsWithColumns(array);
PrintArray(array);
*/

/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
  которая удалит строку и столбец, на пересечении которых расположен 
  наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1
*/

int[,] matrix = new int[rows, columns];
int minValue = int.MaxValue;               // Значение минимального элемента
int minIndexRows = 0;                      // Задали индекс строки мин.элемента
int minIndexColumns = 0;                   // Задали индекс столбца мин.элемента

// заполняем массив и ищем минимальное значение массива
for (int i = 0; i < rows; i++)
{
  for (int j = 0; j < columns; j++)
  {
    matrix[i, j] = new Random().Next(11);
    Console.Write(matrix[i, j] + "\t");
    if (minValue > matrix[i, j])
    {
      minValue = matrix[i, j];
      minIndexRows = i;
      minIndexColumns = j;
    }
  }
  Console.WriteLine();
}
Console.WriteLine("Минимальное значение: " + minValue);
Console.WriteLine("Результат: ");

// проходим по массиву, исключая строку и столбец с минимальным значением

for (int i = 0; i < rows; i++)
{
  if (i != minIndexRows)
  {
    for (int j = 0; j < columns; j++)
    {
      if (j != minIndexColumns)
      {
        Console.Write(matrix[i, j] + "\t");
      }
    }
    Console.WriteLine();
  }
}


