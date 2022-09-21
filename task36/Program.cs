/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void SumNonEvenIndexes()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
        Console.Write(array[i] + " ");
    }
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {    
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    Console.WriteLine("\nСумма элементов, стоящих на нечётных позициях: " + sum);
}




SumNonEvenIndexes();
