/*
Напишите программу, которая принимает на
вход трёхзначное число и удаляет вторую
цифру этого числа.
Примеры
a = 256 => 26
a = 891 => 81
*/

System.Console.WriteLine("Введите трёхзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int firstnum = num1 / 100;
int lastnum = num1 % 10;
System.Console.WriteLine($"{firstnum},{lastnum}");
int result = firstnum*10 + lastnum;
System.Console.WriteLine(result);
