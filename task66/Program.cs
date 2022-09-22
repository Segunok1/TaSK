/*Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


void PrintArray(int m, int n){
    Console.Write(Sum(m, n));
} 

int Sum(int m, int n)
{
    if (m >= n)
        return 1;
    int result = Sum(m, n - 1);
    return n + result;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Sum(m, n);
PrintArray(m, n);
