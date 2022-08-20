/* Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

 Console.WriteLine("Введите числa через запятую: ");
    

void Array() 
{
    string[] str = Console.ReadLine().Split(",");
    int[] array = new int[str.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(str[i].ToString());
    }
    for (int i = 0; i < array.Length; i++)
    {
    }
    int count = str.Length;
    int index = 0;
    Console.Write("[");
    while(index < count)
    {
        Console.Write(str[index]);
        index++;
        if (index < count)
        {
        Console.Write(", ");
        }
    }
    Console.Write("]");
}  


Array();