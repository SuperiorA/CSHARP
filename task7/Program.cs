/*
Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что
третьей цифры нет.
456 => 6
7812 => 1
91 => Третьей цифры нет
*/

System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
while (num1 > 999)
    {
     num1 = num1 / 10;
    }
if (num1 < 100)
    {
    System.Console.WriteLine("третьей цифры нет");
    }
else
    {
    System.Console.WriteLine("третья цифра числа " + num1 % 10);
    }