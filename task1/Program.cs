/*
Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет
*/

System.Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(" Первое число " + num1);
System.Console.WriteLine(" Первое число " + num2);

if(num2 == num1 * num1)
{    
    System.Console.WriteLine("yes");
}
else
{
System.Console.WriteLine("no");
}