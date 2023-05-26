// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumNum(int[] arr)
{
    int summ = 0;
    foreach(int elem in arr)
    {
        if (Array.IndexOf(arr, elem) % 2 != 0)
        {
            summ = summ + elem;
        }
    }
    return summ;
}
int[] array = GetArray(4, -100, 100);
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + GetSumNum(array));