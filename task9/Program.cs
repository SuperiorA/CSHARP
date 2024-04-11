/*
int[] array = {4, 1, 3, 6, 7};
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < array.Length)
{
    if (number == array[i])
    {
        System.Console.WriteLine("Yes");
    }
    else 
    {
        System.Console.WriteLine("No");
    }
    i++;
}
*/

/*
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]
*/

/*
int[] array = {4, 1, 3, -6, 7, -10};

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i]*-1;
    System.Console.Write(array[i]+ " ");
}
*/

/* 
Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
*/

/*
int[] array1 = { 4, 1, 3, 6, 7, 10 };
int[] array2 = new int[array1.Length / 2];

for (int i = 0; i < array1.Length / 2; i++)
{
    array2[i] = array1[i] * array1[array1.Length - 1 - i];//Это разворот массива
    System.Console.Write(array2[i] + " ");
}
*/

/*
Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7]
*/

System.Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [3];
int i = 0;

while (number > 0)
{
    array[i] = number % 10;
    number = number / 10;
    System.Console.Write(array[i] + " ");
    i++;
}
