/*
     Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int[] InitArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i =0; i < size; i++)
    {
        array[i] = rnd.Next(999);
    } 
    return array;
}

int Count(int[] array)
{
    int result = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if (array[i]%2 == 0)
        {
            result +=1;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
     for(int i = 0; i<array.Length;i++)
     {
        Console.Write($"{array[i]}  ");
     }
    Console.WriteLine();
}

int[] array = InitArray(4);
PrintArray(array);
Console.WriteLine($"Количество чётных = {Count(array)}");