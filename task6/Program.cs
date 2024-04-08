/*
Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число некратно
второму, то программа выводит остаток от деления.
Примеры
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1
*/

System.Console.WriteLine("Введите числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0)
    {
    System.Console.WriteLine("да");
    }
else
    {
    System.Console.WriteLine("нет " + num1 % num2);
    }