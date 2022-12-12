/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] InitArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i =0; i < size; i++)
    {
        array[i] = (double)rnd.Next(0,100) / 10;
    } 
    return array;
}
void PrintArray(double[] array)
{
     for(int i = 0; i<array.Length;i++)
     {
        Console.Write($"{array[i]}  ");
     }
    Console.WriteLine();
}


double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i<array.Length;i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        else if (array[i]<min)
        {
            min = array[i];
        }
    }
    return (max - min);
}

double[] array = InitArray(4);
PrintArray(array);
Console.WriteLine($"Разнца между максимальным и минимальным элементами массива {Diff(array)}");