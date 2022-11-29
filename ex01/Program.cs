// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 симвала.

void EnterNewArr (string[] old_array, string[] new_array)
{
    int count=0;
    for (int i=0; i<old_array.Length; i++)
        if (old_array[i].Length<=3)
        {
            new_array[count]=old_array[i];
            count++;
        } 
}

int CountElem(string [] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
        if (array[i].Length<=3) count++;
    return count;
}

void PrintArray(string[] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string[] str_array = {"hello", "2", "world", ":-)"};

Console.WriteLine("Заданный массив:");
PrintArray(str_array);
int kolv=CountElem(str_array);
if (kolv!=0) 
{
    string[] new_array = new string[kolv];
    EnterNewArr (str_array, new_array);
    Console.WriteLine("Новый массив:");
    PrintArray(new_array);
}
else Console.WriteLine("В заданном массиве нет элементов, удовлетворяющих условиям задачи");