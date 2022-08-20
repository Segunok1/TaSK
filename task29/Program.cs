/*Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void SumDigits()
{
    string str = Convert.ToString(number);
    int sum = 0;
    for (int i = 0; i < str.Length; i++)
    {
        int num = Convert.ToInt32(str[i].ToString());
        sum += num;
    }
    Console.WriteLine("Сумма чисел в числе: " + sum);
}

 
SumDigits();