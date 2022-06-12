//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.


using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int number1 = Convert.ToInt32(ReadLine());

Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());

if (number2%number1 == 0)
{
    WriteLine("Второе число кратно первому.");

}
else
{
WriteLine(number2%number1);
}