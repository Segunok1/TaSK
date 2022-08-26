/*Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

void NumOfPositiveNum()
{
    int k = 0;
    string[] str = Console.ReadLine().Split(",");
    int[] array = new int[str.Length];
    for (int i = 0; i < array.Length; i++) array[i] = Convert.ToInt32(str[i].ToString());
    for (int i = 0; i < array.Length; i++) 
        if (array[i] > 0)  k++;
        Console.WriteLine("Количество чётных чисел в массиве: " + k);
}


Console.WriteLine("Введите  M чисел с клавиатуры через запятую: ");
NumOfPositiveNum();
