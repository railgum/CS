/* --1 задание--

Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
  Console.WriteLine("Число " + number1 + " больше, чем " + number2);
}
else if (number1 == number2)
{
  Console.WriteLine("Числа равны");
}
else
{
  Console.WriteLine("Число " + number2 + " больше, чем " + number1);
}

*/

/* --2 задание--

Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
  Console.WriteLine("Число " + number1 + " самое большое");
}
else if (number2 > number1 && number2 > number3)
{
  Console.WriteLine("Число " + number2 + " самое большое");
}
else
{
  Console.WriteLine("Число " + number3 + " самое большое");
}
*/

/* --3 задание--

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
  Console.WriteLine("Число четное");
}
else
{
  Console.WriteLine("Число нечетное");
}
*/

/* --4 задание --

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < number)
{
  if (i % 2 == 0)
  {
    Console.Write(i + "  ");
  }
  i++;
}

*/