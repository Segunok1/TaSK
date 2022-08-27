/*Задайте двумерный массив со случайными числами от -10 до 10.
Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

void SumElementsMainDiagonal()
{
    int min = Convert.ToInt32(Console.ReadLine());
    int max = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
            Console.Write(array[i, j] + " ");
            if (i == j)
            {
                sum += array[i, j];
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {array[0, 0]} + {array[1, 1]} + {array[2, 2]} = {sum}");
}


Console.WriteLine("Введите двумерный массив со случайными числами от min до max.: ");
SumElementsMainDiagonal();