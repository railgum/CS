// Рекурсия - вызов функции
/*
int Factorial(int number)
{
  // базовый случай - выход из рекурсии
  if (number == 1) return 1;
  // рекурсивный случай - вызов функции
  return (number * Factorial(number - 1));
}
// Console.WriteLine(Factorial(4));
*/
/*задача 63
Задайте значение n. Выведите все натуральные числа от s до n.

Console.Write("Введите начало вывода: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец вывода: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
  if (start == end) return start.ToString();
  return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(s, n));

*/
/* *Задача 67: *Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int PrintSumDigit(int digit)
{
  if (digit == 0) return 0;
  return (digit % 10 + PrintSumDigit(digit / 10));
}
Console.WriteLine(PrintSumDigit(number));
*/

/* Задача 69: *Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8


Console.WriteLine("Введите основание степени: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());

int NumberToPower(int N, int P)
{
  if (P == 0) return 1;  // либо if(P==1) return N
  return (N * NumberToPower(N, P - 1));
}
Console.WriteLine(NumberToPower(number, power));
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Введите начало: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец: ");
int end = Convert.ToInt32(Console.ReadLine());

int SumNumber(int M, int N)
{
  if (M == N) return M;
  return (M + SumNumber(M + 1, N));
}
Console.WriteLine(SumNumber(start, end));
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Функция Аккермана A(m,n)");
Console.Write("Введите аргумент m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите аргумент n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
  else return n + 1;
}
Console.WriteLine(Akkerman(m, n));
*/