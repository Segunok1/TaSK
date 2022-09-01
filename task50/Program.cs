/*Напишите программу, которая на вход принимает число,
и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Write("Задайте число : ");
int val = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3, 4];
string resault = "";

void TwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
            if (array[i, j] == val)
                resault += (i, j);
        }
    }
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
Console.WriteLine(
    resault == ""
        ? val + " " + "->" + " " + "такого числа в массиве нет"
        : "Индексы этого числа: " + resault
);
