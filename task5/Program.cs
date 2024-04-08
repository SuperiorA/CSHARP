/*
Напишите программу, которая принимает на вход
трёхзначное число и возводит вторую цифру этого
числа в степень, равную третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1
*/

System.Console.WriteLine("Введите трёхзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int firstnum = num1 / 10 % 10;
int lastnum = num1 % 10;
int i = 1;
int result = firstnum;
while (i < lastnum)
    {
     result = firstnum * result;
     i = i + 1; //i++ или i += 1;
    }
System.Console.WriteLine(result);

double result2 = Math.Pow(firstnum,lastnum);
//Math.Pow - это метод возведения в степень
//firstnum - число,которое вводим в степень, lastnum - степень, в которую возводим
System.Console.WriteLine(result2);


