/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2

int arraySize = new Random().Next(10);
int[] arrayRandomNumber = new int[arraySize];
int countPositiveNumber = 0;
for (int i = 0; i < arrayRandomNumber.Length; i++)
{
  arrayRandomNumber[i] = new Random().Next(100, 1000);
  if (arrayRandomNumber[i] % 2 == 0)
  {
    countPositiveNumber++;
  }
}
Console.WriteLine($"Массив [{String.Join("; ", arrayRandomNumber)}]");

Console.WriteLine($"В массиве {countPositiveNumber} чётных чисел");
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
  Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0

int arraySize = new Random().Next(10);
int[] arrayRandomNumber = new int[arraySize];
int unevenSum = 0;

for (int i = 0; i < arrayRandomNumber.Length; i++)
{
  arrayRandomNumber[i] = new Random().Next(100);
  if (i % 2 != 0)
  {
    unevenSum += arrayRandomNumber[i];
  }
}

Console.WriteLine($"Массив [{String.Join("; ", arrayRandomNumber)}]");
Console.WriteLine($"В массиве сумма чисел на нечётных позициях равна {unevenSum}");

*/

/* Задача 38: Задайте массив случайных вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Random rnd = new Random();
int arraySize = rnd.Next(10);
double[] arrayRandomNumber = new double[arraySize];

double maxNumber = 0;
double minNumber = 100;

for (int i = 0; i < arrayRandomNumber.Length; i++)
{
  arrayRandomNumber[i] = rnd.NextDouble() * 100;

  if (arrayRandomNumber[i] < minNumber)
  {
    minNumber = arrayRandomNumber[i];
  }
  else if (arrayRandomNumber[i] > maxNumber)
  {
    maxNumber = arrayRandomNumber[i];
  }

}
//Console.WriteLine($"Массив [{String.Join("; ", arrayRandomNumber)}]");

Console.WriteLine($"Разность между min и max равна {Math.Round((maxNumber - minNumber), 2)}");

*/