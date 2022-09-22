// int[] you = new int[] {2, 4, 5, 3};
// double sum = 0;
// for (int i = 0; i < you.Length; i++)
// {
//     sum += you[i];
//     Console.WriteLine(you[i]);
// }
// sum = sum / 4;
// Console.WriteLine(sum);
Console.WriteLine("Задайте строки двумерного массива m: " );
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте столбцы двумерного массива n: " );
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
double Avg = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    
    for(int j = 0; j < array.GetLength(1)-1; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + " ");
        
    }
    Avg += array[i, j];
    Avg = Avg / 3;
   
    Console.WriteLine(" ");
    // Console.ReadLine();
}
Console.WriteLine("Average is" + Avg);