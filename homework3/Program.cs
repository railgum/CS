/* Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int paliNumber = Convert.ToInt32(Console.ReadLine());

if (paliNumber > 100000 || paliNumber < 9999)
{
  Console.WriteLine("Нужно ввести ПЯТИзначное число");
}
else if ((paliNumber / 10000 == paliNumber % 10) && (paliNumber % 10000 / 1000 == paliNumber % 100 / 10)) Console.WriteLine("Число - палиндром");
else Console.WriteLine("Число не палиндром");

*/

/* Задача 2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A(3, 6, 8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координаты первой точки");

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");

int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double num = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

Console.WriteLine($"Расстояние между точками - {num}");

*/

/* Задача 3

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125



Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
  Console.WriteLine($"Число {i} в кубе равно {i * i * i}");
}

*/