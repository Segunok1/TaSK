/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка
*/

int[,] myArray = new int[4, 4];
Console.WriteLine();

int[,] GenerateArray(int[,] myArra)
{
    Random random = new Random();
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = random.Next(10);
        }
    }
    return myArray;
}

void PrintArray(int[,] my)
{
    for (int i = 0; i < my.GetLength(0); i++)
    {
        for (int j = 0; j < my.GetLength(1); j++)
        {
            Console.Write(my[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MinRow(int[,] myArray)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < myArray.GetLength(1); i++)
    {
        minRow += myArray[0, i];
    }
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            sumRow += myArray[i, j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Строка с наименьшей суммой элементов: {minSumRow + 1} строка");
}

GenerateArray(myArray);
PrintArray(myArray);
MinRow(myArray);
