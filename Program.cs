string[] sourceArray = new string[5] { "4785", "11", "привет", "мама", "сон" };
string[] targetArray = new string[sourceArray.Length];

void ModifiedArray(string[] sourceArray, string[] targetArray)
{
    int count = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            targetArray[count] = sourceArray[i];
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

ModifiedArray(sourceArray, targetArray);
PrintArray(sourceArray);
PrintArray(targetArray);
