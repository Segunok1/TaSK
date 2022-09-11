/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Задайте строки первой матрицы m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте столбцы первой матрицы и строки второй матрицы n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте столбцы второй матрицы r: ");
int r = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = new int[m, n];
int[,] secondМatrix = new int[n, r];
int[,] resaultMatrix = new int[m, r];
GenerateArray(firstMatrix);
GenerateArray(secondМatrix);
MultiMatrix();
Console.WriteLine();

int[,] GenerateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(random.Next(5));
        }
    }
    return array;
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

void MultiMatrix()
{
    for (int i = 0; i < resaultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resaultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondМatrix[k, j];
            }
            resaultMatrix[i, j] = sum;
        }
    }
}

Console.WriteLine("Матрица первая: ");
PrintArray(firstMatrix);
Console.WriteLine();
Console.WriteLine("Матрица вторая: ");
PrintArray(secondМatrix);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(resaultMatrix);
