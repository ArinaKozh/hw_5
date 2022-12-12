/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


int[] InitArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i =0; i < size; i++)
    {
        array[i] = rnd.Next(99);
    } 
    return array;
}


void PrintArray(int[] array)
{
     for(int i = 0; i<array.Length;i++)
     {
        Console.Write($"{array[i]}  ");
     }
    Console.WriteLine();
}

int Sum(int[] array)
{
    int result = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if (i%2 != 0)
        {
            result += array[i];
        }
    }
    return result;
}

int[] array = InitArray(4);
PrintArray(array);
Console.WriteLine($"Суммa элементов, стоящих на нечётных позициях = {Sum(array)}");

