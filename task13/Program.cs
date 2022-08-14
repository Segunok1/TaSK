/* 
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
int lenght = str.Length;
for(int i = 1; i < str.Length; i++ )
{
     if(2 < str.Length)
    {
        Console.Write("Третья цифра этого числа:  ");
        Console.WriteLine(str[2]);
        break;
    }
    if(1 <= str.Length)
    {
        Console.Write("Третьей цифры нет.");
        break;
    }
}

