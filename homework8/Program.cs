/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/

//Console.WriteLine("Введите количество строк");
//int rows = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов");
//int columns = int.Parse(Console.ReadLine());

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

// функция сортировки строк двумерного массива
void SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int n = j + 1; n < array.GetLength(1); n++)
      {
        if (array[i, j] > array[i, n]) // по убыванию. по возрастанию - поменять знак
        {
          int temp = array[i, j];
          array[i, j] = array[i, n];
          array[i, n] = temp;
        }
      }
    }
  }
}
/*
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
//функция поиска строки с минимальной суммой элементов
void MinSumOnRows(int[,] matrix)
{
  int minSum = int.MaxValue;
  int rowIndex = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int tempSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      tempSum += matrix[i, j];
    }
    if (minSum > tempSum)
    {
      minSum = tempSum;
      rowIndex = i;
    }
  }
  Console.WriteLine($"Минимальная сумма({minSum}) на: {rowIndex + 1} стр.");
}
/*
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
MinSumOnRows(array);
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
// функция перемножения одноразмерных двумерных массивов
int[,] MultiMatrix(int[,] matrixOne, int[,] matrixTwo)
{
  int[,] result = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
  if (matrixOne.GetLength(0) != matrixTwo.GetLength(0) && matrixOne.GetLength(1) != matrixTwo.GetLength(1))
  {
    Console.WriteLine("Массивы не равны");
  }
  else
  {
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
      for (int j = 0; j < matrixOne.GetLength(1); j++)
      {
        result[i, j] = matrixOne[i, j] * matrixTwo[i, j];
      }
    }
  }
  return result;
}
/*
Console.WriteLine();
int[,] array1 = GetArray(rows, columns, 0, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array2);

Console.WriteLine("Произведение массивов:");
PrintArray(MultiMatrix(array1, array2));
*/

/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)

*/
/*
Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество страниц");
int pages = int.Parse(Console.ReadLine());
*/
// функция создания трехмерного массива
int[,,] ThreeDMatrix(int x, int y, int z, int min, int max)
{
  int[,,] result = new int[x, y, z];
  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      for (int k = 0; k < z; k++)
      {
        result[i, j, k] = new Random().Next(min, max + 1);
      }
    }
  }
  return result;
}

// функция вывода трехмерного массива
void PrintThreeD(int[,,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      for (int k = 0; k < inputArray.GetLength(2); k++)
      {
        Console.Write(inputArray[i, j, k] + $"({i},{j},{k})  ");
      }
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}
/*
int[,,] array = ThreeDMatrix(rows, columns, pages, 0, 10);
PrintThreeD(array);
*/

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
/* решение с Stackoverflow --- непонятно не разобрался----
Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите начальный номер");
//int startNumber = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите шаг");
//int stepNumber = int.Parse(Console.ReadLine());
bool errorFlag = false;

if (!errorFlag)
{
  int[,] result = new int[rows, columns];
  result = SpiralArray(result, rows, columns);
  PrintArray(result);
}

int[,] SpiralArray(int[,] result, int rows, int columns)
{
  int[,] arrSpiral;
  if (rows <= 2 || columns <= 2)
  {
    if (rows == 2 && columns == 2)
    {
      int[,] temp = new int[rows, columns];
      temp[0, 0] = result[0, 0];
      temp[0, 1] = result[0, 1];
      temp[1, 0] = result[1, 1];
      temp[1, 1] = result[1, 0];
      return temp;
    }
    else if (rows == 2)
    {
      int[,] temp = new int[rows, columns];
      for (int i = 0; i < columns; i++)
      {
        temp[0, i] = result[0, i];
        temp[1, columns - 1 - i] = result[1, i];
      }
      return temp;
    }
    else if (columns == 2)
    {
      int[,] temp = new int[rows, columns];
      int[] sizeArr = new int[rows * columns];
      int c = 0;
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < columns; j++)
        {
          sizeArr[c] = result[i, j];
          c++;
        }
      }
      c = 0;
      for (int i = 0; i < columns; i++)
      {
        temp[0, i] = sizeArr[c];
        c++;
      }
      for (int i = 1; i < columns; i++)
      {
        temp[i, 1] = sizeArr[c];
        c++;
      }
      if (rows > 1)
      {
        temp[rows - 1, 0] = sizeArr[c];
      }
      c++;
      for (int i = rows - 2; i >= 1; i--)
      {
        temp[i, 0] = sizeArr[c];
        c++;
      }
      return temp;
    }
    else return result;
  }
  arrSpiral = new int[rows - 2, columns - 2];
  int[,] internalArray = new int[rows - 2, columns - 2];
  for (int i = 0; i < ((rows - 2) * (columns - 2)); i++)
  {
    internalArray[(rows - 2) - 1 - i / (columns - 2), (columns - 2) - 1 - i % (columns - 2)] = result[rows - 1 - (i / columns), columns - 1 - (i % columns)];
  }
  arrSpiral = SpiralArray(internalArray, rows - 2, columns - 2);
  int[,] returnArray = new int[rows, columns];
  int[] tempArray = new int[(rows * columns) - ((rows - 2) * (columns - 2))];
  for (int i = 0; i < (rows * columns) - ((rows - 2) * (columns - 2)); i++)
  {
    tempArray[i] = result[i / columns, i % columns];
  }
  int count = 0;
  for (int i = 0; i < columns; i++)
  {
    returnArray[0, i] = tempArray[count];
    count++;
  }
  for (int i = 0; i < rows; i++)
  {
    returnArray[i, columns - 1] = tempArray[count];
    count++;
  }
  for (int i = columns - 2; i >= 0; i--)
  {
    returnArray[rows - 1, i] = tempArray[count];
    count++;
  }
  for (int i = rows - 2; i >= 1; i--)
  {
    returnArray[i, 0] = tempArray[count];
    count++;
  }
  for (int i = 0; i < rows - 1; i++)
  {
    for (int j = 0; j < columns - 1; j++)
    {
      returnArray[i, j] = internalArray[i - 1, j - 1];
    }
  }
  return returnArray;
}
*/