/* Задача 1: Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number / 10 >= 0)
{
  int d = number % 10;
  if (d != 0)
  {
    count++;
  }
  else break;
  number /= 10;
}

Console.WriteLine($"В этом числе {count} цифр");

!!! Альтернатива 

while (number != 0)
{
  number /= 10;
  count++;
}
*/
/*
Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 2; i <= number; i++)
{
  factorial *= i;
}

Console.WriteLine($"Произведение чисел от 1 до {number} равно {factorial}");
*/

/*
Задача 3: Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

int[] getBinaryArray(int size)   // функция
{
  int[] rezult = new int[size];
  for (int i = 0; i < size; i++)
  {
    rezult[i] = new Random().Next(2);
  }
  return rezult;
}

Console.WriteLine("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = getBinaryArray(arraySize);
Console.WriteLine($"[{String.Join("; ", array)}]");

*/