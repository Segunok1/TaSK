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

int[,] myArray = new int[3, 3];
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
    int iMin = 0;

    for (int i = 0; i < myArray.GetLength(1); i++)
    {
        minRow += myArray[0, i];
    }
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < myArray.GetLength(1); j++)
            sum += myArray[i, j];

        if (sum < minRow)
        {
            minRow = sum;
            iMin = i;
        }
    }

    Console.Write($"Строка с наименьшей суммой элементов: {iMin + 1}");
}

GenerateArray(myArray);
PrintArray(myArray);
MinRow(myArray);
