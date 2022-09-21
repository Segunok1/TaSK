/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/



// // Console.Write("Введите число: ");
// // int number = Convert.ToInt32(Console.ReadLine());
// // int count = 1;
// // NaturalToLow(number, count);
Console.WriteLine("Введите натуральные числа M:  ");
// int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральные числа N:  ");
// int N = Convert.ToInt32(Console.ReadLine());
NaturalToLow(N, M);

string NaturalToLow(str N, str M)
{
    if (M == N)
    {
        return;
    }
    else
    {
        NaturalToLow(M, N - 1);
        Console.Write(M + " ");
    }
}



// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// NaturalToLow(number, count);


// void NaturalToLow(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         NaturalToLow(n, count + 1);
//         Console.Write(count + " ");
//     }
// }
