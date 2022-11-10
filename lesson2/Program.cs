/* 1 задача 
Вывод случайного числа из отрезка [10, 99] и показ наибольшей цифры числа

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {number}");

int digitOne = number / 10;
int digitTwo = number % 10;

Console.WriteLine($"Первая цифра числа: {digitOne}");
Console.WriteLine($"Вторая цифра числа: {digitTwo}");

Console.WriteLine("Самая большая цифра числа: " + Math.Max(digitOne, digitTwo));

*/

/* 2 задача
Программа выводит случайное трёхзначное число и убирает вторую цифру числа

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {randomNumber}");

int digitOne = randomNumber / 100;
int digitTwo = randomNumber % 10;

Console.WriteLine($"Искомое число: {digitOne}{digitTwo}");

*/

/* 3 задача
Программа принимает два числа и проверяет, является ли второе число кратным первому. Если не кратно, выводит остаток от деления

Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int digit = numberOne % numberTwo;
if (digit == 0)
{
  Console.WriteLine("Второе число кратно первому");
}
else Console.WriteLine($"Остаток от деления равен: {digit}");
*/

/* Программа принимает на вход число и проверяет, кратно оно одновременно 7 и 23

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кратно ли число одновременно 7 и 23?");
if (number % 7 == 0 && number % 23 == 0)
{
  Console.WriteLine($"{number} -->  ДА");
}
else Console.WriteLine($"{number}--> НЕТ");

*/