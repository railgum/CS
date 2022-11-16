/* -- Задача 31: Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.WriteLine("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] arrayRandomNumber = new int[arraySize];

int resultPositive = 0;
int resultNegative = 0;

for (int i = 0; i < arrayRandomNumber.Length; i++)
{
  arrayRandomNumber[i] = new Random().Next(-9, 10);
  if (arrayRandomNumber[i] > 0)
  {
    resultPositive += arrayRandomNumber[i];
  }
  else
  {
    resultNegative += arrayRandomNumber[i];
  }
}

//Console.WriteLine($"[{String.Join(", ", arrayRandomNumber)}]");

Console.WriteLine($"Сумма положительных чисел: {resultPositive}");
Console.WriteLine($"Сумма отрицательных чисел: {resultNegative}");

*/

/* Найдите произведение пар чисел в одномерном массиве.
  Парой считаем первый и последний элемент,
  второй и предпоследний и т.д. Результат запишите в новом массиве.
   [1 2 3 4 5] -> 5 8 3
   [6 7 3 6] -> 36 21


int[] inputArray = { 1, 2, 3, 4, 5 };

int lastIndex = inputArray.Length - 1;

int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

for (int i = 0; i < resultArray.Length; i++)
{
  resultArray[i] = inputArray[i] * inputArray[lastIndex - i];
  if (i == lastIndex - i)
  {
    resultArray[i] = inputArray[i];
  }
}

Console.WriteLine($"Результат: [{String.Join(", ", resultArray)}]");

*/

/* Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] arrayOne = { -4, -8, 8, 2 };
int[] arrayTwo = new int[arrayOne.Length];

for (int i = 0; i < arrayOne.Length; i++)
{
  arrayTwo[i] = arrayOne[i] * (-1);
}
Console.WriteLine(String.Join(",", arrayTwo));

!!! Альтернатива !!!

int[] array = { -4, -8, 8, 2 };
for (int i = 0; i < array.Length; i++)
{
  array[i] = -arrayOne[i];
}

*/

/* Задайте массив.Напишите программу, которая определяет, 
  присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
- 3; массив[6, 7, 19, 345, 3]->да

int[] array = { 6, 7, 19, 345, 3 };

int searchNumber = 3;

bool flag = false;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] == searchNumber) 
  {
    flag = true;
    break;
  }
}

if (flag) Console.WriteLine("да");
else Console.WriteLine("нет");

*/