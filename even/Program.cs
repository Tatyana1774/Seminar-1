﻿ // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 4 -> да, -3 -> нет, 7 -> нет
 int i;
 Console.WriteLine("Введите число ");
 i = Convert.ToInt32(Console.ReadLine());
 
if (i % 2 == 0)
 {

 Console.Write($"{i} -> да");
 Console.Read();
 }

 else
 {

 Console.WriteLine($"{i} -> нет");
 Console.Read();
 }
