using System;
using static System.Console;

Clear();

int number=new Random().Next(100,1000);
System.Console.WriteLine($"Случайное число: {number} -> {(number/100)*10+number%10}");
