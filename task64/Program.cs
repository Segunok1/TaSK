/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

void PrintNumMN(int m, int n)
{
    if (m == n)
        Console.WriteLine(n);
    else
    {
        Console.Write(m + ", ");
        PrintNumMN(++m, n);
    }
}

string NumsMN(int m, int n)
{
    if (m == n)
        return n.ToString();
    else
        return "" + m.ToString() + ", " + NumsMN(++m, n);
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
NumsMN(m, n);
PrintNumMN(m, n);