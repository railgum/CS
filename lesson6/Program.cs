/* Переписать массив в обратном порядке.

int[] array = new int[5];
int[] reverseArray = new int[5];
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1, 11);
}

Console.WriteLine($"Array: [{String.Join("; ", array)}]");

// запись массива в обратном порядке

for (int index = 0; index < array.Length; index++)
{
  reverseArray[index] = array[array.Length - 1 - index];
}

Console.WriteLine($"Reverse array: [{String.Join("; ", reverseArray)}]");

*/

/* Напишите программу, которая принимает на вход три числа 
  и проверяет, может ли существовать треугольник с сторонами такой длины.

  bool DoesTriangle(int a, int b, int c)
  {
    if ((a + b) > c && (a + c) > b && (b + c) > a)
    {
      return true;
    }
    else return false;
  }

  if (DoesTriangle(8, 7, 6))
  {
    Console.WriteLine("Существует");
  }
  else
  {
    Console.WriteLine("Не существует");

  }

*/

/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci(int n)
{
  int[] array = new int[n];
  array[0] = 0;
  array[1] = 1;
  for (int i = 2; i < array.Length; i++)
  {
    array[i] = array[i - 2] + array[i - 1];
  }
  return array;
}

Console.WriteLine("Сколько чисел Фибоначчи вывести?");
int fibNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Числа Фибоначчи до {fibNumber}: [{String.Join(" ", Fibonacci(fibNumber))}]");


// !!! Альтернатива без массива !!!

double N = 10; // количество чисел
double firstElem = 0;
double secondElem = 1;
Console.WriteLine($"Элемент 1 - {firstElem}");
Console.WriteLine($"Элемент 2 - {secondElem}");

for (int i = 3; i < N; i++)
{
  double nextElem = firstElem + secondElem;
  Console.WriteLine($"Элемент {i} - {nextElem}");
  firstElem = secondElem;
  secondElem = nextElem;
}

*/

/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

void ConversionBinary(int number)
{
  string result = String.Empty;
  while (number > 0)
  {
    result = number % 2 + result;
    number /= 2;
  }
  Console.WriteLine($"В двоичном виде это будет: {result}");
}
Console.WriteLine("Введите десятичное число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
ConversionBinary(inputNumber);

*/

