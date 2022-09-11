/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,0,1)
34(0,1,0) 41(0,1,1)
27(1,0,0) 90(1,0,1)
26(1,1,0) 55(1,1,1)
*/
int[,,] myArray = new int[2, 2, 2];
Random random = new Random();
int[,,] Array3D(int[,,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                myArray[i, j, k] = random.Next(100);
            }
        }
    }
    return myArray;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                Console.Write(myArray[i, j, k] + "");
                Console.Write("({0},{1},{2})  ", i, j, k);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.ReadLine();
}

Array3D(myArray);
PrintArray(myArray);
