/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
  сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа через запятую");
string userNumber = Console.ReadLine();

string[] subNumber = userNumber.Split(",");
int countPositive = 0;
foreach (var sub in subNumber)
{
  if (Convert.ToInt32(sub) > 0)
  {
    countPositive++;
  }
}
Console.WriteLine($"Вы ввели {countPositive} положительных чисел");

*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите значения k1 k2 b1 b2 через пробел");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int k1 = array[0];
int k2 = array[1];
int b1 = array[2];
int b2 = array[3];
float X, Y;
if (k1 == k2)
{
  Console.WriteLine("Прямые параллельны");
}
else if (k1 == k2 && b1 == b2)
{
  Console.WriteLine("Прямые совпадают");
}
else
{
  X = (float)(b2 - b1) / (k1 - k2);
  Y = k1 * X + b1;
  Console.WriteLine($"Точка пересечения прямых: (X = {X:0.00}; Y = {Y:0.00})");
}

*/





