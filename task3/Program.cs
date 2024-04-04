/*
Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17

6/2 = 3
7/2 = 3(остаок 1)% 7%2 = остаток 1
25 % 10 = остаток 5
253 % 10 = остаток 3
*/

System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int firstnum = num1 / 100;
int lastnum = num1 % 10;
int sum = firstnum + lastnum;
System.Console.WriteLine(" сумма первой и последней цифры " + num1 + " равна " + sum);
System.Console.WriteLine($" сумма первой и последней цифры {num1} равна {sum}");

