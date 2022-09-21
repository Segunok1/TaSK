string[] initialArray = new string[5] { "yes", "hello", "yellow", "9876", "56" };
string[] sortedArray = new string[initialArray.Length];

void PerebArray(string[] initialArray, string[] sortedArray)
{
    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= 3)
        {
            sortedArray[count] = initialArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PerebArray(initialArray, sortedArray);
PrintArray(sortedArray);
