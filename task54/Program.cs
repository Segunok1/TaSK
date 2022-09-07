/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Console.Write("Задайте строки двумерного массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте столбцы двумерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int[m, n];
Console.WriteLine();
Console.WriteLine("Массив до изменения");
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

void BubbleSort(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(1) - 1; k++)
            {
                if (myArray[i, k] < myArray[i, k + 1])
                {
                    int temp;
                    temp = myArray[i, k ];
                    myArray[i, k ] = myArray[i, k + 1];
                    myArray[i, k + 1] = temp;
                }
            }
        }
        
    }

    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями");
    PrintArray(myArray);
}


GenerateArray(myArray);
PrintArray(myArray);
BubbleSort(myArray);
