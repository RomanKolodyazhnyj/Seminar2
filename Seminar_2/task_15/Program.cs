﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели числом: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
if (number == 6 || number == 7) 
    Console.WriteLine("Выходной день");
else Console.WriteLine("Будний день");
}
else
    Console.WriteLine("Несуществующий день недели");