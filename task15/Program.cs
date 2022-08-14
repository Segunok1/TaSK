/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 ->  
1 -> нет
*/

Console.WriteLine("Введите число дня недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if(6 == dayWeek || dayWeek == 7)
    {
        Console.WriteLine("Да."); 
    }
     else
     {
        Console.WriteLine("Нет.");

     }