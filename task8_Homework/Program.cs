/*
Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
*/

/*
System.Console.WriteLine("Пиши");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
    {
    System.Console.WriteLine("Ok");
    }
else
    {
    System.Console.WriteLine("This is bad");
    }
*/

/*
Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
*/

/*
System.Console.WriteLine("Задайте координаты x и y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
    {
    System.Console.WriteLine("First");
    }
else if (x > 0 && y < 0)
    {
    System.Console.WriteLine("Second");
    }
else if (x < 0 && y < 0)
    {
    System.Console.WriteLine("Third");
    }
else if (x < 0 && y > 0)
    {
    System.Console.WriteLine("Fourth");
    }
else
    {
    System.Console.WriteLine("Coordinat centre");
    }
*/

/*
Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
*/

/*
System.Console.WriteLine("Введите число от 10 до 99");
int wholenumber = Convert.ToInt32(Console.ReadLine());
int firstnumber = wholenumber / 10;
int secondnumber = wholenumber % 10;
int maxnumber = 0;

if (firstnumber > secondnumber)
    {
    maxnumber = firstnumber;
    System.Console.WriteLine(maxnumber);
    }
else if (firstnumber < secondnumber)
    {
    maxnumber = secondnumber;
    System.Console.WriteLine(maxnumber);
    }
else
    {
    System.Console.WriteLine(firstnumber);
    }
*/

/*
Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
*/

System.Console.WriteLine("Введите натуральное число N");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 10)
    {
    if (number >= 10)
        {
        int currentnumber = number % 10;
        number = number / 10;
        System.Console.WriteLine(currentnumber + ",");
        }
    }
if (number < 10)
    {
    System.Console.WriteLine(number);
    }
