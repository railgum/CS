/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16

Console.WriteLine("Введите основание степени");
int number = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите степень");
int power = Convert.ToInt16(Console.ReadLine());
int result = number;
for (int i = 1; i < power; i++)
{
  result *= number;
}
Console.WriteLine($"{number} в степени {power} равно {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number != 0)
{
  sum += number % 10;
  number /= 10;
}
Console.WriteLine($"В этом числе {sum} цифр");
*/

