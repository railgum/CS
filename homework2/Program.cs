/* 1 задача 
Программа выводит случайное трёхзначное число и показывает вторую цифру числа

int randomNumber = new Random().Next(100, 1000);

int digitOne = (randomNumber % 100) / 10;
//int digitTwo = randomNumber % 10;

Console.WriteLine($"Вторая цифра случайного числа {randomNumber}: {digitOne}");

*/
/* 2 задача 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
List<int> arrDigit = new List<int>();
while (number > 0)
{
  arrDigit.Insert(0, number % 10);
  //Console.WriteLine(number % 10);
  number /= 10;
}
//Console.WriteLine(arrDigit.Count);

if (arrDigit.Count < 3)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine("Третья цифра числа - " + arrDigit[2]);
}
*/

/* 3 задача
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите номер дня недели");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 6 || numberDay == 7)
{
  Console.WriteLine("Это выходной день!!!)))");
}
else
{
  Console.WriteLine("Это будний день((((");
}

*/