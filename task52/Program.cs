/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.Write("Задайте строки двумерного массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте столбцы двумерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

void TwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintSumArray(int[,] array)
{
    int[] sum = new int[n];
    for (int i = 0; i <  array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum[i] += array[j, i];
        }
    }
    for (int i = 0; i <  array.GetLength(1); i++)
    {
        Console.Write((double)sum[i] /  array.GetLength(1) + " ");
    }

    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
}

TwoDimensionalArray(array);
PrintArray(array);
PrintSumArray(array);
