﻿ /*
 Напишите программу, которая принимает на вход трёхзначное число 
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
Console.Write("Вторая цифра этого числа:  ");
Console.WriteLine(str[1]);
