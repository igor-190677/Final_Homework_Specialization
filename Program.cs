string[] FindItems(string[] arrayUser)
{
    string[] newArray = new string[0];
    for (int i = 0; i < arrayUser.Length; i++)
    {
        if (arrayUser[i].Length <= 3)
        {
            newArray = newArray.Concat(new string[] {arrayUser[i]}).ToArray();
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write($"{array[i]}");
        else
            Console.Write($"{array[i]}, ");
    }
}

string[] array = new string[5] { "Hello", "World", "I", "am", "Igor"};

string[] newArrayUser = FindItems(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Новый массив: ");
PrintArray(newArrayUser);