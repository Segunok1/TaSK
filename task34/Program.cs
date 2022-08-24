/*Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// int  n = 5;
void EvenNumbersArray()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 345);
        Console.Write(array[i] + " ");
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i] / 2 * 2 == array[i])
        {
            count ++;
        }
    }
    Console.WriteLine("\nКоличество чётных чисел в массиве: " + count);
}


Console.WriteLine("Введите число длинны массива: ");
EvenNumbersArray();

