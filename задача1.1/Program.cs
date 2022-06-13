//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

using System;
using static System.Console;

Clear();

int number = new Random().Next(100,1000);
WriteLine($"Случайное число: {number} -> {(number/100)*10 + number%10}");
