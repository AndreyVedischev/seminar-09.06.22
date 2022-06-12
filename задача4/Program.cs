// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int number1 = Convert.ToInt32(ReadLine());

Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());

string answer = Math.Pow(number1,2)==number2 || Math.Pow(number2,2)==number1? "Да.":"Нет.";
WriteLine(answer);
string answer2 = Math.Pow(number1,2)==number2
?$"{number1} в квадрате это {number2}":Math.Pow(number2,2)==number1?$"{number2} в квадрате это {number1}"
:$"{number1} не является квадратом {number2} и наоборот";
Write(answer2);

