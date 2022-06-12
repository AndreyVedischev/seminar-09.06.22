using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine());
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine());

Write(number1%number2==0?"Кратно": $"Не кратно, остаток = {number1%number2}.");