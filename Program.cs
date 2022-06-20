string[] array = new string[3];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine()!;
}
Console.Write("Заданный массив: ");
WriteArray(array);
string[] newArray = OutputArray(array);
Console.Write("Итоговый массив: ");
WriteArray(newArray);


string[] OutputArray(string[] array)
{
    string output = string.Empty;
    string[] newArray = new string[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        output = array[i];
        if (output.Length > 3)
            continue;
        newArray[i] = output;
    }
    return newArray;
}
void WriteArray(string []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
