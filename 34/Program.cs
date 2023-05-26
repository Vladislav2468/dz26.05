// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int MinVal, int MaxVal)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(MinVal, MaxVal + 1);
        Console.Write(res[i] + " ");
    }
    return res;
}


int GetCount(int[] arr)
{
    int cou = 0;
    foreach(int elem in arr)
    {
        if (elem % 2 == 0)
        {
            cou += 1;
        }
    }
    return cou;
}
int[] array = GetArray(3, 100, 999);
Console.WriteLine();
Console.WriteLine("Количество четных чисел = " + GetCount(array));
