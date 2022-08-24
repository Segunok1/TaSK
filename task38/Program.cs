/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void Difference()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
        Console.Write(array[i] + " ");
    }
    int imax = 0;
    int imin = 0;
    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i] > array[imax])
            imax = i;
        if (array[i] < array[imin])
            imin = i;
    }
    Console.WriteLine("\nmin : = " + array[imin]);
    Console.WriteLine("\nmax : = " + array[imax]);
    Console.WriteLine($"\nРазница между max и min элементов массива: {array[imax]-array[imin]}");
}


Console.WriteLine("Введите число длинны массива: ");
Difference();

