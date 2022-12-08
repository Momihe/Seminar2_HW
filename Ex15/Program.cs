﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

1 - понедельник
2 - вторник
3 - среда
4 - четверг
5 - пятница
6 - суббота
7 - воскресенье

*/

Console.Clear();

Console.WriteLine("Введите номер дня недели, где 1 - понедельник ... 7 - воскресенье.");
Console.Write("Номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 || a > 7)
{
    Console.Write("Введите корректный день недели: ");
    a = Convert.ToInt32(Console.ReadLine());
}

if ( a > 0 && a <6)
    Console.Write("Это будний день.");
else
    Console.Write("Это выходной.");
