string[] array = { "Hello", "2", "world", ":-)" };
int maxSize = 3;
PrintArray(array);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int CountNewArray(string[] array)
{
    int countNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxSize)
        {
            countNewArray++;
        }
    }

    return countNewArray;
}